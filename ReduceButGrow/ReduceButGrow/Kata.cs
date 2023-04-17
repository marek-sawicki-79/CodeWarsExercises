using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReduceButGrow
{
    public class Kata
    {
        public static int Grow(int[] x)
        {
            int result = 1;
            foreach (int element in x)
            {
                result = result * element;
            }
            return result;
        }
    }
}
