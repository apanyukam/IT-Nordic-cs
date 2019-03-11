using System;

namespace CWConsoleApp06_2
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] a = { 2, 4, 6, 10 };
			int b = 0;
			int sum = 0;
			while(b<4)
			{
				sum = sum + a[b];
				b++;
				Console.WriteLine($"Сумма = {sum}");
			}
			Console.ReadLine();
		}
	}
}
