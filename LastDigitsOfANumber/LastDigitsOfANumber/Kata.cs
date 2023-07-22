using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastDigitsOfANumber
{
    public static class Kata
    {
        public static int[] LastDigit(long n, int d)
        {
            List<int> result = new List<int>();
            if (d <= 0)
            {
                return result.ToArray();
            }
            else
            {
                string nToString = n.ToString();
                if (d > nToString.Length)
                {
                    return (n.ToString()).Select(x => int.Parse(x.ToString())).ToArray();
                }
                else
                {
                    result = nToString.Substring(nToString.Length - d).Select(x => int.Parse(x.ToString())).ToList();
                }
            }
            return result.ToArray();
        }
    }
}
