using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalAmountOfPoints
{
    public static class Kata
    {
        public static int TotalPoints(string[] games)
        {
            int sumOfPoints = 0;
            foreach (string game in games)
            {
                int gamePoints;
                int x = game[0];
                int y = game[2];
                if (x > y) gamePoints = 3;
                else if (x == y) gamePoints = 1;
                else gamePoints = 0;
                sumOfPoints += gamePoints;
            }
            return sumOfPoints;
        }
    }
}
