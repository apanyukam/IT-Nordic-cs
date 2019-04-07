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

			var documens = new BaseDocument[2];

			documens[0] = new Passport(
				"123 345 67",
				DateTimeOffset.Parse("12-02-2012"),
				"РФ",
				"Игорь Смиронов");

			documens[1] = new Passport(
				"123 347 67",
				DateTimeOffset.Parse("14-06-1999"),
				"РФ",
				"Игорь Иванов");

			foreach (var document in documens)
			{
				if (document is Passport)
				{
					((Passport)document).ChangeIssueDate(DateTimeOffset.UtcNow);
				}
				document.WriteToConsole();
			}
			
		}
	}
}
