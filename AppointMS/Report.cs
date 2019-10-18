using System;
using System.IO;
using System.Reflection;

namespace c969_Fickenscher
{
    public static class Report
    {
        private static void Logger(string path, string message)
        {
            using (StreamWriter streamWriter = File.AppendText(path))
            {
                TextWriter textWtriter = streamWriter;
                textWtriter.WriteLine(message);
            }
        }

        private static void Log(string report, string message)
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\REPORTS\\" + report + ".txt";
            if (File.Exists(path))
            {
                Logger(path, message);
            }
            else
            {
                FileStream file = File.Create(path);
                file.Close();
                Logger(path, message);
            }
        }

        //  Log user activity.
        public static void UserActivity(string report)
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\REPORTS\\00_USER_ACTIVITY";
            if (Directory.Exists(path))
            {
                Log("00_USER_ACTIVITY//USER_ACTIVITY_REPORT", report);
            }
            else
            {
                Directory.CreateDirectory(path);
                Log("00_USER_ACTIVITY//USER_ACTIVITY_REPORT", report);
            }
        }

        //  Create a report of all the appointment types listed by month,
        //  return a timestamp.
        public static string AppointmentTypeByMonth()
        {
            string report = "";
            string timestamp;
            foreach (DateTime month in Appointments.GetUniqueMonths())
            {
                int appointments = 0;
                int meetings = 0;
                int kickoffs = 0;
                int checkins = 0;
                int reviews = 0;
                report += month.ToString("MMMM, yyyy") + Environment.NewLine;
                //  Here I used a lambda insead of calling the GetByUniqueMonth Method
                //  in the Appointments class.
                //  I did this because this is more understandable than having a method
                //  call and the mess that is the GetByUniqueMonth method here.
                foreach (Appointment appointment in Appointments.GetBy(a => new DateTime(a.StartDate.Year, a.StartDate.Month, 1) == month))
                {
                    switch (Array.IndexOf(Appointments.TypeArray, appointment.Type))
                    {
                        case 0:
                            appointments++;
                            break;
                        case 1:
                            meetings++;
                            break;
                        case 2:
                            kickoffs++;
                            break;
                        case 3:
                            checkins++;
                            break;
                        case 4:
                            reviews++;
                            break;
                        default:
                            break;
                    }
                }
                report += "Appointments:".PadRight(20) + appointments + Environment.NewLine;
                report += "Meetings:".PadRight(20) + meetings + Environment.NewLine;
                report += "Kick Offs:".PadRight(20) + kickoffs + Environment.NewLine;
                report += "Check Ins:".PadRight(20) + checkins + Environment.NewLine;
                report += "Reviews:".PadRight(20) + reviews + Environment.NewLine;
                report += Environment.NewLine;
            }
            timestamp = DateTime.Now.ToString("yyyyMMddHHmmssffff") + "_APPOINTMENT_TYPE_BY_MONTH_REPORT";
            Log(timestamp + "_APPOINTMENT_TYPE_BY_MONTH_REPORT", report);
            return timestamp;
        }

        //  Create a report of all the appointments listed by user,
        //  return a timestamp.
        public static string AppointmentsByUser()
        {
            string report = "";
            string timestamp;
            foreach (User user in Users.AllUserLists)
            {
                int count = 0;
                report += "User " + Convert.ToString(user.ID).PadRight(5) + user.Name.PadRight(20) + " has a total of ";
                foreach (Appointment appointment in Appointments.GetBy(a => a.User.ID == user.ID))
                {
                    count++;
                }
                report += Convert.ToString(count) + " appointments." + Environment.NewLine;
            }
            timestamp = DateTime.Now.ToString("yyyyMMddHHmmssffff");
            Log(timestamp + "_APPOINTMENTS_BY_CONSULTANT", report);
            return timestamp;
        }

        //  Create a report of all he customers listed by countires,
        //  return a timestamp.
        public static string CustomersByCountry()
        {
            string report = "";
            string timestamp;
            foreach (int id in Customers.GetUniqueCountries())
            {
                int count = 0;
                report += Countries.GetCountryBy(c => c.ID == id).Name + " has a total of ";
                foreach (Customer customer in Customers.GetBy(c => c.Address.City.Country.ID == id))
                {
                    count++;
                    //_content += customer.Address.City.Country.ID + Environment.NewLine;
                }
                report += Convert.ToString(count) + " customers." + Environment.NewLine;
            }
            timestamp = DateTime.Now.ToString("yyyyMMddHHmmssffff");
            Log(timestamp + "_CUSTOMERS_BY_COUNTRY_REPORT", report);
            return timestamp;
        }
    }
}
