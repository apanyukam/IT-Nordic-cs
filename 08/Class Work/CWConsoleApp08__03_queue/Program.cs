using System;
using System.Collections.Generic;

namespace CWConsoleApp08__03_queue
{
	class Program
	{
		static void Main(string[] args)
		{
			Queue<int> userNumbers = new Queue<int>();
			while (true)
			{
				Console.WriteLine("Введите число для вычичлений и run для вычислений. Exit завершит программу: ");
				string userString = Console.ReadLine();
				if (int.TryParse(userString, out int number))
				{
					userNumbers.Enqueue(number);
				}

				if (userString == "run") //доделать
				{
					while ()
					{

					}
				}
				else if(userString == "exit")
				{
					break;
				}

			}
		}
	}
}
