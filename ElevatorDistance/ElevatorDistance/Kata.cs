using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorDistance
{
    public static class Kata
    {
        public static int ElevatorDistance(int[] array)
        {
            int result = 0;
            for (int i = 1; i < array.Length; i++)
            {
               result = result + Math.Abs(array[i] - array[i - 1]);
            }
            return result;
        }
    }
}
