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
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
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
            int sum = numbers.DefaultIfEmpty(0).Where(x => x != max && x != min).Sum();
            return sum;
        }
    }
}
