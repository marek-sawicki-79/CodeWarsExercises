using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfSequenceHardEdition
{
    public static class Kata
    {
        public static long SequenceSum(long start, long end, long step)
        {
            long sequenceSum = 0;
            if (start > end) return 0;
            else
            {
                for (long i = start; i <= end; i += step)
                {
                    sequenceSum += i;
                }
                return sequenceSum;
            }
        }
    }
}
