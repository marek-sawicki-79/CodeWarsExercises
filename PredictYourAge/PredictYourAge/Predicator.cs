using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredictYourAge
{
    public class Predicter
    {
        public static int PredictAge(int a, int b, int c, int d, int e, int f, int g, int h)
        {
            int sumOfSqares =  (a * a) + (b * b) + (c * c) + (d * d) + (e * e) + (f * f) + (g * g) + (h * h);
            double result = Math.Sqrt(sumOfSqares) / 2;
            return (int)Math.Floor(result);
        }
    }
}
