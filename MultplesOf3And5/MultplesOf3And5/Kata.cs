using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultplesOf3And5
{
    public static class Kata
    {
        public static int Solution(int value)
        {
            int sum = 0;
            for(int i = 3; i < value; i++)
            {
                if(i % 3 == 0 && i % 5 ==0)
                {
                    sum += i;
                }
                else if (i % 3 == 0 && i % 5 != 0)
                {
                    sum += i;
                }
                else if (i % 3 != 0 && i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
