using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheDigit
{
    public class CountDig
    {

        public static int NbDig(int n, int d)
        {
            int[] result = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
               result[i] = i * i;
            }
            string allTogether = string.Concat(result);
            int count = 0;
            char fromD = (char)(d + '0');
            foreach(char c in allTogether)
            {
                if(c == fromD)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
