using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumFromZeroToN
{
    public class SequenceSum
    {
        public static string ShowSequence(int n)
        {
            if (n < 0) return $"{n}<0";
            else if (n == 0) return "0=0";
            else
            {
                string result = "0";
                int sum = 0;
                for(int i = 1; i <= n; i++)
                {
                    sum += i;
                    result.Concat($"+{i}");
                }
                return result + $" = {sum}";
            }
        }
    }
}
