using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumber
{
    class Kata
    {
        public static string SpecialNumber(int number)
        {
            int[] compare = { 0, 1, 2, 3, 4, 5 };
            string num = number.ToString();
            return (num.All(c => compare.Contains(c))) ? "Special!!" : "NOT!!";
        }
    }
}
