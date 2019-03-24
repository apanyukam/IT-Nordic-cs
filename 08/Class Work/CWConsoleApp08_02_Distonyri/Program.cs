using System;
using System.Collections.Generic;
using System.Linq;

namespace CWConsoleApp08_02_Distonary
{
	class Program
	{
		static void Main(string[] args)
		{
			var countries = new Dictionary<string, string>(3)
			{
				{"Russia", "Moscow"},
				{"USA", "New York" },
				{"Gemany", "Berlin" }
			};

			while (true)
			{
				int index = (new Random()).Next(3);
				KeyValuePair<string, string> kvp = countries.ElementAtOrDefault(index);
				string country = kvp.Key;
				string capital = kvp.Value;
				Console.Write($"Введите столицу страны \"{country}\": ");
				var answer = Console.ReadLine()?.Trim();
				if (answer == capital)
					Console.WriteLine("Правильно!");
				else
				{
					Console.WriteLine("Вы проиграли :( Выходим...");
					break;
				}
			}
			
		}
	}
}
