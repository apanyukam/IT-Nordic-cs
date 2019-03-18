using System;
using System.Collections.Generic;
using System.Linq;

namespace CWConsoleApp08_02_Distonary
{
	class Program
	{
		static void Main(string[] args)
		{
			var countres = new Dictionary<string, string>(3)
			{
				{"Russia", "Moscow"},
				{"USA", "New York" },
				{"Gemany", "Berlin" }
			};

			Console.WriteLine("Введите столицу государства: ");

			while (true)
			{
				int i = (new Random()).Next(4);
				KeyValuePair<string, string> el3 = countres.ElementAt(3);
				string 

				Console.WriteLine("Введите столицу государства: ");
				Console.WriteLine(el3);
				string country = Console.ReadLine();
				if () // доделать
				{
					Console.WriteLine("Угадал, МОЛОДЕЦ!");
					continue;
				}
				else
				{
					Console.WriteLine("Не угадал");
					break;
				}
			}



		}
	}
}
