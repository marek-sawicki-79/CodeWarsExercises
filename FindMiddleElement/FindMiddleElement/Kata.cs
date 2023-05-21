using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMiddleElement
{
    public class Kata
    {
        public static int Gimme(double[] x)
        {
            if ((x[0] > x[1] && x[0] < x[2]) || (x[0] < x[1] && x[0] > x[2])) return 0;
            else if ((x[1] > x[0] && x[1] < x[2]) || (x[1] < x[0] && x[1] > x[2])) return 1;
            else return 2;
        }
    }
}
