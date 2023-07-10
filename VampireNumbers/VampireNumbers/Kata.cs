using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VampireNumbers
{
    static class Kata
    {
        public static bool vampire_test(long x, long y)
        {
            string xString = x.ToString();
            string yString = y.ToString();
            long result = x * y;
            string resultString = result.ToString();
            return xString.All(c => resultString.Contains(c)) && yString.All(c => resultString.Contains(c));
        }
    }
}
