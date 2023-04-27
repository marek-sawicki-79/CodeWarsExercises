using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAbout
{
    public class Kata
    {
        public static string PeopleWithAgeDrink(int old)
        {
            return (old < 14) ? "drink toddy" : (old < 18) ? "drink coke" : (old < 21) ? "drink beer" : "drink whisky";
        }
    }
}
