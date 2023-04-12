using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    public class SolutionClass
    {
        public static string EvenOrOdd(int number)
        {
            int modulo = number % 2;
            string result = (modulo != 0) ? "Odd" : "Even";
            return result;
        }
    }
}
