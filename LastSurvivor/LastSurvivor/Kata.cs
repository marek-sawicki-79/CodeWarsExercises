using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastSurvivor
{
    public static class Kata
    {
        public static string LastSurvivor(string letters, int[] coords)
        {
            List<char> chars = new List<char>(letters);
            for (int i = 0; i < coords.Length; i++)
            {
                int index = coords[i];
                if(index >= 0 && index < chars.Count)
                {
                    chars.RemoveAt(index);
                }
            }
            return new String(chars.ToArray());
        }
    }
}
