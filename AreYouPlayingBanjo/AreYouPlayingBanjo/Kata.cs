using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreYouPlayingBanjo
{
    public class Kata
    {
        public static string AreYouPlayingBanjo(string name)
        {
           return (name.ToLower().StartsWith('r')) ? $"{name} plays banjo" : $"{name} does not play banjo";
        }
    }
}
