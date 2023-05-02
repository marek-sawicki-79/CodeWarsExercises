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
            double growth = p0 * percent * 0.01 + aug + p0;
            result++;
            if (growth < p)
            {
                growth = growth + growth * percent * 0.01 + aug * percent * 0.01 + aug;
                result++;
            }

            return result;
        }
    }
}
