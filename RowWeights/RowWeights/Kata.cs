using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowWeights
{
    class Kata
    {
        public static int[] RowWeights(int[] a)
        {
            int[] result = new int[2];
            int sumOdd = 0;
            int sumEven = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if(i % 2 == 0)
                {
                    sumEven += a[i];
                }
                else
                {
                    sumOdd += a[i];
                }
            }
            result[0] = sumEven;
            result[1] = sumOdd;
            return result;
        }
    }
}
