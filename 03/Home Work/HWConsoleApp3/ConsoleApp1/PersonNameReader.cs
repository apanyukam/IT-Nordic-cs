using System;
using System.Collections.Generic;
using System.Text;

namespace HWConsoleApp3_v3
{
	class PersonNameReader
	{
		public void AskInputName(int i, string[] namePerson)
		{
			switch (i)
			{
				case 0:
					Console.Write("\nВведите имя первого друга: ");
					break;
				case 1:
					Console.Write("\nВведите имя второго друга: ");
					break;
				case 2:
					Console.Write("\nВведите имя третьего друга: ");
					break;
			}
			namePerson[i] = Console.ReadLine();
		}
	}
}
