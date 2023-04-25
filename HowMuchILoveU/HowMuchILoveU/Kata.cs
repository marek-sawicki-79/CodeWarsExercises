using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowMuchILoveU
{
    public class Kata
    {
        public static string HowMuchILoveYou(int nb_petals)
        {
            int result = nb_petals % 6;
            switch (result)
            {
                case 0: return "not at all";
                case 1: return "I love you";
                case 2: return "a little";
                case 3: return "a lot";
                case 4: return "passionately";
                case 5: return "madly";
                default: return "dindunuffin";
            }
        }
    }
}
