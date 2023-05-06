using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumberDigits
{
    public class Kata
    {
        public static int SumDigits(int number)
        {
            number = Math.Abs(number);
            int sum = 0;
            while(number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}
