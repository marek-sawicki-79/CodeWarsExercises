using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheSlope
{
    internal class Slope
    {
        public String slope(int[] points)
        {
            var licznik = points[3] - points[1];
            var mianownik = points[2] - points[0];
            string result;

            if (mianownik == 0)
            {
                result = "undefined";
            }
            else
                result = (licznik/mianownik).ToString();

            return result;
        }
    }
}
