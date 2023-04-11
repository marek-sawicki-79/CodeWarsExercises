using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepHydrated
{
    public class Kata
    {
        public static int Litres(double time)
        {
            double perHour = 0.5;
            int water = (int)Math.Truncate(time * perHour);
            return water;
        }
    }
}
