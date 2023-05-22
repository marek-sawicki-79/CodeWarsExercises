using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowingPlant
{
    public class Kata
    {
        public int GrowingPlant(int UpSpeed, int DownSpeed, int DesiredHeight)
        {
            int daysCount = 0;

            for (int i =0; i <= DesiredHeight; i += UpSpeed)
            {
                if(i == 0)
                {
                    daysCount++;
                }
                else
                {
                    i -= UpSpeed;
                    daysCount++;
                }
            }
            return daysCount;
        }
    }
}
