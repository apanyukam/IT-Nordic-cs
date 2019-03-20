using System;

namespace CWConsoleApp09_02
{
	class Program
	{
		static void Main(string[] args)
		{

			int a = 0;
			Increment(a);
			Console.WriteLine(a);
		}
		static void Increment(int val)
		{
			val++;
			Console.WriteLine(nameof(val) + " = " + val);

		}
		static void AddSuffix(string messege)
		{
			messege = messege + "suffix";

		}
	}
}
