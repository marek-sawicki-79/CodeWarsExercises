using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToReversedDigitArray
{
    public class Digitizer
    {
        public static long[] Digitize(long n)
        {
            string digitString = n.ToString();
            long[] digits = new long [digitString.Length];
            for (int i = digitString.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < digits.Length; j++)
                {
                    digits[j] = long.Parse(digitString.Substring(i, 1));
                }
            }
            return digits;
        }
    }
}
