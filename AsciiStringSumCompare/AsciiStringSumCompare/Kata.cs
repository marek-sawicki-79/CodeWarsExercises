using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsciiStringSumCompare
{
    public static class Kata
    {
        public static bool Compare(string s1, string s2)
        {


            //return sum1 == sum2;

            //////if (s1 == null) s1 = "";
            //////if (s2 == null) s2 = "";

            //////s1 = s1.ToUpper();
            //////s2 = s2.ToUpper();

            //////if (s1.Any(c => char.IsDigit(c)) || s2.Any(c => char.IsDigit(c)))
            //////    return true;

            //////int sum1 = 0;
            //////int sum2 = 0;

            //////foreach (char c in s1)
            //////{
            //////    if (char.IsLetter(c))
            //////        sum1 += (int)c;
            //////    else
            //////        return false;
            //////}

            //////foreach (char c in s2)
            //////{
            //////    if (char.IsLetter(c))
            //////        sum2 += (int)c;
            //////    else
            //////        return false;
            //////}

            //////return sum1 == sum2;

            if (s1 == null)
            {
                s1 = "";
            }
            if (s2 == null)
            {
                s2 = "";
            }
            if (!s1.All(o => char.IsLetter(o)))
            {
                s1 = "";
            }
            if (!s2.All(o => char.IsLetter(o)))
            {
                s2 = "";
            }
            return s1.ToUpper().Select(o => (int)o).Sum() == s2.ToUpper().Select(o => (int)o).Sum();
        }
    }
}
