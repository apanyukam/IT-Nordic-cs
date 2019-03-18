using System;
using System.Collections.Generic;

namespace CWConsoleApp08_01_List

{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> intList = new List<int>();
			intList.Add(10);
			intList.Add(20);
			intList.Add(30);
			intList.Add(40);

			Console.WriteLine(string.Join(", ", intList));

			List<int> intList2 = new List<int> { 23, 45, 67, 45 };
			intList2.AddRange(new[] { 1, 10 });
			Console.WriteLine(string.Join(", ", intList2));

			intList2.RemoveRange(2, 2);
			Console.WriteLine(string.Join(", ", intList2));

		}
	}
}
