using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindStrayNumber
{
    class Solution
    {
        public static int Stray(int[] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (numbers[i] != numbers[i + 1] && numbers[i] != numbers[i + 2]) result = numbers[i];
                else if (numbers[i + 1] != numbers[i] && numbers[i + 1] != numbers[i + 2]) result = numbers[i + 1];
                else if (numbers[i + 2] != numbers[i + 1] && numbers[i + 2] != numbers[i]) result = numbers[i + 2];
            }
            return result;
        }
    }
}
