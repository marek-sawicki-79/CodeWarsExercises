using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongNumber
{
    class Kata
    {
        private static int Factorial(int n) => n == 0 ? 1 : n * Factorial(n - 1);
        public static string StrongNumber(int number)
        {
            //string numbers = number.ToString();
            //int factorialsSum = 0;
            //foreach(char digit in numbers)
            //{
            //    int cyfra = int.Parse(digit.ToString());
            //    int factorial = 1;
            //    for(int i = 1; i <= cyfra; i++)
            //    {
            //        factorial *= i;
            //    }
            //    factorialsSum += factorial;
            //}
            //return (number == factorialsSum) ? "STRONG!!!!" : "Not Strong !!";
            return number == number.ToString().Sum(n => Factorial(int.Parse(n.ToString())))
            ? "STRONG!!!!" : "Not Strong !!";
        }
    }
}
