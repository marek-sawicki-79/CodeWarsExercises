using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthAnd2V
{
    public class Kata
    {
        public static object[] Alternate(int n, object firstValue, object secondValue)
        {
            //object[] result = new object[n];
            //for (int i = 0; i < n; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        result[i] = firstValue;
            //    }
            //        else result[i] = secondValue;
            //}
            //return result;

            return Enumerable.Range(0, n).Select(x => x % 2 == 1 ? secondValue : firstValue).ToArray();
        }
    }
}
