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
                 incrementedNumbers[i] = (numbers[i] + i + 1) % 10;
            }
            return incrementedNumbers;
        }
    }
}
