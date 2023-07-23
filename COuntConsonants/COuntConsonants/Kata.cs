using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COuntConsonants
{
    public class Kata
    {
        public static int ConsonantCount(string str)
        {
            char[] vowels = { 'o', 'i', 'u', 'e', 'a' };
            return str.ToLower().Count(c => !vowels.Contains(c));
        }
    }
}
