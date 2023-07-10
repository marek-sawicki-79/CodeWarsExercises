using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VampireNumbers
{
    static class Kata
    {
        public static bool vampire_test(long x, long y)
        {
            string xString = x.ToString();
            string yString = y.ToString();
            long result = x * y;
            string resultString = result.ToString();
            string bloodSucked = "";
            bool vampire = true;
            foreach (char digit in xString)
            {
                if (resultString.Contains(digit))
                {
                    resultString = resultString.Remove(resultString.IndexOf(digit), 1);
                    bloodSucked = resultString;
                }
                else
                {
                    vampire = false;
                    break;
                }
            }

            foreach (char digit in yString)
            {
                if (bloodSucked.Contains(digit))
                {
                    bloodSucked = bloodSucked.Remove(bloodSucked.IndexOf(digit), 1);
                }
                else
                {
                    vampire = false;
                    break;
                }
            }
            return vampire;
        }
    }
}
