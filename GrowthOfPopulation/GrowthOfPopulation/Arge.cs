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
                growth = growth + (growth * percent / 100) + aug;
                p0 = (int)growth;
                result++;
            }
            return result;
        }
    }
}
