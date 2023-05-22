using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnluckyDay
{
    public class Kata
    {
        public static int UnluckyDays(int year)
        {
            List<DateTime> days = new List<DateTime>();
            DateTime startDate = new DateTime(year, 1, 1);
            DateTime endDate = new DateTime(year, 12, 31);

            for(DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if(date.DayOfWeek == DayOfWeek.Friday && date.Day == 13)
                {
                    days.Add(date);
                }
            }
            return days.Count;
        }
    }
}
