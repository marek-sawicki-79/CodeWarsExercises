using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    public static class Calculator
    {
        public static double Execute(double num1, char op, double num2)
        {
            //switch (op)
            //{
            //    case '+':
            //        return num1 + num2;
            //    case '-':
            //        return num1 - num2;
            //    case '*':
            //        return num1 * num2;
            //    case '/':
            //        if (num2 == 0)
            //        {
            //            throw new ArgumentException();
            //        }
            //        else return num1 / num2;
            //    default: throw new ArgumentException();
            //}

            return op switch
            {
                '+' => num1 + num2,
                '-' => num1 - num2,
                '*' => num1 * num2,
                '/' => num2 == 0 ? throw new ArgumentException() : num1 / num2,
                _ => throw new ArgumentException()
            };
        }
    }
}
