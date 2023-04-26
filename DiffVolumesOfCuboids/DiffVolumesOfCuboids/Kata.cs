using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffVolumesOfCuboids
{
    public class Kata
    {
        public static int FindDifference(int[] a, int[] b)
        {
            int result = ((a[0] * a[1] * a[2]) - (b[0] * b[1] * b[2]));
            return (int)Math.Sqrt(result * result);
        }
    }
}
