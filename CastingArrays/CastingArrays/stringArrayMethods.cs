using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingArrays
{
public class stringArrayMethods
{
  public static double[] ToDoubleArray(string[] stringArray)
  {
            double[] doubleArray = stringArray.Select(s => double.Parse(s, CultureInfo.InvariantCulture)).ToArray();
            return doubleArray;
        }
}
}
