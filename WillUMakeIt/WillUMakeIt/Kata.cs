using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillUMakeIt
{
    public static class Kata
    {
        public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft)
        {
            return (distanceToPump <= mpg * fuelLeft) ? true : false;
        }
    }
}
