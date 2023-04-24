using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatYearsDogYeras
{
    public class Dinglemouse
    {

        public static int[] humanYearsCatYearsDogYears(int humanYears)
        {
            int dogYears = 0;
            int catYears = 0;
            if(humanYears == 1)
            {
                dogYears = catYears = 15;
            }
            else if (humanYears == 2)
            {
                catYears = dogYears =24;
            }
            else
            {
                dogYears = (humanYears - 2) * 5 + 24;
                catYears = (humanYears - 2) * 4 + 24;
            }
            return new int[] { humanYears, catYears, dogYears };
        }

    }
}
