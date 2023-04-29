using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiAndLo
{
    public static class Kata
    {
        public static string HighAndLow(string numbers)
        {
            string[] splittedNumbers = numbers.Split(' ');
            int[] numbersToo = new int[splittedNumbers.Length];
            for(int i =0; i<numbersToo.Length; i++)
            {
                numbersToo[i] = int.Parse(splittedNumbers[i]);
            }

            return $"{numbersToo.Max()} {numbersToo.Min()}";
        }
    }
}
