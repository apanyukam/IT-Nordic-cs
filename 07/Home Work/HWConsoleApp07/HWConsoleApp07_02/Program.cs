using System;
using System.Globalization;
using System.Text;
using System.Threading;

namespace HWConsoleApp07_01
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Lesson 07 Home Work 02";

			Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
			Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;

			string userString = "";
			string[] wordsInUserString;
			
			Console.WriteLine("********* Выводит строку в обратном порядке ********");

			Console.WriteLine("Введите строку: ");

			while (true)
			{
				userString = Console.ReadLine();
				wordsInUserString = userString.Split(' ', StringSplitOptions.RemoveEmptyEntries);

				if (wordsInUserString.Length >= 1)
					break;
				Console.WriteLine("Введенная строка не соответствует условию. Попробуйте еще раз: ");
			}

			string invertedUserString = "";
			for (int i =userString.Length - 1; i >= 0; --i)
			{
				invertedUserString +=(userString.ToLower())[i];
			}

			Console.WriteLine(invertedUserString);
			Console.ReadLine();
		}
	}
}