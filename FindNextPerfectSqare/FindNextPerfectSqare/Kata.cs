using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNextPerfectSqare
{
    public class Kata
    {
        public static long FindNextSquare(long num)
        {
            double check = Math.Sqrt(num);
            if (check != (long)check)
            {
                return -1;
            }
            else
            {
                long nextNumber = num + 1;
                double newCheck = Math.Sqrt(nextNumber);
                while (newCheck != (long)newCheck)
                {
                    nextNumber++;
                    newCheck = Math.Sqrt(nextNumber);
                }
                return nextNumber;
            }
        }
    }
}
