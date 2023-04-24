using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check4Factor
{
    public class Kata
    {
        public static bool CheckForFactor(int num, int factor)
        {
            return (num % factor == 0);
        }
    }
}
