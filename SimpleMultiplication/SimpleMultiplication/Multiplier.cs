using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMultiplication
{
    public class Multiplier
    {
        public static int Multiply(int x)
        {
            var modulo = x % 2;
            if (modulo == 0) return x * 8;
            else return x * 9;
        }
    }
}
