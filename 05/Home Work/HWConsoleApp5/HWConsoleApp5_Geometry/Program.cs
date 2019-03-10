//Lesson 05 home work_geometry
using System;
using System.Globalization;
using System.Text;
using System.Threading;


namespace HWConsoleApp5_Geometry
{
	class Program
	{
		enum Figures : byte
		{
			Сircle = 1,
			EquilateralTriangle = 2,
			Rectangle = 3
		}
		static void Main(string[] args)
		{
			Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
			Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;

			Console.Title = "Home work 05_geometry";
			Console.WriteLine("Программа расчитывает площадь и периметр фигур. " +
				"\nЗначения округляются до сотых ");
			try
			{
				Console.WriteLine("\nВведите тип фигуры: (1 - круг, 2 - равносторонний треугольник, 3 - прямоугольник) ");
				if (Enum.TryParse(Console.ReadLine(), out Figures a) != true)
					throw new Exception("Введено нечисловое значение фигуры");
				else
					switch (a)
					{
						case Figures.Сircle:
							Console.WriteLine("Введите диаметр круга: ");
							if (double.TryParse(Console.ReadLine(), out double diameterCircle))
							{
								double areaCircle = Math.Round(((1 / (double)4) * ((Math.PI) * Math.Pow(diameterCircle, 2))), 2);
								double perimetrCircle = Math.Round((Math.PI * diameterCircle), 2);
								Console.WriteLine($"Площадь круга = {areaCircle} \nПериметр круга = {perimetrCircle}");
								break;
							}
							else
							{
								throw new Exception("Введено нечисловое значение диаметра");
							}
						case Figures.EquilateralTriangle:
							Console.WriteLine("Введите длину стороны равностороннего треуголника: ");
							if (double.TryParse(Console.ReadLine(), out double sideLengthTriangle))
							{

								double areaEquilateralTriangle = Math.Round(((Math.Pow(sideLengthTriangle, 2) * Math.Sqrt(3)) / (double)4), 2);
								double perimetrEquilateralTriangle = Math.Round((3 * sideLengthTriangle), 2);
								Console.WriteLine($"Площадь равностороннего треугольника = {areaEquilateralTriangle} " +
									$"\nПериметр равностороннего треуголника = {perimetrEquilateralTriangle}");
								break;
							}
							else
								throw new Exception("Введено нечисловое значение длины");

						case Figures.Rectangle:
							Console.WriteLine("Введите ширину прямоугольника: ");
							if (double.TryParse(Console.ReadLine(), out double widthRectangle))
							{

								Console.WriteLine("Введите высоту прямоугольника: ");

								if (double.TryParse(Console.ReadLine(), out double heighRectangle))
								{
									double areaRectangl = Math.Round((widthRectangle * heighRectangle), 2);
									double perimetrRectangle = Math.Round((2 * (widthRectangle + heighRectangle)), 2);
									Console.WriteLine($"Площадь прямоугольника = {areaRectangl}" +
										$"\nПериметр прямоугольника = {perimetrRectangle}");
									break;
								}
								else
									throw new Exception("Введено нечисловое значение высоты");
							}
							else
								throw new Exception("Введено нечисловое значение ширины");
						default:
							throw new Exception("Введено неверное значение фигуры");
					}
				Console.ReadLine();
			}
			catch (Exception e)
			{
				Console.WriteLine("Ошибка: ");
				Console.WriteLine(e.Message);
				throw;
			}
		}
	}
}
