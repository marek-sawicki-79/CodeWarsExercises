using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    public class Kata
    {
        public static string OddOrEven(int[] array)
        {
            int sum = array.Sum();
            if (array.Length == 1 && array[0] == 0) return "even";
            else return (sum % 2 == 0) ? "even" : "odd";
        }
    }
}
