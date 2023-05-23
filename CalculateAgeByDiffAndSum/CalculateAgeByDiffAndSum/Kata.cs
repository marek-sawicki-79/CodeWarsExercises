using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAgeByDiffAndSum
{
    public class Kata
    {
        public static double[] GetAges(int sum, int difference)
        {
            double[] result = new double[2];
            if (sum < 0 || difference < 0) return null;
            else
            {
                result[1] = (sum -difference) / 2.0;
                result[0] = difference + result[1];
            }
            return result;
        }
    }
}
