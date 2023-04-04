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
            if ((Char.IsLower(a) && Char.IsLower(b)) || (Char.IsUpper(a) && Char.IsUpper(b)))
            {
                return 1;
            }
            else if ((Char.IsLower(a) && Char.IsUpper(b)) || (Char.IsUpper(a) && Char.IsLower(b)))
            {
                return 0;
            }
            else if (!Char.IsLetter(b) || !Char.IsLetter(a))
            {
                return -1;
            }
            return 0;
        }
    }
}
