using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowthOfPopulation
{
    class Arge
    {

        public static int NbYear(int p0, double percent, int aug, int p)
        {
            int result = 0;
            double growth = p0;
            while (growth <= p)
            {
                double increase = growth * percent / 100 + aug;
                growth += increase;
                result++;
            }
            return result;
        }
    }
}
