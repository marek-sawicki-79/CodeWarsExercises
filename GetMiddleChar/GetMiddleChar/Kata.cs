using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMiddleChar
{
    public class Kata
    {
        public static string GetMiddle(string s)
        {
            if(s.Length % 2 == 0)
            {
                char[] chars = new char[2];
                chars[0] = s[s.Length / 2 - 1];
                chars[1] = s[s.Length / 2];
                return new string(chars);
            }
            else
            {
                int middleIndex = (int)Math.Floor(s.Length / 2.0);
                return s[middleIndex].ToString();
            }
        }
    }
}
