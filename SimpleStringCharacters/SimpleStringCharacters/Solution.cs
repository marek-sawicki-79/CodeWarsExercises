using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStringCharacters
{
    public class Solution
    {
        public static int[] solve(String s)
        {
            int upperCase = s.Count(c => char.IsLetter(c) && char.IsUpper(c));
            int lowerCase = s.Count(c => char.IsLetter(c) && char.IsLower(c));
            int digits = s.Count(c => char.IsDigit(c));
            int specialChars = s.Count(c => !char.IsDigit(c) && !char.IsLetter(c));
            return new int[] { upperCase, lowerCase, digits, specialChars };
        }
    }
}
