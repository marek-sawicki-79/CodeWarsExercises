using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDiff
{
    public class Kata
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            List<int> result = new List<int>();
            foreach( int num in a)
            {
                if(!ArrayContains(b, num))
                {
                    result.Add(num);
                }
            }
            return result.ToArray();
        }

        private static bool ArrayContains(int[] array, int piece)
        {
            foreach( int num in array)
            {
                if(num == piece)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
