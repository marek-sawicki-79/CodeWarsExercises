using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferenceOfSquares
{
    public class Kata
    {
        public static int DifferenceOfSquares(int n)
        {
            int sum = 0;
            int sumOfSquares = 0;
            for(int i = 1; i <= n; i++)
            {
                sum += i;
                sumOfSquares += i * i;
            }
            return sum * sum - sumOfSquares;
        }
    }
}
