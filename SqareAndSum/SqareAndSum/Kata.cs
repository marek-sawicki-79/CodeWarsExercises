using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqareAndSum
{
    public class Kata
    {
        public static int SquareSum(int[] numbers)
        {
            int sqrtSum = 0;
            foreach(int number in numbers)
            {
                sqrtSum = sqrtSum + number * number;
            }
            return sqrtSum;
        }
    }
}
