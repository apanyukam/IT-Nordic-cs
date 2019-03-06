using System;

namespace CWConsoleApp4_2
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("Введите целое число:");
				Console.WriteLine("Число " + (int.Parse(Console.ReadLine()) >= 0
					? "неотрицательное"
					: "отрицательное"));
			}
			catch (FormatException e)
			{
				Console.WriteLine("введены неверные данные");
				Console.WriteLine(e.Message);
				throw;
			}

		}
	}

}
