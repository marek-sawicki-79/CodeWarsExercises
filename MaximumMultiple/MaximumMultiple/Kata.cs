using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumMultiple
{
    public class Kata
    {
        public static int MaxMultiply(int divisor, int bound)
        {
            int result = 0;
            for(int i = bound; i >= divisor; i--)
            {
                if (i % divisor == 0)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }
    }
}
