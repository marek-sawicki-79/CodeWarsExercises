using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheCapitals
{
	public static class Kata
	{
		public static int[] Capitals(string word)
		{
            char[] wordArr = word.ToCharArray();
			List<int> capitalIndex = new List<int>();
			int index = 0;
			foreach(char c in wordArr)
            {
                if (char.IsUpper(c))
                {
					capitalIndex.Add(index);
				}
				index++;
			}
			return capitalIndex.ToArray();
		}
	}
}
