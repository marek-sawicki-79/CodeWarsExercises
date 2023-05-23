using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsibleDrinking
{
    public class Drinkin
    {
        public string hydrate(string drinkString)
        {
            int sum = 0;
            foreach (char c in drinkString)
            {
                if (int.TryParse(c.ToString(), out int drinks))
                {
                    sum += drinks;
                }
            }
            return (sum == 1) ? $"{sum} glass of water" : $"{sum} glasses of water";
        }
    }
}
