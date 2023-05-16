using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNthDigit
{
    public class Kata
    {
        public static int FindDigit(int num, int nth)
        {
            char[] numStrings = num.ToString().ToCharArray();
            if (nth <= 0) return -1;
            else if (nth > numStrings.Length) return 0;
            else if (!char.IsDigit(numStrings[numStrings.Length - nth])) return 0;
            else return int.Parse(numStrings[numStrings.Length - nth].ToString());
        }
    }
}
