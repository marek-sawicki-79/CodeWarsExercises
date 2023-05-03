using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThisTriangle
{
    public class Triangle
    {
        public static bool IsTriangle(int a, int b, int c)
        {
            if(a + b > c || c + a > b || c + b > a)
            {
                return true;
            }
            else  return false;
        }
    }
}
