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
            string halfResult = new string(str.ToLower().Where(Char.IsLetter).ToArray());
            return halfResult.ToCharArray().Count(c => !vowels.Contains(c));
        }
    }
}
