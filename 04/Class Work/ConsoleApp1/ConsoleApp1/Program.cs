using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int a;
			int b;
			Console.WriteLine("Ввести первое число");
			a = int.Parse(Console.ReadLine());
			Console.WriteLine("Ввести второе число");
			b = int.Parse(Console.ReadLine());
			Console.WriteLine(a == b);
			Console.WriteLine(a != b);
			Console.WriteLine(a > b);
			Console.WriteLine(a < b);
			Console.WriteLine(a <= b);
			Console.WriteLine(a >= b);
		}
	}
}
