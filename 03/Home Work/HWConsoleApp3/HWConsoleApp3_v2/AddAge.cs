using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace HWConsoleApp3_v2
{
	class AddAge
	{
		public void ChangeAge(int i, string[] name, string[] age1, int[] age)
		{
		_m:
			switch (i)
			{
				case 0:
					Console.Write($"Введите возраст (полных лет) первого друга по имени {name[i]} " +
						$"цифрами от 0 до 255: ");
					break;
				case 1:
					Console.Write($"Введите возраст (полных лет) второго друга по имени {name[i]} " +
						$"цифрами от 0 до 255: ");
					break;
				case 2:
					Console.Write($"Введите возраст (полных лет) третьего друга по имени {name[i]} " +
						$"цифрами от 0 до 255: ");
					break;
			}
			age1[i] = Console.ReadLine();
			if (int.TryParse(age1[i], out int a) == true) 
			{
				age[i] = a + 4; //Add age plus 4 years
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"\n!Ошибка ввода данных возраста друга {name[i]}");
				Console.ResetColor();
				goto _m;
			}
		}
	}
}
