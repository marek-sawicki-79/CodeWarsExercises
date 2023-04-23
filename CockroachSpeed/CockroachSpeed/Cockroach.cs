using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CockroachSpeed
{
    public class Cockroach
    {
        public static int CockroachSpeed(double x)
        {
            return (int)Math.Floor(x * 1000.0 / 36.0);
        }
    }
}
