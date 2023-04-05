using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelCalculator
{
    internal class Kata
    {
        public static double FuelPrice(double litres, double pricePerLitre)
        {
            double fuelPrice = 0;
            if (litres > 0 && litres < 2)
            {
                fuelPrice = litres * pricePerLitre;
            }
            else if (litres >= 2 && litres < 4)
            {
                fuelPrice = litres * (pricePerLitre - 0.05);
            }
            else if (litres >= 4 && litres < 6)
            {
                fuelPrice = litres * (pricePerLitre - 0.1);
            }
            else if (litres >= 6 && litres < 8)
            {
                fuelPrice = litres * (pricePerLitre - 0.15);
            }
            else if (litres >= 8 && litres < 10)
            {
                fuelPrice = litres * (pricePerLitre - 0.2);
            }
            else if (litres >= 10)
            {
                fuelPrice = litres * (pricePerLitre - 0.25);
            }
            double result = Math.Round(fuelPrice,2);
            return result;
        }
    }
}
