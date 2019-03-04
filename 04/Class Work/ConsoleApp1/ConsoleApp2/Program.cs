using System;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			long a;
			int b;
			Console.WriteLine("Введите число типа long");
			a = long.Parse(Console.ReadLine());
			if (a <= int.MaxValue && a>= int.MinValue)
			{
				b = (int)a;
				Console.WriteLine(b);
			}
			else
			{
				Console.WriteLine("!ERROR");
			}
		}
	}
}
