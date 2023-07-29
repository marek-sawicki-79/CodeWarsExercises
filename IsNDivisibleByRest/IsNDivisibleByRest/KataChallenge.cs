using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsNDivisibleByRest
{
    public static class KataChallenge
    {
        public static bool IsDivisible(params int[] numbers)
        {
           if (numbers.Length < 2) return false;
            else
            {
                int firstNum = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (firstNum % numbers[i] != 0) return false;
                }
                return true;
            }
        }
    }
}
