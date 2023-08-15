using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAreaInSquare
{
    public class Convert
    {
        public static double SquareAreaToCircle(double size)
        {
            double radius = Math.Sqrt(size) / 2;
            return Math.Round((Math.PI * Math.Pow(radius, 2)), 8);
        }
    }
}
