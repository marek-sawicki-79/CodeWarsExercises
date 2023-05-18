using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldingUrWayToMoon
{
    public class Kata
    {
        public static int? FoldTo(double distance)
        {
            if (distance < 0) return null;
            else
            {
                double thickness = 0.0001;
                int folds = 0;
                while(thickness < distance)
                {
                    folds++;
                    thickness = thickness * 2;
                }
                return folds;
            }
        }
    }
}
