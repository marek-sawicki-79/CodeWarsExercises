using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOddCubedNumbers
{
    public class Kata
    {
        public static int CubeOdd(int[] arr)
        {
            int cubedOddSum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                    if (arr[i] % 2 != 0)
                    {
                        cubedOddSum += (int)Math.Pow(arr[i], 3);
                    }
                    else continue;
            }
            return cubedOddSum;
        }
    }
}
