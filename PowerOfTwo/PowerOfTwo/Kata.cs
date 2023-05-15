using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfTwo
{
    public static class Kata
    {
        public static bool PowerOfTwo(int n)
        {
            double result = n;
            while(result >= 2)
            {
                result = result / 2;
            }
            if (result == 1) return true;
            else return false;
        }
    }
}
