using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowGoodAreYouReally
{
    public class Kata
    {
        public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        {
            double average = ClassPoints.Average();
            return (average > YourPoints) ? false : true;
        }
    }
}
