using System;

namespace CWConsoleApp12
{
	class Program
	{
		static void Main(string[] args)
		{
			BaseDocument bd1 = new BaseDocument("Passport", "123 123 133", DateTimeOffset.Parse("25-12-1983"));
			//{
			//	DocName = "Passport",
			//	DocNumber = "123 123 133",
			//	IssueDate = DateTimeOffset.Parse("25-12-1983")
				
			//};
			bd1.WriteToConsole();

			Passport bd2 = new Passport("123 123 133", DateTimeOffset.Parse("25-12-1983"), "Russia", "Igor Suhov");
			//{
			//	DocName = "Passport",
			//	DocNumber = "123 123 133",
			//	IssueDate = DateTimeOffset.Parse("25-12-1983"),
			//	Country = "Russia",
			//	PersonName = "Igor Suhov"
			//};
			bd2.WriteToConsole();

			BaseDocument[] p1 = new BaseDocument[3];
		
			for (int i = 0; i < p1.Length; i++)
			{

			}
			
		}
	}
}
