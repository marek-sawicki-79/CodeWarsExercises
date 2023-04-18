using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Kata
    {
        public string Rps(string p1, string p2)
        {
            var O = "rock";
            var X = "scissors";
            var II = "paper";
            if ((p1 == O && p2 == X) || (p1 == X && p2 == II) || (p1 == II && p2 == O))
            {
                return "Player 1 won!";
            }
            else if (p1 == p2)
            {
                return "Draw!";
            }
            else return "Player 2 won!";
        }
    }
}
