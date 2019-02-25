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
			double d = Math.Pow(r, 2);
			double s = Math.PI * d;
			Console.WriteLine("Площадь круга = "+ s);
		}

	}
}
