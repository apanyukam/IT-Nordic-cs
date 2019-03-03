// Lesson 03 home work version 1
using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;


namespace HWConsoleApp3  
{
	class Program
	{
		static void Main(string[] args)
		{
			Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
			Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;
			
			Console.Title = "Home work 03 version 1";
			Console.WriteLine("\nНеобходимо ввести имена трех друзей и их возраст." +
				"\nПрограмма рассчитает возраст через четыре года.");

			string[] name = new string[3]; //Array names
			int[] age = new int[3]; //Array ages
			string[] age1 = new string[3]; //Array to check the input type for the age variable

			for (int i = 0; i < name.Length; i++)
			{
				switch (i)
				{
					case 0:
						Console.Write("\nВведите имя первого друга: ");
						break;
					case 1:
						Console.Write("\nВведите имя второго друга: ");
						break;
					case 2:
						Console.Write("\nВведите имя третьего друга: ");
						break;
				}
				name[i] = Console.ReadLine();
			_m:
				switch (i)
				{
					case 0:
						Console.Write($"Введите возраст (полных лет) первого друга по имени {name[i]} " +
							$"цифрами от 0 до 255: ");
						break;
					case 1:
						Console.Write($"Введите возраст (полных лет) второго друга по имени {name[i]} " +
							$"цифрами от 0 до 255: ");
						break;
					case 2:
						Console.Write($"Введите возраст (полных лет) третьего друга по имени {name[i]} " +
							$"цифрами от 0 до 255: ");
						break;
				}
				age1[i] = Console.ReadLine();
				if (int.TryParse(age1[i], out int a) == true)
				{
					age[i] = a + 4;
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine($"\n!Ошибка ввода данных возраста друга {name[i]}");
					Console.ResetColor();
					goto _m;
				}
			}
			for (int i = 0; i < age.Length; i++)
			{
				Console.WriteLine($"\nИмя: {name[i]}, возраст через 4 года: {age[i]}");
			}
			Console.WriteLine("Нажмите любую клавишу для завершения < >:");
			Console.ReadKey();
		}

	}
}
