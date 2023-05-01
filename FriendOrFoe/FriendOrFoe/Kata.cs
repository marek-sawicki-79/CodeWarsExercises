using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendOrFoe
{
    public static class Kata
    {
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            foreach (string name in names)
            {
                if (name.Count() == 4)
                {
                    yield return name;
                }
            }
        }
    }
}
