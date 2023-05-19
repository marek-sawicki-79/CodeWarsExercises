using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseNumbersSum
{
    public class Kata
    {
        public int HouseNumbersSum(int[] inputArray)
        {
            int houseSum = 0;
            foreach(int number in inputArray)
            {
                if (number != 0) houseSum += number;
                else break;
            }
            return houseSum;
        }
    }
}
