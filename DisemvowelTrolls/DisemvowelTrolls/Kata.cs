using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisemvowelTrolls
{
    public class Kata
    {
        public static string Disemvowel(string str)
        {
            List<string> vowels = new List<string> { "a", "A", "e", "E", "i", "I", "o", "O", "u", "U" };
            char[] entryString = str.ToCharArray();
            string result = new string(str.Where(c => !vowels.Any(r => r.Contains(c))).ToArray());
            return result;
        }
    }
}
