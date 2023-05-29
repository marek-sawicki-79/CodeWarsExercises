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
            if (start > end && step > 0 || start < end && step < 0)
                return 0;

            long sequenceSum = 0;
            if (step > 0)
            {
                for (long i = start; i <= end; i += step)
                {
                    sequenceSum += i;
                }
            }
            else
            {
                for (long i = start; i >= end; i += step)
                {
                    sequenceSum += i;
                }
            }

            return sequenceSum;
        }
    }
}
