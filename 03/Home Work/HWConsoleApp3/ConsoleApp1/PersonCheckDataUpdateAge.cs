using System;
using System.Collections.Generic;
using System.Text;

namespace HWConsoleApp3_v3
{
	class PersonCheckDataUpdateAge
	{
		public void CheckInputData(int i, string[] ageString, int[] ageDigital, string[] namePerson)
		{
			int a;
			while (int.TryParse(ageString[i], out a) == false)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"\n!Ошибка ввода данных возраста друга {namePerson[i]}");
				Console.ResetColor();
				new PersonAgeReader().AskInputAge(i, namePerson, ageString);
			}
			ageDigital[i] = a;
		}
	}
}
