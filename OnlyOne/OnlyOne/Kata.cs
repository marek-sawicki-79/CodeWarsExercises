using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyOne
{
    public class Kata
    {
        public static bool OnlyOne(params bool[] flags)
        {
            int trueCount = 0;
            foreach (bool flag in flags)
            {
                if (flag)
                {
                trueCount++;
                }
            }
            return (trueCount == 1);
        }
    }
}
