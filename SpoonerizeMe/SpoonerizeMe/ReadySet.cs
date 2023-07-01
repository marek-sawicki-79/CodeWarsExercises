using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpoonerizeMe
{
    public static class ReadySet
    {
        public static string Spoonerize(string str)
        {
            string[] strs = str.Split(' ');
            char[] str1 = strs[0].ToCharArray();
            char[] str2 = strs[1].ToCharArray();
            char firstStr1 = str1[0];
            char firstStr2 = str2[0];
            str1[0] = firstStr2;
            str2[0] = firstStr1;
            strs[0] = new string(str1);
            strs[1] = new string(str2);
            return string.Join(" ", strs);
        }
    }
}
