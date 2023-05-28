using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDivisibleNumbers
{
    public class Kata
    {
        public static long DivisibleCount(long x, long y, long k)
        {
            //long divisibles = 0;
            //for(long i = x; i<=y; i++)
            //{
            //    if(i % k == 0)
            //    {
            //        divisibles++;
            //    }
            //}
            //return divisibles;

            long startNum = ((x + k - 1) / k) * k;
            long endNum = (y / k) * k;
            long divisibles = ((endNum - startNum) / k) + 1;
            
            return divisibles;
        }
    }
}
