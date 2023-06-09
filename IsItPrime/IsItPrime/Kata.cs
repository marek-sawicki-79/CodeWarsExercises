﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsItPrime
{
    public static class Kata
    {
        public static bool IsPrime(int n)
        {
            if (n < 2) return false;
            int sqrt = (int)Math.Sqrt(n);
            for(int i = 2; i <= sqrt; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
