using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Globalization;

namespace HWConsoleApp08
{
	class Program
	{
		static void Main(string[] args)
		{

			Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
			Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;

			Console.WriteLine("***Проверяет расстановку круглых и квадратных скобок " +
				"в строке на правильность ***");

			Stack<char> stackBrackets = new Stack<char>();
			//string userSting;
			Console.WriteLine("Введите строку из круглых и квадратных скобок: ");
			string userSting = Console.ReadLine();
			bool result = true;

			foreach (char c in userSting)
				switch (c)
				{
					case ')':
						if (stackBrackets.Pop() != '(')
							result = false;
						break;
					case ']':
						if (stackBrackets.Pop() != '[')
							result = false;
						break;
					case '[':
						stackBrackets.Push(c);
						break;
					case '(':
						stackBrackets.Push(c);
						break;
				}

			if (stackBrackets.Count > 0)
				result = false;
			if (result)
				Console.WriteLine(true);
			else
				Console.WriteLine(false);

			Console.ReadLine();
		}
	}
}
