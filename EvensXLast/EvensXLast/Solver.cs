using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvensXLast
{
	public static class Solver
	{
		public static int EvenTimesLast(int[] arr)
		{
			if (arr.Length == 0)
			{
				return 0;
			}
			List<int> evensList = new List<int>();
			for(int i = 0; i < arr.Length; i++)
            {
				if (i % 2 == 0)
				{
					evensList.Add(arr[i]);
				}
            }
			return evensList.Sum() * arr[arr.Length -1];
		}
	}
}
