using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountCharsInString
{
    public class Kata
    {
        public static Dictionary<char, int> Count(string str)
        {
            Dictionary<char, int> letters = new Dictionary<char, int>();
            foreach(char c in str)
            {
                if (letters.ContainsKey(c))
                {
                    letters[c]++;
                }
                else
                {
                    letters[c] = 1;
                }
            }
            return letters;
        }
    }
}
