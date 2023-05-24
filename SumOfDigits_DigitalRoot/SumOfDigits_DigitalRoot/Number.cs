using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits_DigitalRoot
{
    public class Number
    {
        public static int DigitalRoot(long n)
        {
            List<int> digits = new List<int>();
            while (n > 9)
            {
                string nstr = n.ToString();
                digits.Clear();
                foreach(char c in nstr)
                {
                    int digit = int.Parse(c.ToString());
                    digits.Add(digit);
                }
                n = digits.Sum();
            }
            return (int)n;
        }
    }
}
