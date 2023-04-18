using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToArray
{
    public class Solution
    {
        public static string[] StringToArray(string str)
        {
            string[] strArray = str.Split(' ');
            return strArray;
        }
    }
}
