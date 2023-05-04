using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoOfPplInBus
{
    public class Kata
    {
        public static int Number(List<int[]> peopleListInOut)
        {
            int peopleLeft = 0;
            foreach (int[] passengersExchangeOnStop in peopleListInOut)
            {
                peopleLeft = peopleLeft + passengersExchangeOnStop[0] - passengersExchangeOnStop[1];
            }
            return peopleLeft;
        }
    }
}
