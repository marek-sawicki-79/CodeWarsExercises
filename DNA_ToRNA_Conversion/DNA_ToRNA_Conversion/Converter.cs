using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNA_ToRNA_Conversion
{
    public class Converter
    {
        public string dnaToRna(string dna)
        {
           return dna.Replace('T', 'U');
        }
    }
}
