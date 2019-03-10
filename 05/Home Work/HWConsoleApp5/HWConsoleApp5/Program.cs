//Lesson 05 home work_colors 
using System;
using System.Globalization;
using System.Text;
using System.Threading;


namespace HWConsoleApp5_Colors
{
	[Flags]
	enum MyColors
	{
		None = 0x0,
		Black = 0x1,
		Blue = 0x1 << 1,
		Cyan = 0x1 << 2,
		Grey = 0x1 << 3,
		Green = 0x1 << 4,
		Magenta = 0x1 << 5,
		Red = 0x1 << 6,
		White = 0x1 << 7,
		Yellow = 0x1 << 8
	}
	class Program
	{
		static void Main(string[] args)
		{
			Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
			Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;

			Console.Title = "Home work 05_colors";

			MyColors allColors = MyColors.None | MyColors.Black | MyColors.Blue |
			    MyColors.Cyan | MyColors.Green | MyColors.Grey | MyColors.Magenta |
			    MyColors.Red | MyColors.White | MyColors.Yellow;
			Console.WriteLine($"\nВыберите четыре любимых цвета из списка: {allColors}");
			try
			{
				MyColors favoriteColors = MyColors.None;
				string[] colorRequestNumber = { "первый", "второй", "третий", "четвертый" };
				MyColors[] color = new MyColors[4]; // array of selected colors
				for (int i = 0; i < 4; i++)
				{
					Console.Write($"\nВведите {colorRequestNumber[i]} любимый цвет: ");
					object color1; // temporary variable for user input validation
					while (true)
					{
						if (Enum.TryParse(typeof(MyColors), Console.ReadLine(), true, out color1))
						{
							color[i] = (MyColors)color1;
							break;
						}
						else
							Console.WriteLine("Ошибка!");
					}
					Console.WriteLine($"Цвет {colorRequestNumber[i]} выбран: {color[i]}");
					favoriteColors = favoriteColors | color[i];
				}

				MyColors notFavoriteColors;
				notFavoriteColors = allColors ^ favoriteColors;
				Console.WriteLine($"\nЦвета в палитре Избранное : {favoriteColors}");
				Console.WriteLine($"\nЦвета не вошедшие в палитру Избранное: {notFavoriteColors}");
				Console.ReadLine();
			}
			catch (Exception e)
			{
				Console.Write("Введены некорректные данные: ");
				Console.WriteLine(e.Message);
				throw;
			}
		}
	}
}
