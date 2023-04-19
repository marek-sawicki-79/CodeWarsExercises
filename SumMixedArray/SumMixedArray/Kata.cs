using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMixedArray
{
    public class Kata
    {
        public static int SumMix(object[] x)
        {
            int sum = 0;
            foreach (object obj in x)
            {
                string str = obj.ToString();
                int number = int.Parse((string)str);
                sum += number;
            }
            return sum;
        }
    }
}
