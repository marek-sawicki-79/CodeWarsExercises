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
            int max = numbers.Max();
            int min = numbers.Min();
            return numbers.Sum(x => (x != max && x != min ? x : 0));
        }
    }
}
