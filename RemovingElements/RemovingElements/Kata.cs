using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemovingElements
{
    public static class Kata
    {
        public static object[] RemoveEveryOther(object[] arr)
        {
            var length = Math.Ceiling(arr.Length / 2.0);
            var result = new object[(int)length];
            var index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result[index] = arr[i];
                    index++;
                }
            }

            return result;
        }
    }
}
