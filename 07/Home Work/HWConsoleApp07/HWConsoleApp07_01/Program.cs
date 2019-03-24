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
			Console.Title = "Lesson 07 Home Work 01";
			Console.WriteLine("******* Выводит количество слов начинающих на А ********");
		
			Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
			Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;

			string userString = "";
			string[] wordsInUserString;
			int sumCharStartWithA = 0;
			Console.WriteLine("Введите строку из нескольких слов: ");

			while (true)
			{
				userString = Console.ReadLine();
				wordsInUserString = userString.Split(' ', StringSplitOptions.RemoveEmptyEntries);

				if (wordsInUserString.Length >= 2)
					break;
				Console.WriteLine("Введенная строка не соответствует условию. Необходимо ввести строку хотябы из двух слов");
			}

			for (int i = 0; i < wordsInUserString.Length; i++)
			{
				wordsInUserString[i] = wordsInUserString[i].ToUpper();

				//check for a symbol in Cyrillic and Latin
				if (wordsInUserString[i].StartsWith('А') || wordsInUserString[i].StartsWith('A'))
					sumCharStartWithA++;
			}
			Console.WriteLine("Количество слов, начинающихся с буквы 'А': " + sumCharStartWithA);
			Console.ReadLine();
		}
	}
}