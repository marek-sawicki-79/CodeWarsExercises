using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterTheNumber
{
    public class Kata
    {
        public static int FilterString(string s)
        {
            //string result = "";
            //for(int i = 0; i < s.Length; i++)
            //{
            //    if (char.IsDigit(s[i]))
            //    {
            //        result += s[i];
            //    }
            //}
            //return int.Parse(result);
            return int.Parse(new String(s.Where(char.IsDigit).ToArray()));
        }
    }
}
