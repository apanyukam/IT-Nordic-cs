using System;

namespace CWConsoleApp10_01
{
	class Program
	{
		static void Main(string[] args)
		{
			// первый вариант рекомендуемый
			Pet a1 = new Pet
			{
				Kind = "Dog",
				Name = "Charli",
				Age = 2,
				Sex ='M'
			};
			Console.WriteLine(a1.PropertiesString);

			//второй вариант
			Pet a2 = new Pet();
			a2.Kind = "Cat";
			a2.Name = "Barsic";
			a2.Age = 5;
			a2.Sex = 'F';
			Console.WriteLine(a2.PropertiesString);


		}
	}
}
