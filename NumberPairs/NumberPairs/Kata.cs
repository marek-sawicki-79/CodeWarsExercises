using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPairs
{
    public class Kata
    {
        public static int[] getLargerNumbers(int[] a, int[] b)
        {
            //int[] result = new int[a.Length];
            //for (int i = 0; i < a.Length; i++)
            //{
            //    _ = (a[i] > b[i]) ? result[i] = a[i] : result[i] = b[i];
            //}
            //return result;
            return a.Zip(b, (x, y) => Math.Max(x, y)).ToArray();
        }
    }
}
