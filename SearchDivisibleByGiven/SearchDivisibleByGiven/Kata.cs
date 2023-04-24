using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchDivisibleByGiven
{
    public class Kata
    {
        public static int[] DivisibleBy(int[] numbers, int divisor)
        {
            List<int>Divisibles = new List<int>();
            foreach(int number in numbers)
            {
                if(number % divisor == 0)
                {
                    Divisibles.Add(number);
                }
            }
            return Divisibles.ToArray();
        }
    }
}
