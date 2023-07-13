using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdderThanTheRest
{
    public class Kata
    {
        public static int OddOne(List<int> list)
        {
            int result = 0;
            foreach(int i in list)
            {
                if (i % 2 != 0)
                {
                    result = list.IndexOf(i);
                    break;
                }
                else result = -1;
            }
            return result;
        }
    }
}
