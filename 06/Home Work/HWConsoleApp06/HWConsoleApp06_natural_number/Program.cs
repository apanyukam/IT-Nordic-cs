using System;
using System.Globalization;
using System.Text;
using System.Threading;

namespace HWConsoleApp06_naturalNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
			Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;
			int comparisonNamber = 2000000000;
			int userNumber = 0;
			uint quantityEvenNumbers = 0;

			Console.WriteLine($"Введите натуральное число не более {comparisonNamber}:");
			string stringNumber = Console.ReadLine();
			while (true)
			{
				try
				{
					userNumber = int.Parse(Console.ReadLine());

					if (userNumber > 0 && userNumber <= comparisonNamber)
						break;
					Console.WriteLine($"Ошибка! Введите число натуральное число не больше {comparisonNamber}:");
				}
				catch (FormatException e)
				{
					Console.WriteLine($"Error {e.GetType()}! Try again");
					continue;
				}
				catch (OverflowException e)
				{
					Console.WriteLine($"Error {e.GetType()}! Try again");
					continue;
				}
			}

			int indexNaturalNumber = 0;
			int userNumberCalculation = userNumber;
			while (userNumberCalculation != 0)
			{
				indexNaturalNumber = userNumberCalculation / 10;
				if (indexNaturalNumber % 2 == 0)
					quantityEvenNumbers++;
				userNumberCalculation = (userNumberCalculation - indexNaturalNumber) / 10;
			}
			Console.WriteLine(" В числе {0} количество четных чисе: {1}", userNumber, quantityEvenNumbers);
		}
	}
}