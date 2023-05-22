using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitize
{
    public static class Kata
    {
        public static int[] digitize(int n)
        {
            string number = n.ToString();
            int[] digits = new int[number.Length];
            for(int i = 0; i < number.Length; i++)
            {
                digits[i] = int.Parse(number[i].ToString());
            }
            return digits;
        }
    }
}
