using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConquer
{
    public class Kata
    {
        public static int DivCon(Object[] objArray)
        {
            int result = 0;
            foreach(var number in objArray)
            {
                if (number is int)
                {
                    result += (int)number;
                }
                else
                    result -= int.Parse(number.ToString());
            }
            return result;
        }
    }
}
