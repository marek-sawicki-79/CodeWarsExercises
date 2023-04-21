using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertValues
{
    public static class ArraysInversion
    {
        public static int[] InvertValues(int[] input)
        {
            int[] inverted = new int[input.Length];
            for(int i = 0; i < input.Length; i++)
            {
                inverted[i] = -input[i];
            }
            return inverted;
        }
    }
}
