using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiAndLo
{
    public static class Kata
    {
        public static string HighAndLow(string numbers)
        {
            int[] numbersToo = new int[(numbers.Length + 1) / 2];
            foreach (char number in numbers)
            {
                if (int.TryParse(number.ToString(), out int result))
                {
                    numbersToo.Append(result);
                }
                else
                {
                    break;
                }
            }
            return "throw towel";
        }
    }
}
