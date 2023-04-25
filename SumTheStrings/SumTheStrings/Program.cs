using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumTheStrings
{
        public static class Program
        {
            public static string StringsSum(string s1, string s2)
            {
            if (string.IsNullOrEmpty(s1)) s1 = "0";
            if (string.IsNullOrEmpty(s2)) s2 = "0";
            return (int.Parse(s1) + int.Parse(s2)).ToString();
            }
        }
}
