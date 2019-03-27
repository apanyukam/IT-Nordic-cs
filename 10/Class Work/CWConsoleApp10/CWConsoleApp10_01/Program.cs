using System;

namespace CWConsoleApp10_01
{
	class Program
	{
		static void Main(string[] args)
		{
			// первый вариант рекомендуемый
			Pet dog = new Pet
			{
				Kind = "Dog",
				Name = "Charli",
				DateOfBirth = DateTimeOffset.Parse("2011-03-12"),
				Sex ='M'
			};
			//Console.WriteLine(a1.PropertiesString);

			dog.WriteDescription(false);
			Console.WriteLine(dog.PropertiesString);
			
		}
	}
}
