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
            //var aIsLetter = Regex.IsMatch(a.ToString(), @"^[a-zA-Z]+$");
            //var bIsLetter = Regex.IsMatch(b.ToString(), @"^[a-zA-Z]+$");
            var aIsLetter = Char.IsLetter(a);
            var bIsLetter = Char.IsLetter(b);
            if ((aToLower == true && bToLower == true) || (aToUpper == true && bToUpper == true))
            {
                return 1;
            }
            else if ((aToLower == true || bToUpper == true) || (aToUpper == true && bToLower == true))
            {
                return 0;
            }
            else if (!bIsLetter || !bIsLetter)
            {
                return -1;
            }
            return 0;
        }
    }
}
