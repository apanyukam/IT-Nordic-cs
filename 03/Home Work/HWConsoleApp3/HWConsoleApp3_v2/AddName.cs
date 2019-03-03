using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace HWConsoleApp3_v2
{
	class AddName
		
	{
		public void AskName(int i, string[] name)

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
			name[i] = Console.ReadLine();
		}
	}
}
