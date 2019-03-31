// Lesson 10 home work 

using System;
using System.Globalization;
using System.Text;
using System.Threading;

namespace HWConsoleApp10
{
	class Program
	{
		static void Main(string[] args)
		{
			Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
			Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;
			Console.Title = "Home work 10";

			Console.WriteLine("\nНеобходимо ввести имена трех друзей и их возраст." +
				"\nПрограмма рассчитает возраст через четыре года.");

			Person[] friend = new Person[3];
			for (int i = 0; i < 3; i++)
			{
				friend[i] = new Person();
				Console.Write($"Введите имя {i}: ");
				friend[i].NamePerson = Console.ReadLine();

				Console.Write($"Введите возраст {friend[i].NamePerson}: ");
				friend[i].AgePerson = PersonCheckAge();
			}

			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine(friend[i].DisplayInfoAboutPerson);
			}
			Console.WriteLine("\n\nНажмите любую клавишу для завершения < >:");
			Console.ReadKey();
		}

		static int PersonCheckAge()
		{
			int age;

			while (true)
			{
				try
				{
					age = int.Parse(Console.ReadLine());
					if (age > 0 && age <= 120)
						break;
					else
						throw new Exception();
				}
				catch (Exception e)
				{
					Console.WriteLine("Ошибка! Введите число больше 0 и меньше 120: ");
					continue;
				}
			}
			return age;
		}
	}
}
