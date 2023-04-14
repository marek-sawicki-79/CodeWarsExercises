using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerLostWoMap
{
    public class Kata
    {
        public static int[] Maps(int[] x)
        {
            int[] result = new int[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                result[i] = x[i] * 2;
            }
            return result;
        }
    }
}
