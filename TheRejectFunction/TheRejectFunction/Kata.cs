using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRejectFunction
{
    public class Kata
    {
        public static int[] Reject(int[] array, Func<int, bool> predicate)
        {
            List<int> result= new List<int>();
            for(int i = -0;  i < array.Length; i++)
            {
                if (!predicate(array[i]))
                {
                    result.Add(array[i]);
                }
            }
            return result.ToArray();
        }
    }
}
