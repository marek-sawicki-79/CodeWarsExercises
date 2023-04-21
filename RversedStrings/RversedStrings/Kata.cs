using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RversedStrings
{
    public static class Kata
    {
        public static string Solution(string str)
        {
            string reversed = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                    reversed += str[i].ToString();
            }
            return reversed.ToString();
        }
    }
}
