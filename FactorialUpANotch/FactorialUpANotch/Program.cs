using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialUpANotch
{
    public static class Program
    {
        public static int Factorial(int n) => (n == 0) ? 1 : n * Factorial(n - 1);
        //{
        //    if(n == 0) return 1;
        //    else
        //    {
        //        ulong result = 1;
        //        for (int i = 1; i <= n; i++)
        //        {
        //            result *= (ulong)i;
        //        }
        //        return result;
        //    }
        //}
    }
}
