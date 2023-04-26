using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsBetween
{
    public class Kata
    {
        public static int[] Between(int a, int b)
        {
            int[] result = new int[b - a + 1];
            result[0] = a;
            for (int i = 1; i < result.Length; i++)
            {
                result[i] = result[i - 1] + 1;
            }
            return result;
        }
    }
}
