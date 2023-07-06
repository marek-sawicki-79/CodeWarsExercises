using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfABeach
{
    public class Kata
    {
        public static int SumOfABeach(string s)
        {
            string[] beachParty = { "sand", "water", "fish", "sun" };
            int counter = 0;
            foreach (string party in beachParty)
            {
                int index = -1;
                while ((index = s.ToLower().IndexOf(party, index + 1)) != -1) counter++;
            }
            return counter;
        }
    }
}
