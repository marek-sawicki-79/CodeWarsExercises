using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqareRootOrNot
{
    public class Kata
    {
        public static int[] SquareOrSquareRoot(int[] array)
        {
            int[] result = new int[array.Length];
            double sqrt = 0.0;
            for (int i = 0; i < array.Length; i++)
            {
                sqrt = Math.Sqrt(array[i]);
                if (sqrt == (int)sqrt) result[i] = (int)sqrt;
                else result[i] = (int)Math.Pow(array[i],2);
            }
            return result;
        }
    }
}
