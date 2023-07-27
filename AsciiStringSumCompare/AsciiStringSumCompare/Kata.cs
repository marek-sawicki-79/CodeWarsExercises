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
            //char[] s1Chars = s1.ToCharArray();
            //char[] s2Chars = s2.ToCharArray();
            //int sumS1 = 0;
            //int sumS2 = 0;
            //for (int i = 0; i < s1Chars.Length; i++)
            //{
            //    if (!char.IsLetter(s1Chars[i]))
            //    {
            //        sumS1 = 0;
            //    }
            //    else
            //    {
            //        sumS1 += Convert.ToInt32(s1Chars[i]);
            //    }
            //}
            //for (int j = 0; j < s2Chars.Length; j++)
            //{
            //    if (!char.IsLetter(s2Chars[j]))
            //    {
            //        sumS2 = 0;
            //    }
            //    else
            //    {
            //        sumS2 += Convert.ToInt32(s2Chars[j]);
            //    }
            //}
            //return sumS1 == sumS2;
            if (s1 == null) s1 = "";
            if (s2 == null) s2 = "";

            s1 = s1.ToUpper();
            s2 = s2.ToUpper();

            int sum1 = 0;
            int sum2 = 0;

            foreach (char c in s1)
            {
                if (char.IsDigit(c))
                {
                    s1 = "";
                }
                else if(char.IsLetter(c))
                {
                    sum1 += (int)c;
                }
            }
            foreach (char c in s2)
            {
                if (char.IsDigit(c))
                {
                    s2 = "";
                }
                else if (char.IsLetter(c))
                {
                    sum2 += (int)c;
                }
            }

            return sum1 == sum2;
        }
    }
}
