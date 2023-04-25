using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseIntFromStringChar
{
    public class Kata
    {
        public static int GetAge(string inputString)
        {
            char numberChar = '#';
            foreach (char c in inputString)
            {
                if (Char.IsDigit(c))
                {
                    numberChar = c;
                    break;
                }
                else numberChar = '#';
            }
            return int.Parse(numberChar.ToString());
        }

    }
}
