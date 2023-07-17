using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TheOldSwitcheroo
{
    public class Kata
    {
        public static string Vowel2Index(string str)
        {
            //char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            //StringBuilder newStr = new StringBuilder();
            //for(int i = 0; i < str.Length; i++)
            //{
            //    char c = str[i];
            //    if (vowels.Contains(char.ToLower(c)))
            //    {
            //        newStr.Append((i + 1).ToString());
            //    }
            //    else newStr.Append(c);
            //}
            //return newStr.ToString();

            return Regex.Replace(str, "[aeiou]", x => (x.Index + 1).ToString());
        }
    }
}
