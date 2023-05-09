using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfNumbersAreInOrderAsc
{
    public class Kata
    {
        public static bool IsAscOrder(int[] arr)
        {
            bool isOrder = false;
            for(int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] >= arr[i + 1])
                {
                    isOrder = false;
                    break;
                }
                else isOrder = true;
            }
            return isOrder;
        }
    }
}
