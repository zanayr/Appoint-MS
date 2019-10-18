using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c969_Fickenscher
{
    class Week
    {
        public int ID { get; }
        public int Sunday { get; set; }
        public int Monday { get; set; }
        public int Tuesday { get; set; }
        public int Wednesday { get; set; }
        public int Thursday { get; set; }
        public int Friday { get; set; }
        public int Saturday { get; set; }
        public List<Day> Days { get; }

        public Week(int id)
        {
            ID = id;
            Days = new List<Day>();
        }

        public void SortDay(Day day, int iterator)
        {
            switch (iterator % 7)
            {
                case 0:
                    Sunday = day.Number;
                    break;
                case 1:
                    Monday = day.Number;
                    break;
                case 2:
                    Tuesday = day.Number;
                    break;
                case 3:
                    Wednesday = day.Number;
                    break;
                case 4:
                    Thursday = day.Number;
                    break;
                case 5:
                    Friday = day.Number;
                    break;
                case 6:
                    Saturday = day.Number;
                    break;
                default:
                    break;
            }
            Days.Add(day);
        }
    }
}
