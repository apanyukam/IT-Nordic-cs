using System;

namespace CWConsoleApp06
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите слово любое слово: ");

			do
			{
				string a = Console.ReadLine();
				if (a == "exit")
					break;

				int lenght = Console.ReadLine().Length;
				if (lenght > 15)
				{
					Console.Write("Too long string. Try anothe: ");
					continue;
				}
					Console.WriteLine($"Entered string length is: {lenght}");
				}
			while (true);

			Console.ReadLine();
		}
	}
}
