using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMathematicalOparatios
{
    public static class Program
    {
        public static double basicOp(char o, double v1, double v2)
        {
            return (o == '+') ? v1 + v2 : (o == '-') ? v1 - v2 : (o == '*') ? v1 * v2 : (o == '/') ? v1 / v2 : 0;
        }
    }
}
