using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRrepeat
{
    public static class Program
    {
        public static string RepeatStr(int n, string s)
        {
            string result = "";
            for (int i = 1; i <= n; i++)
            {
                result += s;
            }
            return result;
        }
    }
}
