using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfSequence
{
    public static class Kata
    {
        public static int SequenceSum(int start, int end, int step)
        {
            int sum = 0;
            if (start > end) return 0;
            else
            {
                for (int i = start; i <= end; i += step)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
