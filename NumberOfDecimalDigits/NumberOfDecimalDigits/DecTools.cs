using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfDecimalDigits
{
    public class DecTools
    {
        public static int Digits(ulong n)
        {
            int digitsCount = 0;
            string nString = n.ToString();
            foreach(char c in nString)
            {
                if(char.IsDigit(c)) digitsCount++;
            }
            return digitsCount;
        }
    }
}
