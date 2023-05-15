using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubedSum
{
    public static class Kata
    {
        public static long SumCubes(int n)
        {
            long cubedSum = 0;
            for (long i = 1; i <= n; i++)
            {
                cubedSum += (long)Math.Pow(i, 3);
            }
            return cubedSum;
        }
    }
}
