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
            if (String.IsNullOrEmpty(s1) || String.IsNullOrEmpty(s2) || (s1 + s2).Any(c => !char.IsLetter(c)))
                return true;
            return s1.ToUpper().Sum(c =>c) == s2.ToUpper().Sum(c => c);
        }
    }
}
