using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoArithmeticFromStringCommand
{
    public class Kata
    {
        public static double Arithmetic(double a, double b, string op)
        {
            return (op == "add") ? a + b : (op == "subtract") ? a - b : (op == "multiply")
                ? a * b : (op == "divide") ? a / b : 404;
        }
    }
}
