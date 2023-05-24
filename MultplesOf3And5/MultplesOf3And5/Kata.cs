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
            List<int> divisibles = new List<int>();
            for(int i = 3; i < value; i++)
            {
               if (i % 3 == 0)
               {
                    divisibles.Add(i);
               }
               else if (i % 5 == 0)
               {
                    if (!divisibles.Contains(i)) divisibles.Add(i);
               }
            }
            int sum = divisibles.Sum();
            return sum;
        }
    }
}
