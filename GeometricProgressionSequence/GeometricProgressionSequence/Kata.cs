using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProgressionSequence
{
    public class Kata
    {
        public static string GeometricSequenceElements(int a, int r, int n)
        {
            //int[] geo = new int[n];
            //for (int i = 0;  i < n; i++)
            //{
            //    geo[i] = a * (int)Math.Pow(r, i);
            //}
            //return string.Join(", ", geo);

            return string.Join(", ", Enumerable.Range(0, n).Select(i => Math.Pow(r, i) * a));
        }
    }
}
