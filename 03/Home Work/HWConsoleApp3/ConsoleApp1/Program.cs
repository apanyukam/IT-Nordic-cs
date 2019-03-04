// Lesson 03 home work version 3

using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;


namespace HWConsoleApp3_v3
{
	class Program
	{
		static void Main(string[] args)
		{
			Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
			Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;

			Console.Title = "Home work 03 version 3";
			Console.WriteLine("\nНеобходимо ввести имена трех друзей и их возраст." +
				"\nПрограмма рассчитает возраст через четыре года.");

			string[] namePerson = new string[3]; //Array for storing names
			string[] ageString = new string[3]; //Array for storing input data age
			int[] ageDigital = new int[3]; //An array for storing age data in a numeric value
			int[] ageFourYear = new int[3]; // An array to store the age in four years

			for (int i = 0; i < namePerson.Length; i++)
			{
				new PersonNameReader().AskInputName(i, namePerson);
				new PersonAgeReader().AskInputAge(i, namePerson, ageString);
				new PersonCheckDataUpdateAge().CheckInputData(i, ageString, ageDigital, namePerson);
			}
			new PersonAgeCalculator().PersonInputCalculate(ageDigital, ageFourYear);
			Console.WriteLine("\n\n");
			for (int i = 0; i < ageDigital.Length; i++)
			{
				Console.WriteLine($"\nИмя: {namePerson[i]}, возраст через 4 года: {ageFourYear[i]}");
			}
			Console.WriteLine("\n\nНажмите любую клавишу для завершения < >:");
			Console.ReadKey();
		}
	}
}
