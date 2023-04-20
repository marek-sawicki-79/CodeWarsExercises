using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationOnVacation
{
    public class RentalCar
    {

        public static int RentalCarCost(int d)
        {
            return (d >= 7) ? (40 * d) - 50 : (d >= 3) ? (40 * d) - 20 : 40 * d;
        }
    }
}
