﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheDivisors
{
    public class Kata
    {
        public static int[] Divisors(int n)
        {
            List<int> divisors = new List<int>();
            for (int i = 2; i < n; i++)
            {
                if( n % i == 0 )
                divisors.Add(i);
            }
            return divisors.ToArray();
        }
    }
}
