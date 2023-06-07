using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing1_2_3
{
    public class LineNumbering
    {
        public static List<string> Number(List<string> lines)
        {
            for (int i = 0; i < lines.Count; i++)
            {
                lines[i] = $"{i + 1}: {lines[i]}";
            }
            return lines;
        }
    }
}
