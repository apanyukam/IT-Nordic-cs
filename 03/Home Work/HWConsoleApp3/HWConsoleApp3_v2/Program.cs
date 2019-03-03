// Lesson 03 home work version 2
using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace HWConsoleApp3_v2
{
	class Program
	{
		static void Main(string[] args)
		{
			Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
			Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;

			Console.Title = "Home work 03 version 02";
			Console.WriteLine("\nНеобходимо ввести имена трех друзей и их возраст." +
				"\nПрограмма рассчитает возраст через четыре года.");

			string[] name = new string[3]; //Array names
			int[] age = new int[3]; //Array ages
			string[] age1 = new string[3]; //Array to check the input type for the age variable

			for (int i = 0; i < name.Length; i++)
			{
				new AddName().AskName(i, name); // Add names
				new AddAge().ChangeAge(i, name, age1, age); //Add age of name after 4 years
			}
			Console.WriteLine("\n\n");
			for (int i = 0; i < name.Length; i++)
			{
				Console.WriteLine($"Имя: {name[i]}, возраст через 4 года: {age[i]}");
			}
			Console.WriteLine("\n\nНажмите любую клавишу для завершения < >:");
			Console.ReadKey();
		}
	}
}
