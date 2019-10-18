using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;

namespace c969_Fickenscher
{
    public class City
    {
        public int ID { get; }
        public string Name { get; set; }
        public Country Country { get; set; }
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

        public City(int id)
        {
            ID = id;
        }
    }

    class Cities
    {
        public static List<City> AllCitiesList = new List<City>();

        //  Get next ID value from database.
        public static int GetNextID()
        {
            return Convert.ToInt32(Database.ExecuteScalar(new MySqlCommand("SELECT IFNULL(MAX(cityId), 0) FROM city;"))) + 1;
        }

        //  The following methods replaced the four methods below. vvv
        //  NOTE:   Although it was possible to even skip these methods and use the
        //          Where and First methods in situ, I believe abstracting them out
        //          with appropriate names makes the code easier to read.
        //  Returns true if the City that matches the condition exists in the
        //  AllCitiesList, false if it does not.
        public static bool SearchBy(Func<City, bool> condition)
        {
            if (AllCitiesList.Where(condition).Count() > 0)
            {
                return true;
            }
            return false;
        }

        //  Returns a City with a search condition.
        public static City GetCityBy(Func<City, bool> condition)
        {
            return AllCitiesList.First(condition);
        }

        //  Returns a list of Cities with a search condition.
        public static List<City> GetBy(Func<City, bool> condition)
        {
            return AllCitiesList.Where(condition).ToList();
        }

        //  The following methods were replaced by the methods above. ^^^
        //  NOTE:   By using lambda functions, what once took four methods, now only
        //          uses two methods. The third method can get a list of Cities
        //          matching any condition. Very handy!
        /*
        public static bool SearchCity(string cityName, int countryId)
        {
            foreach (City city in AllCitiesList)
            {
                if (city.Name == cityName && city.Country.ID == countryId)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool SearchCity(int cityId, int countryId)
        {
            foreach (City city in AllCitiesList)
            {
                if (city.ID == cityId && city.Country.ID == countryId)
                {
                    return true;
                }
            }
            return false;
        }
        public static City GetCity(string cityName, int countryId)
        {
            foreach (City city in AllCitiesList)
            {
                if (city.Name == cityName && city.Country.ID == countryId)
                {
                    return city;
                }
            }
            return new City(0);
        }
        public static City GetCity(int id)
        {
            foreach (City city in AllCitiesList)
            {
                if (city.ID == id)
                {
                    return city;
                }
            }
            return new City(0);
        }
        */

        public static void Insert(City city)
        {
            string values = "";
            values += Convert.ToString(city.ID) + ", ";
            values += "'" + city.Name.Replace("'", "''") + "', ";
            values += city.Country.ID + ", ";
            values += "DATE('" + TimeZoneInfo.ConvertTimeToUtc(city.CreateDate).ToString("yyyy-MM-dd") + "'), ";
            values += "'" + city.CreateBy.Name + "', ";
            values += "TIMESTAMP('" + TimeZoneInfo.ConvertTimeToUtc(city.UpdateTimestamp).ToString("yyyy-MM-dd HH:mm:ss") + "'), ";
            values += "'" + city.UpdateBy.Name + "'";

            Report.UserActivity(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff").PadRight(30) + "USR".PadRight(5) + Convert.ToString(Users.CurrentUser.ID).PadRight(5) + "ADD".PadRight(5) + "CIT".PadRight(5) + Convert.ToString(city.ID).PadRight(5));

            AllCitiesList.Add(city);
            Database.ExecuteQuery(new MySqlCommand("INSERT INTO city VALUES(" + values + ");"));
        }
    }
}