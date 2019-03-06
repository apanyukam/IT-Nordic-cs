using System;

namespace CWConsoleApp4_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите целое число:");
			Console.WriteLine("Число " + (int.Parse(Console.ReadLine()) >= 0
				? "неотрицательное"
				: "отрицательное"));
		}
	}
}
