using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelCount
{
    public static class Kata
    {
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;

            var vowels = new HashSet<char> { 'a', 'e', 'u', 'i', 'o' };
            for (int i = 0; i < str.Count(); i++)
            {
                if (vowels.Contains(str[i]))
                {
                    vowelCount++;
                }
            }

            return vowelCount;
        }
    }
}
