using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolToString
{
    internal class Kata
    {
        public static string boolToWord(bool word)
        {
            string result = (!word) ? "No" :  "Yes" ;
            return result;
        }
    }
}
