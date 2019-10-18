using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Data;
using System.Globalization;

namespace c969_Fickenscher
{
    static class Global
    {
        public static long[] OperationHours { get; set; } = { new TimeSpan(8, 0, 0).Ticks, new TimeSpan(20, 0, 0).Ticks };
        public static int Language { get; set; } = 0;

        public static DateTime Truncate(this DateTime date, long percision)
        {
            return new DateTime(date.Ticks - date.Ticks % percision, date.Kind);
        }

        public static void ChangeLanguage(string country)
        {
            if (country == "MX" || country == "ES")
            {
                Language = 1;
            }
            else
            {
                Language = 0;
            }
        }
    }
}
