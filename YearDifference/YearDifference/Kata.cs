using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearDifference
{
    public static class Kata
    {
        public static int HowManyYears(string date1, string date2)
        {
            return Math.Abs(int.Parse(date1.Substring(0, 4)) - int.Parse(date2.Substring(0, 4)));
        }
    }
}
