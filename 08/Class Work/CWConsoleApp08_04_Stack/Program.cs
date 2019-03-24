using System;
using System.Collections.Generic;


namespace CWConsoleApp08_04_Stack 
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack<bool> stack = new Stack<bool>();
			Console.WriteLine("Введите \"wash\", чтобы добавить тарелку в стопку помытых.");
			Console.WriteLine("Введите \"dry\" чтобы взять тарелку с вершины стопки для вытирания.");
			Console.WriteLine("Введите \"exit\" чтобы завершить работу.");
			string data;
			bool continueWork = true;
			while (continueWork)
			{
				data = Console.ReadLine().ToLower();
				switch (data)
				{
					case "wash":
						stack.Push(true);
						break;
					case "dry":
						if (stack.Count > 0)
							stack.Pop();
						else
							Console.WriteLine("Стопка тарелок пуста!");
						break;
					case "exit":
						continueWork = false;
						break;
				}
				Console.WriteLine($"Тарелок стопке на вытирание: {stack.Count}");
			}
		}
	}
}
