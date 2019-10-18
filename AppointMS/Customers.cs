using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using MySql.Data.MySqlClient;

namespace c969_Fickenscher
{
    public class UnableToDeleteCustomerException : Exception
    {
        public UnableToDeleteCustomerException()
        {

        }

        public UnableToDeleteCustomerException(string message)
            : base(message)
        {

        }

        public UnableToDeleteCustomerException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }
    public class Customer
    {
        public int ID { get; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public bool Active { get; set; }
        public DateTime _createDate;
        public User CreateBy { get; set; }
        public DateTime UpdateTimestamp { get; set; }
        public User UpdateBy { get; set; }
        
        public DateTime CreateDate
        {
            get { return _createDate; }
            set { _createDate = value.Date; }
        }

        //  Use this constructor for existing customers from the database.
        public Customer(int id)
        {
            ID = id;
        }
    }

    class Customers
    {
        public static BindingList<Customer> AllCustomersList = new BindingList<Customer>();

        //  Get the next ID value from database.
        public static int GetNextID()
        {
            return Convert.ToInt32(Database.ExecuteScalar(new MySqlCommand("SELECT IFNULL(MAX(customerId), 0) FROM customer WHERE customerName IS NOT NULL;"))) + 1;
        }

        //  The following methods replaced the four methods below. vvv
        //  NOTE:   Although it was possible to even skip these methods and use the
        //          Where and First methods in situ, I believe abstracting them out
        //          with appropriate names makes the code easier to read.
        //  Returns true if the Customer that matches the condition exists in the
        //  AllCustomersList, false if it does not.
        public static bool SearchBy(Func<Customer, bool> condition)
        {
            if (AllCustomersList.Where(condition).Count() > 0)
            {
                return true;
            }
            return false;
        }

        //  Returns a Customer with a search condition.
        public static Customer GetCustomerBy(Func<Customer, bool> condition)
        {
                return AllCustomersList.First(condition);
        }

        //  Returns a list of Customers with a search condition.
        public static List<Customer> GetBy(Func<Customer, bool> condition)
        {
            return AllCustomersList.Where(condition).ToList();
        }

        //  The following methods were replaced by the methods above. ^^^
        //  NOTE:   By using lambda functions, what once took four methods, now only
        //          uses two methods. The third method can get a list of customers
        //          matching any condition. Very handy!
        /*
        public static bool SearchCustomer(string name)
        {
            foreach (Customer customer in AllCustomersList)
            {
                if (customer.Name == name)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool SearchCustomer(int id)
        {
            foreach (Customer customer in AllCustomersList)
            {
                if (customer.ID == id)
                {
                    return true;
                }
            }
            return false;
        }
        public static Customer GetCustomer(string name)
        {
            foreach (Customer customer in AllCustomersList)
            {
                if (customer.Name == name)
                {
                    return customer;
                }
            }
            return new Customer(0);
        }
        public static Customer GetCustomer(int id)
        {
            foreach (Customer customer in AllCustomersList)
            {
                if (customer.ID == id)
                {
                    return customer;
                }
            }
            return new Customer(0);
        }
        */
        //  Return a lsit of the unique countries in the AllCustomersList.
        public static List<int> GetUniqueCountries()
        {
            List<int> uniqueCountries = new List<int>();
            foreach (Customer customer in AllCustomersList)
            {
                int customerCountryID = customer.Address.City.Country.ID;
                bool isUnique = true;
                foreach (int countryID in uniqueCountries)
                {
                    if (countryID == customerCountryID)
                    {
                        isUnique = false;
                    }
                }
                if (isUnique)
                {
                    uniqueCountries.Add(customerCountryID);
                }
            }
            return uniqueCountries;
        }

        //  Update a customer in the database.
        public static void Update(Customer customer)
        {
            string columnValues = "";
            columnValues += "customerName = '" + customer.Name + "', ";
            columnValues += "addressId = " + customer.Address.ID + ", ";
            columnValues += "active = " + Convert.ToInt32(customer.Active) + ", ";
            //  We are not updating the createDate or createBy fields.
            columnValues += "lastUpdate = TIMESTAMP('" + TimeZoneInfo.ConvertTimeToUtc(customer.UpdateTimestamp).ToString("yyyy-MM-dd HH:mm:ss") + "'), ";
            columnValues += "lastUpdateBy = '" + customer.UpdateBy.Name + "'";

            Report.UserActivity(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff").PadRight(30) + "USR".PadRight(5) + Convert.ToString(Users.CurrentUser.ID).PadRight(5) + "UPD".PadRight(5) + "CUS".PadRight(5) + Convert.ToString(customer.ID).PadRight(5));

            Database.ExecuteQuery(new MySqlCommand("UPDATE customer SET " + columnValues + " WHERE customerId = " + customer.ID + ";"));
        }

        public static void Insert(Customer customer)
        {
            string values = "";
            values += Convert.ToString(customer.ID) + ", ";
            values += "'" + customer.Name + "', ";
            values += customer.Address.ID + ", ";
            values += Convert.ToInt32(customer.Active) + ", ";
            values += "DATE('" + TimeZoneInfo.ConvertTimeToUtc(customer.CreateDate).ToString("yyyy-MM-dd") + "'), ";
            values += "'" + customer.CreateBy.Name + "', ";
            values += "TIMESTAMP('" + TimeZoneInfo.ConvertTimeToUtc(customer.UpdateTimestamp).ToString("yyyy-MM-dd HH:mm:ss") + "'), ";
            values += "'" + customer.UpdateBy.Name + "'";

            Report.UserActivity(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff").PadRight(30) + "USR".PadRight(5) + Convert.ToString(Users.CurrentUser.ID).PadRight(5) + "ADD".PadRight(5) + "CUS".PadRight(5) + Convert.ToString(customer.ID).PadRight(5));

            AllCustomersList.Add(customer);
            Database.ExecuteQuery(new MySqlCommand("INSERT INTO customer VALUES (" + values + ");"));
        }
        //  Remove a customer from the database.
        public static void Remove(Customer customer)
        {
            if (Appointments.SearchBy(a => a.Customer.ID == customer.ID))
            {
                string message = "Customer " + customer.ID + " has the following appointments:" + Environment.NewLine;
                Appointments.GetBy(a => a.Customer.ID == customer.ID).ForEach(p =>
                {
                    message += "Appointment " + Convert.ToString(p.ID) + Environment.NewLine;
                });
                message += Environment.NewLine + Environment.NewLine;
                message += "Do you want to delete these appointments?";
                throw new UnableToDeleteCustomerException(message);
            }
            else
            {
                Report.UserActivity(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff").PadRight(30) + "USR".PadRight(5) + Convert.ToString(Users.CurrentUser.ID).PadRight(5) + "DEL".PadRight(5) + "CUS".PadRight(5) + Convert.ToString(customer.ID).PadRight(5));

                AllCustomersList.Remove(customer);
                Database.ExecuteQuery(new MySqlCommand("DELETE FROM customer WHERE customerId = " + customer.ID + ";"));
            }
        }
    }
}