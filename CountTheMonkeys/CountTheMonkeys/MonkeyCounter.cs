using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheMonkeys
{
    public static class MonkeyCounter
    {
        public static int[] MonkeyCount(int n)
        {
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = i + 1;
            }
            return result;
        }
    }
}
