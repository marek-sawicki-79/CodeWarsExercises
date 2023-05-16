using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incrementer
{
    public static class Kata
    {
        public static int[] Incrementer(int[] numbers)
        {
            int[] incrementedNumbers = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                int sum = numbers[i] + i + 1;
                if (sum < 10) incrementedNumbers[i] = sum;
                else incrementedNumbers[i] = sum % 10;
            }
            return incrementedNumbers;
        }
    }
}
