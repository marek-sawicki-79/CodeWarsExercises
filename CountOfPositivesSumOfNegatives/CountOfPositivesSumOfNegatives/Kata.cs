using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfPositivesSumOfNegatives
{
    internal class Kata
    {
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            int positvieCount = input.Count(b => b > 0);
            int negativeSum = input.Where(b => b > 0).Sum();
            int[] result = new int[] { positvieCount, negativeSum };
            return result; 
        }
    }
}
