using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleChar
{
    public class Kata
    {
        public static string DoubleChar(string s)
        {
            char[] chars = s.ToCharArray();
            char[] doubleChar = new char[chars.Length * 2];
            for (int i = 0; i < chars.Length; i++)
            {
                doubleChar[2 * i] = chars[i];
                doubleChar[2 * i + 1] = chars[i];
            }
            return new string(doubleChar);
        }
    }
}
