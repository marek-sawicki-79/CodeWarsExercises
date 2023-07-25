using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLettersAndDigits
{
    public static class Kata
    {
        public static int CountLettersAndDigits(string input)
        {
            //return input.Where(char.IsLetterOrDigit).Count();
            return input.Count(x => char.IsLetterOrDigit(x));
        }
    }
}
