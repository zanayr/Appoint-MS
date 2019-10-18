using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;

namespace c969_Fickenscher
{
    public class Country
    {
        public int ID { get; }
        public string Name { get; set; }
        public DateTime _createDate;
        public User CreateBy { get; set; }
        public DateTime UpdateTimestamp;
        public User UpdateBy { get; set; }

        //  Automatically strip hours, minutes and seconds from dates.
        public DateTime CreateDate
        {
            get { return _createDate; }
            set { _createDate = value.Date; }
        }

        public Country(int id)
        {
            ID = id;
        }
    }

    class Countries
    {
        public static List<Country> AllCountriesList = new List<Country>();

        //  Get next ID value from the database.
        public static int GetNextID()
        {
            return Convert.ToInt32(Database.ExecuteScalar(new MySqlCommand("SELECT IFNULL(MAX(countryId), 0) FROM country;"))) + 1;
        }

        //  The following methods replaced the four methods below. vvv
        //  NOTE:   Although it was possible to even skip these methods and use the
        //          Where and First methods in situ, I believe abstracting them out
        //          with appropriate names makes the code easier to read.
        //  Returns true if the Country that matches the condition exists in the
        //  AllAddressList, false if it does not.
        public static bool SearchBy(Func<Country, bool> condition)
        {
            if (AllCountriesList.Where(condition).Count() > 0)
            {
                return true;
            }
            return false;
        }

        //  Returns a Country with a search condition.
        public static Country GetCountryBy(Func<Country, bool> condition)
        {
            return AllCountriesList.First(condition);
        }

        //  Returns a list of Countries with a search condition.
        public static List<Country> GetBy(Func<Country, bool> condition)
        {
            return AllCountriesList.Where(condition).ToList();
        }

        //  The following methods were replaced by the methods above. ^^^
        //  NOTE:   By using lambda functions, what once took four methods, now only
        //          uses two methods. The third method can get a list of Countries
        //          matching any condition. Very handy!
        /*
        public static bool SearchCountry(string name)
        {
            foreach (Country country in AllCountriesList)
            {
                if (country.Name == name)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool SearchCountry(int id)
        {
            foreach (Country country in AllCountriesList)
            {
                if (country.ID == id)
                {
                    return true;
                }
            }
            return false;
        }
        public static Country GetCountry(string name)
        {
            foreach (Country country in AllCountriesList)
            {
                if (country.Name == name)
                {
                    return country;
                }
            }
            return new Country(0);
        }
        public static Country GetCountry(int id)
        {
            foreach (Country country in AllCountriesList)
            {
                if (country.ID == id)
                {
                    return country;
                }
            }
            return new Country(0);
        }
        */

        public static void Insert(Country country)
        {

            string values = "";
            values += Convert.ToString(country.ID) + ", ";
            values += "'" + country.Name.Replace("'", "''") + "', ";
            values += "DATE('" + TimeZoneInfo.ConvertTimeToUtc(country.CreateDate).ToString("yyyy-MM-dd") + "'), ";
            values += "'" + country.CreateBy.Name + "', ";
            values += "TIMESTAMP('" + TimeZoneInfo.ConvertTimeToUtc(country.UpdateTimestamp).ToString("yyyy-MM-dd HH:mm:ss") + "'), ";
            values += "'" + country.UpdateBy.Name + "'";

            Report.UserActivity(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff").PadRight(30) + "USR".PadRight(5) + Convert.ToString(Users.CurrentUser.ID).PadRight(5) + "ADD".PadRight(5) + "COU".PadRight(5) + Convert.ToString(country.ID).PadRight(5));

            AllCountriesList.Add(country);
            Database.ExecuteQuery(new MySqlCommand("INSERT INTO country VALUES(" + values + ");"));
        }
    }
}