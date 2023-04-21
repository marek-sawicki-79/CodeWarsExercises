using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAverage
{
    class AverageSolution
    {
        public static double FindAverage(double[] array)
        {
            if (array.Length == 0) return 0;
            else
            {
                double sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                return sum / array.Length;
            }
            //return (array.Length == 0) ? 0 : array.Average();
        }
    }
}
