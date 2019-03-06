using System;
using System.Text;

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
			byte packageSmall = 1;
			byte packageMedium = 5;
			byte packageLarge = 20;
			double volumeJuice;
			double numberPackageLarge;
			double numberPackageMedium;
			double numberPackageSmall;

			Console.Write("Какой объем сока (в литрах) требуется упаковать: ");
			volumeJuice = double.Parse(Console.ReadLine());

			numberPackageLarge = Math.Floor(volumeJuice / packageLarge);
			numberPackageMedium = Math.Floor((volumeJuice % packageLarge) / packageMedium);
			if ((((volumeJuice % packageLarge) % packageMedium) % packageSmall) > 0)
			{
				numberPackageSmall = Math.Floor(((volumeJuice % packageLarge) % packageMedium) / packageSmall) + 1;
			}
			else
			{
				numberPackageSmall = Math.Floor(((volumeJuice % packageLarge) % packageMedium) / packageSmall);
			}

			var UsedPackageTypes = PackageSizeType.None;
			if (numberPackageLarge > 0)
			{
				UsedPackageTypes = PackageSizeType.Large;
				Console.WriteLine($"{UsedPackageTypes}:{numberPackageLarge}");
			}

			if (numberPackageMedium > 0)
			{
				UsedPackageTypes = PackageSizeType.Medium;
				Console.WriteLine($"{UsedPackageTypes}:{numberPackageMedium}");
			}

			if (numberPackageSmall > 0)
			{
				UsedPackageTypes = PackageSizeType.Small;
				Console.WriteLine($"{UsedPackageTypes}:{numberPackageSmall}");
			}
			Console.ReadLine();
		}
	}
}