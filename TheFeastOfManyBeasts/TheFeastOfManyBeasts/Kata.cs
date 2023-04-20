using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFeastOfManyBeasts
{
    public class Kata
    {
        public static bool Feast(string beast, string dish)
        {
            string beastFirst = beast.Substring(0, 1);
            string beastLast = beast.Substring(beast.Length - 1, 1);
            string dishFirst = dish.Substring(0, 1);
            string dishLast = dish.Substring(dish.Length - 1, 1);
            return beastFirst == dishFirst && beastLast == dishLast;
        }
    }
}
