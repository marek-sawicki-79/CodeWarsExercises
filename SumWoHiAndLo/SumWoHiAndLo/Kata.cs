using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumWoHiAndLo
{
    public class Kata
    {
        public static int Sum(int[] numbers)
        {
            int max = 0;
            int min = 0;
            try
            {
                max = numbers.Max();
                min = numbers.Min();
            }
            catch (InvalidOperationException)
            {
                max = min = 0;
            }
            return numbers.Sum(x => (x != max && x != min ? x : 0));
        }
    }
}
