using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingArrays
{
public class stringArrayMethods
{
  public static double[] ToDoubleArray(string[] stringArray)
  {
            double[] casted = new double[stringArray.Length];
            for (int i = 0; i < stringArray.Length; i++)
            {
                casted[i] = double.Parse(stringArray[i]);
            }
            return casted;
        }
}
}
