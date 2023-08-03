using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsMyGolfScore
{
    public static class Kata
    {
        public static int GolfScoreCalculator(string par, string score)
        {
            //int finalScore = 0;
            //for (int i = 0; i < par.Length; i++)
            //{
            //    finalScore += ( score[i] - par[i]);
            //}
            //return finalScore;

            return score.Select(x => Convert.ToInt32(x)).Sum() - par.Select(y => Convert.ToInt32(y)).Sum();
        }
    }
}
