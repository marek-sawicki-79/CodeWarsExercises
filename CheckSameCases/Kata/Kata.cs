using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kata
{
    public class Kata
    {
        public static int SameCase(char a, char b)
        {
            var aToLower = Regex.IsMatch(a.ToString(), @"^[a-z]+$");
            var bToLower = Regex.IsMatch(b.ToString(), @"^[a-z]+$");
            var aToUpper = Regex.IsMatch(a.ToString(), @"^[A-Z]+$");
            var bToUpper = Regex.IsMatch(b.ToString(), @"^[A-Z]+$");
            //if (Regex.IsMatch(a.ToString(), @"^[a-z]+$"))
            return 0;
        }
    }
}
