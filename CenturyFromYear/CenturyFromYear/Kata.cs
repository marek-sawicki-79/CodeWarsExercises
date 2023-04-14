using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturyFromYear
{
    public class Kata
    {
        public static int СenturyFromYear(int year)
        {
            double century = (year / 100);
            int result = (int)Math.Ceiling(century);
            return result;
        }
    }
}
