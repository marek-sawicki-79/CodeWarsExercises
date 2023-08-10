using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalSum
{
    public static class Kata
    {
        public static int DiagonalSum(int[,] matrix)
        {
            //int sum = 0;
            //for(int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    sum += matrix[i, i];
            //}
            //return sum;

            return Enumerable.Range(0, matrix.GetLength(0)).Sum(i => matrix[i, i]);
        }
    }
}
