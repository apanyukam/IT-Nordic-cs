using System;
using System.Collections.Generic;
using System.Text;

namespace HWConsoleApp3_v3
{
	class PersonAgeReader
	{
		public void AskInputAge(int i, string[] namePerson, string[] ageString)
		{
			switch (i)
			{
				case 0:
					Console.Write($"Введите возраст (полных лет) первого друга по имени {namePerson[i]} " +
						$"цифрами: ");
					break;
				case 1:
					Console.Write($"Введите возраст (полных лет) второго друга по имени {namePerson[i]} " +
						$"цифрами: ");
					break;
				case 2:
					Console.Write($"Введите возраст (полных лет) третьего друга по имени {namePerson[i]} " +
						$"цифрами: ");
					break;
			}
			ageString[i] = Console.ReadLine();
		}
	}
}
