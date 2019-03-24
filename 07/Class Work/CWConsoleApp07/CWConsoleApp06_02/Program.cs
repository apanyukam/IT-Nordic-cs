using System;

namespace CWConsoleApp07_02
{
	class Program
	{
		static void Main(string[] args)
		{
			var test = "my test string";
			//Console.WriteLine(test.Substring(8, 7));
			string[] words = test.Split(" ");
			foreach (string word in words)
				Console.WriteLine(word);
		}
	}
}
