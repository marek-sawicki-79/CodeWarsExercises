using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPaperwork
{
    public class Paper
    {
        public static int Paperwork(int n, int m)
        {
            if (n == 0 || m == 0)
            {
                return 0;
            }
            else return n * m;
        }
    }
}
