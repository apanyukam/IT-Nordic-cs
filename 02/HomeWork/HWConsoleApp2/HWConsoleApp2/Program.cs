using System;

namespace HWConsoleApp2 //Home Work Lesson 02 calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Console.Title = "Home Work lesson 02 - calculator";
			Console.WriteLine("\n******* КАЛЬКУЛЯТОР *******");

			string again = "да";
			while (again == "да") //the loop allows you to continue 
				                  //the calculation without leaving the program
			{
				Console.WriteLine("\n*************************");
				Console.WriteLine("\nВведите первое число и нажмите <ENTER>: ");
				double a = double.Parse(Console.ReadLine());

				Console.WriteLine("\nВведите математический оператор: <+> или <->" +
					" или <*> или </> или <^> или <%> и нажмите <ENTER>");
				char mathOperation = Convert.ToChar(Console.ReadLine());

				Console.WriteLine("\nВведите второе число и нажмите <ENTER>: ");
				double b = double.Parse(Console.ReadLine());
				
				if (mathOperation == '+')
				{
					double c = a + b;
					Console.WriteLine($"Сумма {a} и {b} равна {c}");
				}
				else if (mathOperation == '-')
				{
					double c = a - b;
					Console.WriteLine($"Разница {a} и {b} равна {c}");
				}
				else if (mathOperation == '*')
				{
					double c = a * b;
					Console.WriteLine($"Произведение {a} и {b} равно  {c}");
				}
				else if (mathOperation == '/')
				{
					double c = a / b;
					Console.WriteLine($"Деление {a} на {b} равно {c}");
				}
				else if (mathOperation == '/')
				{
					double c = Math.Pow(a, b);
					Console.WriteLine($"{a} в степени {b} равно {c}");
				}
				else if(mathOperation == '%')
				{
					double c = a % b;
					Console.WriteLine($"Остаток от деления {a} на {b} равно {c}");
				}
				else
				{
					Console.WriteLine($"Вы ввели неизвестный математический оператор <{mathOperation}>!");
				}
				Console.WriteLine("Если хотите продолжить, наберите <да>, " +
					"\nесли хотите завершить, наберите <нет> и нажмите <ENTER>: ");
				again = Console.ReadLine();
				again = again.ToLower();
			}
		}
	}
}
