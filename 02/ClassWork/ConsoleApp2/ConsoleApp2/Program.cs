using System;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите радиус круга");
			string radius = Console.ReadLine();
			float r = float.Parse(radius);
			//double d = Math.Pow(r, 2); //Матиматическая функцмя возведения числа в степень. R - чмсло, 2 - степень. Вместо 2 может бить любое число.
			double s = Math.PI * Math.Pow(r, 2); // Math.PI - математическая функция число Пи.
			Console.WriteLine("Площадь круга = "+ s);
			Console.ReadKey();
		}

	}
}
