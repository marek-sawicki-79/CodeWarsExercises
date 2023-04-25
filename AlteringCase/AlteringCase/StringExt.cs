using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlteringCase
{
    public static class StringExt
    {
        public static string ToAlternatingCase(this string s)
        {
            string result = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    result += char.ToLower(s[i]);
                }
                else if (char.IsLower(s[i]))
                {
                    result += char.ToUpper(s[i]);
                }
                else result += s[i];
            }
            return result;
        }
    }
}
