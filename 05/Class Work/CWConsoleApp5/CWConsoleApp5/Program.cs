using System;

namespace CWConsoleApp5
{
	class Program
	{
		[Flags]
		enum Mycolors
		{
			
			Black = 0x1,
			Blue = 0x1 <<1,
			Cyan = 0x1 << 2,
			Grey = 0x1 << 3,
			Green = 0x1 << 4,
			Magenta = 0x1 << 5,
			Red = 0x1 << 6,
			White = 0x1 << 7,
			Yellow = 0x1 << 8
		}
		static void Main(string[] args)
		{
			MyColors[] favoriteColors = new MyColors[4];

			Console.WriteLine($"Введите избранные цвета из предложенных: {0}", string.Join(' ', Enum.GetNames(typeof(Mycolors)));		
			for (int i = 0; i < 4; i++)
			{
				while (true)
					object color;
				Console.Write("введите цвет")
			
				
			}
			//Console.WriteLine(color);
			
		}
	}
}
