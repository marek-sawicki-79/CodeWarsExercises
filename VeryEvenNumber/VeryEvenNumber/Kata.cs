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
            int sum = number;
            while(number.ToString().Count() > 1)
            {
                char[] nums = number.ToString().ToCharArray();
                foreach(char c in nums)
                {
                    sum += int.Parse(c.ToString());
                }
                number = sum;
            }
            return (number % 2 == 0) ? true : false;
        }
    }
}
