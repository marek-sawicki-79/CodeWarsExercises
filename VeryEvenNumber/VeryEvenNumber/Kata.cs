using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeryEvenNumber
{
    public class Kata
    {
        public static bool IsVeryEvenNumber(int number)
        {
            if (number < 10)
            {
                return number % 2 == 0;
            }
            else
            {
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                return IsVeryEvenNumber(sum);
            }
        }
    }
}
