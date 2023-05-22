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
            int currentHeight = 0;
            while(currentHeight < DesiredHeight)
            {
                currentHeight += UpSpeed;
                daysCount++;
                if (currentHeight >= DesiredHeight)
                {
                    break;
                }
                currentHeight -= DownSpeed;
            }
            return daysCount;
        }
    }
}
