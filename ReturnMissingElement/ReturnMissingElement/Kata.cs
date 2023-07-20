using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnMissingElement
{
    public static class Kata
    {
        public static int GetMissingElement(int[] superImportantArray)
        {
            //int[] blabla = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //return blabla.Except(superImportantArray).Single();

            return (int)Enumerable.Range(0, 9).Except(superImportantArray).FirstOrDefault();
        }
    }
}
