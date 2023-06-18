using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingNumber
{
    class Kata
    {
        public static string JumpingNumber(int number)
        {
            string digits = number.ToString();
            string result = "";
            for(int i = 0; i < digits.Length - 1; i++)
            {
                if (Math.Abs(digits[i + 1] - digits[i]) != 1)
                {
                    result = "Not!!";
                    break;
                }
            }
            if (result != "Not!!") result = "Jumping!!";
            return result;
        }
    }
}
