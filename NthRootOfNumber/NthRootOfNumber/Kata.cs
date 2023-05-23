using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthRootOfNumber
{
    public class Kata
    {
        public static double FindRoot(double x, int n)
        {
            return Math.Pow(x, 1.0 / n);
        }
    }
}
