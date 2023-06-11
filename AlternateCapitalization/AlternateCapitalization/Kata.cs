using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternateCapitalization
{
    public static class Kata
    {
        public static string[] Capitalize(string s)
        {
            string[] result = new string[2];
            char[] sChars1 = s.ToCharArray();
            char[] sChars2 = s.ToCharArray();

            for (int i = 0; i < s.Length; i++)
            {
                if(i % 2 == 0)
                {
                    sChars1[i] = char.ToUpper(s[i]);
                }
                else if(i % 2 != 0)
                {
                    sChars2[i] = char.ToUpper(s[i]);
                }
            }
            result[0] = new string(sChars1);
            result[1] = new string(sChars2);
            return result;
        }
    }
}
