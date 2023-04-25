using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace PowersOf2
{
    public class Kata
    {
        public static BigInteger[] PowersOfTwo(int n)
        {
            BigInteger[] result = new BigInteger[n + 1];
            for (int i = 0; i <= n; i++)
            {
                result[i] =BigInteger.Pow(2, i);
            }

            return result;
        }

    }
}
