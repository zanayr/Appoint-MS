using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using MySql.Data.MySqlClient;

namespace c969_Fickenscher
{
    public class Appointment
    {
        public int ID { get; }
        public Customer Customer { get; set; }
        public User User { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Contact { get; set; }
        public string Type { get; set; }
        public string URL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime _createDate;
        public User CreateBy { get; set; }
        public DateTime UpdateTimestamp { get; set; }
        public User UpdateBy { get; set; }

        //  Automatically strip hours, minutes and seconds from dates.
        public DateTime CreateDate
        {
            get { return _createDate; }
            set { _createDate = value.ToLocalTime(); }
        }

        public Appointment(int id)
        {
            ID = id;
        }
    }

    public static class Appointments
    {
        public static BindingList<Appointment> AllAppointmentsList = new BindingList<Appointment>();
        public static string[] TypeArray { get; set; } = { "Appointment", "Meeting", "Kick Off", "Check In", "Review" };
        public static string[] LocationArray { get; set; } = { "Tele-confrence", "Video-confrence", "London", "New York City", "Phoenix" };

        //  Get the next ID value from the database.
        public static int GetNextID()
        {
            return Convert.ToInt32(Database.ExecuteScalar(new MySqlCommand("SELECT IFNULL(MAX(appointmentId), 0) FROM appointment;"))) + 1;
        }

        //  The following methods replaced the four methods below. vvv
        //  NOTE:   Although it was possible to even skip these methods and use the
        //          Where and First methods in situ, I believe abstracting them out
        //          with appropriate names makes the code easier to read.
        //  Returns true if the Appointment that matches the condition exists in the
        //  AllAppointmentsList, false if it does not.
        public static bool SearchBy(Func<Appointment, bool> condition)
        {
            if (AllAppointmentsList.Where(condition).Count() > 0)
            {
                return true;
            }
            return false;
        }

        //  Returns a Appointment with a search condition.
        public static Appointment GetAppointmentBy(Func<Appointment, bool> condition)
        {
            return AllAppointmentsList.First(condition);
        }

        //  Returns a list of Appointments with a search condition.
        public static List<Appointment> GetBy(Func<Appointment, bool> condition)
        {
            return AllAppointmentsList.Where(condition).ToList();
        }

        //  The following methods were replaced by the methods above. ^^^
        //  NOTE:   By using lambda functions, what once took four methods, now only
        //          uses two methods. The third method can get a list of Appointments
        //          matching any condition. Very handy!
        /*
        public static bool SearchAppointment(string title)
        {
            foreach (Appointment appointment in AllAppointmentsList)
            {
                if (appointment.Title == title)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool SearchAppointment(int id)
        {
            foreach (Appointment appointment in AllAppointmentsList)
            {
                if (appointment.ID == id)
                {
                    return true;
                }
            }
            return false;
        }
        public static Appointment GetAppointment(string title)
        {
            foreach (Appointment appointment in AllAppointmentsList)
            {
                if (appointment.Title == title)
                {
                    return appointment;
                }
            }
            return new Appointment(0);
        }
        public static Appointment GetAppointment(int id)
        {
            foreach (Appointment appointment in AllAppointmentsList)
            {
                if (appointment.ID == id)
                {
                    return appointment;
                }
            }
            return new Appointment(0);
        }
        */

        //  Return a list of all the unique months withing the AllAppointmentsList.
        public static List<DateTime> GetUniqueMonths()
        {
            List<DateTime> uniqueMonths = new List<DateTime>();
            foreach (Appointment appointment in AllAppointmentsList)
            {
                DateTime appointmentMonth = new DateTime(appointment.StartDate.Year, appointment.StartDate.Month, 1);
                bool isUnique = true;
                foreach (DateTime month in uniqueMonths)
                {
                    if (appointmentMonth == month)
                    {
                        isUnique = false;
                    }
                }
                if (isUnique)
                {
                    uniqueMonths.Add(appointmentMonth);
                }
            }
            return uniqueMonths;
        }
        /*
        public static List<Appointment> GetByUniqueMonth(DateTime month)
        {
            List<Appointment> list = new List<Appointment>();
            foreach (Appointment appointment in Global.appointmentList)
            {
                if (new DateTime(appointment.StartDate.Year, appointment.StartDate.Month, 1) == month)
                {
                    list.Add(appointment);
                }
            }
            return list;
        }
        */

        public static bool Conflict(User user, DateTime startDate, DateTime endDate)
        {
            bool conflict = false;
            GetBy(a => a.User.ID == user.ID).ForEach(p =>
            {
                if (Math.Max(p.StartDate.Truncate(TimeSpan.TicksPerMinute).Ticks, startDate.Truncate(TimeSpan.TicksPerMinute).Ticks) <= Math.Min(p.EndDate.Truncate(TimeSpan.TicksPerMinute).Ticks, endDate.Truncate(TimeSpan.TicksPerMinute).Ticks))
                {
                    conflict = true;
                }
            });
            return conflict;
        }

        //  Update appointment in the database.
        public static void Update(Appointment appointment)
        {
            string columnValues = "";
            columnValues += "customerId = " + appointment.Customer.ID + ", ";
            columnValues += "userId = " + appointment.User.ID + ", ";
            columnValues += "title = '" + appointment.Title.Replace("'", "''") + "', ";
            columnValues += "description = '" + appointment.Description.Replace("'", "''") + "', ";
            columnValues += "location = '" + appointment.Location.Replace("'", "''") + "', ";
            columnValues += "contact = '" + appointment.Contact + "', ";
            columnValues += "type = '" + appointment.Type + "', ";
            columnValues += "url = '" + appointment.URL.Replace(" ", "").Trim() + "', ";
            columnValues += "start = TIMESTAMP('" + TimeZoneInfo.ConvertTimeToUtc(appointment.StartDate).ToString("yyyy-MM-dd HH:mm:ss") + "'), ";
            columnValues += "end = TIMESTAMP('" + TimeZoneInfo.ConvertTimeToUtc(appointment.EndDate).ToString("yyyy-MM-dd HH:mm:ss") + "'), ";
            //  We are not updating the createDate or createBy fields.
            columnValues += "lastUpdate = TIMESTAMP('" + TimeZoneInfo.ConvertTimeToUtc(appointment.UpdateTimestamp).ToString("yyyy-MM-dd HH:mm:ss") + "'), ";
            columnValues += "lastUpdateBy = '" + appointment.UpdateBy.Name + "'";

            Report.UserActivity(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff").PadRight(30) + "USR".PadRight(5) + Convert.ToString(Users.CurrentUser.ID).PadRight(5) + "UPD".PadRight(5) + "APP".PadRight(5) + Convert.ToString(appointment.ID).PadRight(5));

            Database.ExecuteQuery(new MySqlCommand("UPDATE appointment SET " + columnValues + " WHERE appointmentId = " + appointment.ID + ";"));
        }

        //  Insert appointment into the database.
        public static void Insert(Appointment appointment)
        {
            string values = "";
            values += Convert.ToString(appointment.ID) + ", ";
            values += appointment.Customer.ID + ", ";
            values += appointment.User.ID + ", ";
            values += "'" + appointment.Title.Replace("'", "''") + "', ";
            values += "'" + appointment.Description.Replace("'", "''") + "', ";
            values += "'" + appointment.Location.Replace("'", "''") + "', ";
            values += "'" + appointment.Contact + "', ";
            values += "'" + appointment.Type + "', ";
            values += "'" + appointment.URL.Replace(" ", "").Trim() + "', ";
            values += "TIMESTAMP('" + TimeZoneInfo.ConvertTimeToUtc(appointment.StartDate).ToString("yyyy-MM-dd HH:mm:ss") + "'), ";
            values += "TIMESTAMP('" + TimeZoneInfo.ConvertTimeToUtc(appointment.EndDate).ToString("yyyy-MM-dd HH:mm:ss") + "'), ";
            values += "DATE('" + TimeZoneInfo.ConvertTimeToUtc(appointment.CreateDate).ToString("yyyy-MM-dd") + "'), ";
            values += "'" + appointment.CreateBy.Name + "', ";
            values += "TIMESTAMP('" + TimeZoneInfo.ConvertTimeToUtc(appointment.UpdateTimestamp).ToString("yyyy-MM-dd HH:mm:ss") + "'), ";
            values += "'" + appointment.UpdateBy.Name + "'";

            Report.UserActivity(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff").PadRight(30) + "USR".PadRight(5) + Convert.ToString(Users.CurrentUser.ID).PadRight(5) + "ADD".PadRight(5) + "APP".PadRight(5) + Convert.ToString(appointment.ID).PadRight(5));

            AllAppointmentsList.Add(appointment);
            Database.ExecuteQuery(new MySqlCommand("INSERT INTO appointment VALUES (" + values + ");"));
        }

        public static void Remove(Appointment appointment)
        {
            Report.UserActivity(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff").PadRight(30) + "USR".PadRight(5) + Convert.ToString(Users.CurrentUser.ID).PadRight(5) + "DEL".PadRight(5) + "APP".PadRight(5) + Convert.ToString(appointment.ID).PadRight(5));

            AllAppointmentsList.Remove(appointment);
            Database.ExecuteQuery(new MySqlCommand("DELETE FROM appointment WHERE appointmentId = " + appointment.ID + ";"));
        }
    }
}
