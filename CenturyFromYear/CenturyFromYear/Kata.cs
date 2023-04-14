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
            int century = (int)Math.Ceiling((double)year / 100);
            return century;
        }
    }
}
