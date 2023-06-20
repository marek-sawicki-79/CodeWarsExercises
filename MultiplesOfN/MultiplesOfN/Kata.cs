using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesOfN
{
    public class Kata
    {
        public static double[] Multiples(int m, double n)
        {
            //double[] result = new double[m];
            //for (int i = 0; i < m; i++)
            //{
            //    result[i] = n * (i + 1);
            //}
            //return result;
            return Enumerable.Range(1, m).Select(x => x * n).ToArray();
        }
    }
}
