using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheDays
{
    public class Day
    {
        public string countDays(DateTime d)
        {
            TimeSpan days = d - DateTime.Now;
            int result = (int)Math.Round(days.TotalDays);
            return (d.Date < DateTime.Now.Date) ? "The day is in the past!" :
                (d.Date == DateTime.Now.Date) ? "Today is the day!" : $"{result} days";
        }
    }
}
