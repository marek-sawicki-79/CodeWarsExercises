using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AreaOfACircle
{
    public static class Kata
    {
        public static double CalculateAreaOfCircle(string radius)
        {
            return double.TryParse(radius, NumberStyles.Float, CultureInfo.InvariantCulture, out var r) && r > 0
               ? Math.Round(r * r * Math.PI, 2)
               : throw new ArgumentException();
        }
    }
}
