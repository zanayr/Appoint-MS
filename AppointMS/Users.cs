using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;

namespace c969_Fickenscher
{
    public class User
    {
        public int ID { get; }
        public string Name { get; set; }
        public string Password { get; set; }
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
        
        public User(int id)
        {
            ID = id;
        }

        //  Return an obsucred User password.
        public string ObscurePassword()
        {
            string obscured = "";
            for (int j = 0; j < Password.Length - 3; j++)
            {
                obscured += "*";
            }
            return obscured + Password.Substring(Password.Length - 3, 3);
        }
    }

    public static class Users
    {
        public static User CurrentUser { get; set; }
        public static List<User> AllUserLists = new List<User>();

        //  Get next ID value from database.
        public static int GetNextID()
        {
            return Convert.ToInt32(Database.ExecuteScalar(new MySqlCommand("SELECT MAX(userId) FROM user;"))) + 1;
        }

        //  The following methods replaced the four methods below. vvv
        //  NOTE:   Although it was possible to even skip these methods and use the
        //          Where and First methods in situ, I believe abstracting them out
        //          with appropriate names makes the code easier to read.
        //  Returns true if the User that matches the condition exists in the
        //  AllUSersList, false if it does not.
        public static bool SearchBy(Func<User, bool> condition)
        {
            if (AllUserLists.Where(condition).Count() > 0)
            {
                return true;
            }
            return false;
        }

        //  Returns an User with a search condition.
        public static User GetUserBy(Func<User, bool> condition)
        {
            return AllUserLists.First(condition);
        }

        //  Returns a list of Users with a search condition.
        public static List<User> GetBy(Func<User, bool> condition)
        {
            return AllUserLists.Where(condition).ToList();
        }

        //  The following methods were replaced by the methods above. ^^^
        //  NOTE:   By using lambda functions, what once took four methods, now only
        //          uses two methods. The third method can get a list of users
        //          matching any condition. Very handy!
        /*
        public static bool SearchUser(string name)
        {
            foreach (User user in AllUserLists)
            {
                if (user.Name == name)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool SearchUser(int id)
        {
            foreach (User user in AllUserLists)
            {
                if (user.ID == id)
                {
                    return true;
                }
            }
            return false;
        }
        public static User GetUser(string name)
        {
            foreach (User user in AllUserLists)
            {
                if (user.Name == name)
                {
                    return user;
                }
            }
            return new User(0);
        }
        public static User GetUser(int id)
        {
            foreach (User user in AllUserLists)
            {
                if (user.ID == id)
                {
                    return user;
                }
            }
            return new User(0);
        }
        */
    }
}