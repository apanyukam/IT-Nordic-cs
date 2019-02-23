using System;
using System.Threading;

namespace DemoApp1
{
	class Program
	{
		static void Main(string[] args) //HomeWork Lesson1
		{
			Console.Title = "Home work Lesson 01";
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Введите имя и нажмите клавишу <ENTER>.");
			string name = Console.ReadLine();
			while (name.Length == 0) //checks if a name is entered
			{
				Console.WriteLine("****************************************************");
				Console.WriteLine("Вы не ввели имя. Введите имя и нажмите клавишу <ENTER>.");
				name = Console.ReadLine();
			}
			Console.WriteLine($"\n{name}, подождите 5 секунд.");
			Thread.Sleep(5000);
			Console.WriteLine($"\n\nРад познакомиться {name}! \nМеня зовут Анатолий. \n{name}, " +
				"наберитесь еще немного терпения. \nЧерез 5 секунд мы продолжим.");
			Thread.Sleep(5000);
			Console.WriteLine($"\n\nК сожалению, мне надо завершить наш диалог. До новых встреч {name}! \n\nЧтобы закрыть консоль, нажмите любую клавишу.");
			Console.ReadKey();
		}
	}
}