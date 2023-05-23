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
            if (sum < 0 || difference < 0)
                return null;

            double[] result = new double[2];
            result[1] = (sum - difference) / 2.0;
            result[0] = difference + result[1];

            if (result[0] < 0 || result[1] < 0)
                return null;

            return result;
        }
    }
}
