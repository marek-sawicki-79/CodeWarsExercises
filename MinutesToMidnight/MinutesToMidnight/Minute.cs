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
            DateTime midnight = DateTime.Today;
            midnight = midnight.Date;
            TimeSpan minutesLeft = midnight - d;
            if (minutesLeft.ToString() == "1")
            return $"{minutesLeft.TotalMinutes.ToString()} minute";
            else return $"{minutesLeft.TotalMinutes.ToString()} minutes";
        }
    }
}
