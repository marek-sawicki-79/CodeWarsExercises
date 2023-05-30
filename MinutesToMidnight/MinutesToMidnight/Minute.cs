using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinutesToMidnight
{
    public class Minute
    {
        public string countMinutes(DateTime d)
        {
            DateTime midnight = DateTime.Today + TimeSpan.FromHours(24);
            TimeSpan minutesLeft = d - midnight;
            var minutes = Math.Round(Math.Abs(minutesLeft.TotalMinutes));
            if (minutes == 1)
            return $"{minutes} minute";
            else return $"{minutes} minutes";
        }
    }
}
