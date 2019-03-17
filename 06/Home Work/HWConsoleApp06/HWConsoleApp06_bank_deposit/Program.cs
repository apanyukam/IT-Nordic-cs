using System;
using System.Globalization;
using System.Text;
using System.Threading;

namespace HWConsoleApp06_bank_deposit
{
	class Program
	{
		static void Main(string[] args)
		{
			Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
			Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;

			try
			{
				double deposit = 0;
				while (true)
				{
					Console.Write("Введите первоначальный вклад: ");
					deposit = double.Parse(Console.ReadLine());
					if (deposit <= 0)
					{
						Console.WriteLine("Ошибка! Необходимо ввести число больше 0: ");
						continue;
					}
					break;
				}

				Double bankRate = 0;
				while (true)
				{
					Console.Write("Введите ежедневный процент дохода в виде десятичной дроби (0,03% = 0.0003): ");
					bankRate = double.Parse(Console.ReadLine());
					if (bankRate <= 0)
					{
						Console.WriteLine("Ошибка! Необходимо ввести число больше 0: ");
						continue;
					}
					break;

				}

				double accumulation = 0;
				while (true)
				{
					Console.Write("Введите желаеммую сумму накопления: ");
					accumulation = double.Parse(Console.ReadLine());
					if (accumulation <= deposit)
					{
						Console.WriteLine("Ошибка! Сумма накопления должна быть больше первоночального вклада");
						continue;

					}
					break;
				}

				double calculationAccumulation = deposit;
				uint indexDays = 0;
				while (calculationAccumulation <= accumulation)
				{
					calculationAccumulation += deposit * bankRate;
					indexDays++;
				}
				Console.WriteLine($"Необходимое количество дней для накопления желаемой суммы: {indexDays}");

			}
			catch (Exception e)
			{
				Console.WriteLine($"Ошибка: {e}");
				throw;
			}
		}
	}
}

