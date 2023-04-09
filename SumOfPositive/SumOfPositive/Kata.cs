using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfPositive
{
    public class Kata
    {
        public static int PositiveSum(int[] arr)
        {
            int positiveSumResult = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    positiveSumResult += arr[i];
                }
            }
            return positiveSumResult;
        }
    }
}
