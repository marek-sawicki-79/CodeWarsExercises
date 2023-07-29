using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsNDivisibleByRest
{
    public static class KataChallenge
    {
        public static bool IsDivisible(int a, int b, int c)
        {
            return (a % b == 0 && a % c == 0) ? true : false;
        }
    }
}
