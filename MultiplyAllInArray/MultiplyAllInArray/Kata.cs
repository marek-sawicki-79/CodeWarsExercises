using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyAllInArray
{
    public class Kata
    {
        public static Func<int, int[]> MultiplyAll(int[] numbers)
        {
            return factor =>
            {
                int[] result = new int[numbers.Length];
                for (int i = 0; i < numbers.Length; i++)
                {
                    result[i] = numbers[i] * factor;
                }
                return result;
            };

        }
    }
}
