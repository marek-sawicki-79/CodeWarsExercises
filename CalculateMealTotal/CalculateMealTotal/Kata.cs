using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateMealTotal
{
    public class Kata
    {
        public static double CalculateTotal(double subtotal, int tax, int tip)
        {
            double result = subtotal + (subtotal * tax / 100) + (subtotal * tip / 100);
            return Math.Round(result, 2);
        }
    }
}
