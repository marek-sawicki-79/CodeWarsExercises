using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedSequence
{
    public static class Kata
    {
        public static int[] ReverseSeq(int n)
        {
            int[] result = new int[n];
            for (int i = n - 1; i >= 0; i--)
            {
                result[i] = n - i;
            }
            return result;
        }
    }
}
