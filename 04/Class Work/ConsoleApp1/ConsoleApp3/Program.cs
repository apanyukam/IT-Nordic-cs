using System;

namespace ConsoleApp3
{
	class Program
	{
		static void Main(string[] args)
		{
			double a, h, s1, s2, v;
			Console.Write("Введите a: ");
			a = double.Parse(Console.ReadLine());
			Console.Write("Введите h: ");
			h = double.Parse(Console.ReadLine());
			s1 = 3 * a * h;
			s2 = ((double)3 / 2) * a * (a * Math.Sqrt(3) + (2 * h));
			v = Math.Pow(a, 2) / 2 * (h / Math.Sqrt(2) * Math.Sqrt(3));
			Console.WriteLine($"\nSбок = {s1}  \nSполн = {s2} \nV = {v}");
		}
	}
}
