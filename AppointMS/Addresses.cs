using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;

namespace c969_Fickenscher
{
    public class Address
    {
        public int ID { get; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public City City { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public DateTime _createDate;
        public User CreateBy { get; set; }
        public DateTime UpdateTimestamp { get; set; }
        public User UpdateBy { get; set; }
        
        //  Automatically strip hours, minutes and seconds from create date.
        public DateTime CreateDate
        {
            get { return _createDate; }
            set { _createDate = value.Date; }
        }
        
        public Address(int id)
        {
            ID = id;
        }
    }

    class Addresses
    {
        public static List<Address> AllAddressList = new List<Address>();

        //  Get next ID value from the database.
        public static int GetNextID()
        {
            return Convert.ToInt32(Database.ExecuteScalar(new MySqlCommand("SELECT IFNULL(MAX(addressId), 0) FROM address;"))) + 1;
        }

        //  The following methods replaced the four methods below. vvv
        //  NOTE:   Although it was possible to even skip these methods and use the
        //          Where and First methods in situ, I believe abstracting them out
        //          with appropriate names makes the code easier to read.
        //  Returns true if the Address that matches the condition exists in the
        //  AllAddressList, false if it does not.
        public static bool SearchBy(Func<Address, bool> condition)
        {
            if (AllAddressList.Where(condition).Count() > 0)
            {
                return true;
            }
            return false;
        }

        //  Returns an Address with a search condition.
        public static Address GetAddressBy(Func<Address, bool> condition)
        {
            return AllAddressList.First(condition);
        }

        //  Returns a list of Addresses with a search condition.
        public static List<Address> GetBy(Func<Address, bool> condition)
        {
            return AllAddressList.Where(condition).ToList();
        }

        //  The following methods were replaced by the methods above. ^^^
        //  NOTE:   By using lambda functions, what once took four methods, now only
        //          uses two methods. The third method can get a list of addresses
        //          matching any condition. Very handy!
        /*
        public static bool SearchAddress(string address1, string address2, string postalCode, string phone, int cityId)
        {
            foreach (Address address in AllAddressList)
            {
                if (address.Address1 == address1 && address.Address2 == address2 && address.PostalCode == postalCode && address.Phone == phone && address.City.ID == cityId)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool SearchAddress(int addressId, int cityId)
        {
            foreach (Address address in AllAddressList)
            {
                if (address.ID == addressId && address.City.ID == cityId)
                {
                    return true;
                }
            }
            return false;
        }
        public static Address GetAddress(string address1, string address2, string postalCode, string phone, int cityId)
        {
            foreach (Address address in AllAddressList)
            {
                if (address.Address1 == address1 && address.Address2 == address2 && address.PostalCode == postalCode && address.Phone == phone && address.City.ID == cityId)
                {
                    return address;
                }
            }
            return new Address(0);
        }
        public static Address GetAddress(int id)
        {
            foreach (Address address in AllAddressList)
            {
                if (address.ID == id)
                {
                    return address;
                }
            }
            return new Address(0);
        }
        */

        public static void Insert(Address address)
        {
            string values = "";
            values += Convert.ToString(address.ID) + ", ";
            values += "'" + address.Address1.Replace("'", "''") + "', ";
            values += "'" + address.Address2.Replace("'", "''") + "', ";
            values += address.City.ID + ", ";
            values += "'" + address.PostalCode.Replace(" ", "").Trim() + "', ";
            values += "'" + address.Phone.Trim() + "', ";
            values += "DATE('" + TimeZoneInfo.ConvertTimeToUtc(address.CreateDate).ToString("yyyy-MM-dd") + "'), ";
            values += "'" + address.CreateBy.Name + "', ";
            values += "TIMESTAMP('" + TimeZoneInfo.ConvertTimeToUtc(address.UpdateTimestamp).ToString("yyyy-MM-dd HH:mm:ss") + "'), ";
            values += "'" + address.UpdateBy.Name + "'";

            Report.UserActivity(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff").PadRight(30) + "USR".PadRight(5) + Convert.ToString(Users.CurrentUser.ID).PadRight(5) + "ADD".PadRight(5) + "ADR".PadRight(5) + Convert.ToString(address.ID).PadRight(5));

            AllAddressList.Add(address);
            Database.ExecuteQuery(new MySqlCommand("INSERT INTO address VALUES(" + values + ");"));
        }
    }
}