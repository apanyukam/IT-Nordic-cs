using System;

namespace CWConsoleApp07_01
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("введите два числа: ");
			double a = double.Parse(Console.ReadLine());
			 
			double b = double.Parse(Console.ReadLine());

			Console.WriteLine("Конкатенация: ");
			Console.WriteLine(a + " * " + b + " = " + a * b);

			Console.WriteLine("форматирование: ");
			Console.WriteLine("{0:#.##} + {1:#.##} = {2:#.##}", a, b, a+b);

			Console.WriteLine("Инторполяция: ");
			Console.WriteLine($"{a:#.#} - {b:#.#} = {a - b}");



		}
	}
}
