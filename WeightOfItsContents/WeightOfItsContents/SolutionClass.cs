using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightOfItsContents
{
    public static class SolutionClass
    {
        public static int ContentWeight(int bottleWeight, string scaleString)
        {
            int result = 0;
            string[] splitedScale = scaleString.Split(' ');
            int scale = int.Parse(splitedScale[0]);
            int unit = bottleWeight / (scale + 1);
            result = (splitedScale[2] == "larger") ? unit * scale : unit;
            return result;
        }
    }
}
