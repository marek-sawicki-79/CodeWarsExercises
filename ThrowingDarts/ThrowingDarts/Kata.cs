using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowingDarts
{
    public class Darts
    {
        public static int ScoreThrows(double[] radii)
        {
            int score = 0;
            bool bonus = false;
            for(int i = 0; i < radii.Length; i++)
            {
                if(radii[i] <=10 && radii[i] >= 5)
                {
                    score += 5;
                }
                else if (radii[i] < 5)
                {
                    score += 10;
                }
            }
            foreach (double pitch in radii)
            {
                if (pitch >= 5)
                {
                    bonus = false;
                    break;
                }
                else bonus = true;
            }
            if (bonus == true)
            {
                score += 100;
            }
            return score;
        }
    }
}
