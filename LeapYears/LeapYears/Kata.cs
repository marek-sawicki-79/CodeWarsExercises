using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYears
{
    public static class Kata
    {
        public static bool IsLeapYear(int year)
        {
            return (year % 4 != 0) ? false : (year % 400 != 0 && year % 100 == 0) ? false : true;
        }
    }
}
