using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfACircle
{
    public static class Kata
    {
        public static double CalculateAreaOfCircle(string radius)
        {
            double rad = double.Parse(radius);
            double pi = 3.14;
            if(rad  <= 0.0)
            {
                throw new ArgumentException();
            }
            else
            {
                return rad * rad * pi;
            }
        }
    }
}
