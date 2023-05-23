using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheSheep
{
    public class Kata
    {
        public int lostSheep(int[] friday, int[] saturday, int total)
        {
            return total - friday.Sum() - saturday.Sum();
        }
    }
}
