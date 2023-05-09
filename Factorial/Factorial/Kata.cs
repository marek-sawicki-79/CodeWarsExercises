using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    public static class Kata
    {
        public static int Factorial(int n)
        {
            int result = 1;
            if(n == 0) return result;
            else if(n<0 ||n > 12)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    result = result * i;
                }
            }
            return result;

        }
    }
}
