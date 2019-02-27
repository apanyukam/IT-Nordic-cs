using System;

namespace ConsoleApp3
{
	class Program
	{
		static void Main(string[] args)
		{
			/*object age = (double)10; // или = 10D
			object age2 = 10.5634;
			Console.WriteLine((double)age*(double)age2);
			

			dynamic name1 = 10;
			dynamic name2 = "123.123";
			Console.WriteLine(name1 + double.Parse(name2, System.Globalization.CultureInfo.InvariantCulture.NumberFormat)); // или double.Parse(name2)
			Console.ReadLine();*/

			/*var a = 3.14F;
			var b = 1D;
			var c = 49L;
			var d = (byte)255;
			Console.WriteLine(a.GetType());
			Console.WriteLine(b.GetType());
			Console.WriteLine(c.GetType());
			Console.WriteLine(d.GetType());
			Console.ReadLine();*/


			//Console.WriteLine(default(string));
			//Console.ReadKey();

			//double? d = null;
			//do
			//{
			//	try
			//	{
			//		d = Convert.ToDouble(Console.ReadLine());
			//	}
			//	catch { }
			//} while (!d.HasValue);
			//Console.WriteLine(d.HasValue);

			string[] names = new string[5];
			for (int i = 0; i< names.Length; i++)
			{
				Console.WriteLine("введите имя пятерых друзей поочередно:");
				names[i]=Console.ReadLine();
						}
			for (int i = 0; i < names.Length; i++)
			{
				Console.WriteLine(names[i]); // доделать
				
			}



		}
	}
}
