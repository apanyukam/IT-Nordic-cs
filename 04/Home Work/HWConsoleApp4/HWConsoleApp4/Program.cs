//Lesson 04 home work 

using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace HWConsoleApp4
{
	class Program
	{
		[Flags]
		enum PackageSizeType
		{
			None = 0x0,
			Small = 0x1,
			Medium = 0x1 << 1,
			Large = 0x1 << 2
		}
		static void Main(string[] args)
		{
			Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
			Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;

			byte packageSmall = 1;
			byte packageMedium = 5;
			byte packageLarge = 20;
			double volumeJuice;
			double numberPackageLarge;
			double numberPackageMedium;
			double numberPackageSmall;

			try
			{
				Console.Write("\nКакой объем сока (в литрах) требуется упаковать: ");
				volumeJuice = double.Parse(Console.ReadLine());
				if (volumeJuice < 0)
					throw new Exception("Отрицательное число");
				else
				{
					numberPackageLarge = Math.Floor(volumeJuice / packageLarge);
					numberPackageMedium = Math.Floor((volumeJuice % packageLarge) / packageMedium);
					numberPackageSmall = Math.Ceiling(((volumeJuice % packageLarge) % packageMedium) / packageSmall);

					var UsedPackageTypes = PackageSizeType.None;
					if (numberPackageLarge > 0)
						UsedPackageTypes = UsedPackageTypes | PackageSizeType.Large;
					if (numberPackageMedium > 0)
						UsedPackageTypes = UsedPackageTypes | PackageSizeType.Medium;
					if (numberPackageSmall > 0)
						UsedPackageTypes = UsedPackageTypes | PackageSizeType.Small;

					Console.WriteLine($"\nДля упаковки {volumeJuice} л. сока потребуется: ");
					if ((UsedPackageTypes & PackageSizeType.Large) == PackageSizeType.Large)
						Console.WriteLine($"Пакеты 20л: {numberPackageLarge} шт.");
					if ((UsedPackageTypes & PackageSizeType.Medium) == PackageSizeType.Medium)
						Console.WriteLine($"Пакеты  5л: {numberPackageMedium} шт.");
					if ((UsedPackageTypes & PackageSizeType.Small) == PackageSizeType.Small)
						Console.WriteLine($"Пакеты  1л: {numberPackageSmall} шт.");
					if (volumeJuice == 0)
						Console.WriteLine("\nУпаковка не нужна.");
					Console.ReadLine();
				}
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