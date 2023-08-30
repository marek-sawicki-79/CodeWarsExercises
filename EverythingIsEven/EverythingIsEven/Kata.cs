using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverythingIsEven
{
    public class Kata
    {
        public static int EnsureEven(double number)
        {
            int doop = (int)Math.Round(number);
            return (doop % 2 == 0) ? doop : (doop < 0) ? doop - 1 : doop + 1;
        }
    }
}
