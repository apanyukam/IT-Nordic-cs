
using System;

namespace CWConsoleApp14
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var errorList = new ErrorList("   "))
			{
				errorList.Add("I/O error");
				errorList.Add("Some unknown error");
				errorList.Add("Ошибка ...");

				errorList.WriteToConsole();
				//foreach (string error in errorList)
				//{
				//	Console.WriteLine(errorList.Category + " " + error);
				//}
			}
		}
	}
}
