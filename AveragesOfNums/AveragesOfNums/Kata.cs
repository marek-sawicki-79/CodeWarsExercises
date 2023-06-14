using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AveragesOfNums
{
    public class Kata
    {
        public static double[] Averages(int[] numbers)
        {
            if(numbers == null || numbers.Length <= 1) return new double[0];
            else
            {
                double[] result = new double[numbers.Length - 1];
                for (int i = 1; i < numbers.Length; i++)
                {
                    result[i - 1] = (numbers[i] + numbers[i - 1]) / 2.0;
                }
                return result;
            }
        }
    }
}
