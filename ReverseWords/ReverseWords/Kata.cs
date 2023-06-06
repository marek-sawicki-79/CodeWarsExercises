using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWords
{
	public static class Kata
	{
		public static string ReverseWords(string str)
		{
			string[] splitString = str.Split(' ');
			List<string> reversedWords = new List<string>();
			foreach(string word in splitString)
            {
				char[] wordToArray = word.ToCharArray();
				Array.Reverse(wordToArray);
				string reversedWord = new string(wordToArray);
				reversedWords.Add(reversedWord);
            }
			string result = string.Join(' ', reversedWords);
			return result;
		}
	}
}
