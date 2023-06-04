using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplementaryDNA
{
    public class DnaStrand
    {
        public static string MakeComplement(string dna)
        {
            StringBuilder nucleotidePairs = new StringBuilder();
            foreach(char c in dna)
            {
                if (c == 'A')
                {
                    nucleotidePairs.Append('T');
                }
                else if (c == 'C')
                {
                    nucleotidePairs.Append('G');
                }
                else if (c == 'T')
                {
                    nucleotidePairs.Append('A');
                }
                else if (c == 'G')
                {
                    nucleotidePairs.Append('C');
                }
            }
            return nucleotidePairs.ToString();
        }
    }
}
