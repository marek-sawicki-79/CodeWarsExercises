using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeDeadfishSwim
{
    public class Deadfish
    {
        public static int[] Parse(string data)
        {
            List<int> parser = new List<int>();
            int fish = 0;
            foreach(char c in data)
            {
                if(c == 'i')
                {
                    fish++;
                }
                else if(c == 'd')
                {
                    fish--;
                }
                else if(c == 's')
                {
                    fish *= fish;
                }
                else if (c == 'o')
                {
                    parser.Add(fish);
                }
            }
            return parser.ToArray();
        }
    }
}
