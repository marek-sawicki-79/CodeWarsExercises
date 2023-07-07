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
            double rad;
            if (double.TryParse(radius, out rad) && rad > 0)
            {
                double area = Math.PI * rad * rad;
                return Math.Round(area, 2);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
