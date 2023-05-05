using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDivisors
{
    public class Kata
    {
        public static int Divisors(int n)
        {
            List<int> divisor = new List<int>();
            for(int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    divisor.Add(i);
                }
            }
            int result = divisor.Count;
            return result;
        }
    }
}
