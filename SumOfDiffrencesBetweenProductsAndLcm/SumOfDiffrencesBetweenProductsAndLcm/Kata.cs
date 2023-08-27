using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDiffrencesBetweenProductsAndLcm
{
    public class Kata
    {
        public static int SumDifferencesBetweenProductsAndLCMs(int[][] pairs)
        {
            int[] results = new int[pairs.Length];
            
            for(int i = 0; i < pairs.Length; i++)
            {
                int[] pair = pairs[i];
                int a = pair[0];
                int b = pair[1];
                int product = a * b;
                
                int gcd = GCD(a, b);
                int lcm = (b != 0) ? (a / gcd) * b : 0;
                
                results[i] = Math.Abs(product - lcm);
            }
            return results.Sum();
        }
        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}

