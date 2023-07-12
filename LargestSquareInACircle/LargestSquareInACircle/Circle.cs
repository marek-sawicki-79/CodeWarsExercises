using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestSquareInACircle
{
    public class Circle
    {
        public double AreaLargestSquare(int r)
        {
            double squareSide = 2 * r / Math.Sqrt(2);
            return Math.Round((squareSide * squareSide), 0);
        }
    }
}
