using System;
using System.Collections.Generic;
using System.Text;

namespace CWConsoleApp12
{

	class Passport : BaseDocument // наследуемый класс

	{
		public string Country { get; set; }
		public string PersonName { get; set; }

		public Passport(
			string docNumber,
			DateTimeOffset issueDate)
			: base("passport", docNumber, issueDate)
		{
		}




		public Passport(
			string docNumber,
			DateTimeOffset issueDate,
			string country,
			string personalName)
			: base("passport", docNumber, issueDate)
		{
			DocNumber = docNumber;
			IssueDate = issueDate;
			Country = country;
			PersonName = personalName;
			IssueDate = issueDate;
		}

		public void ChangeIssueDate()
		{
			IssueDate = IssueDate.UtcDateTime; // доделать
		}

		public override string PropertiesString
		{
			get
			{
				return $"{DocName}, {DocNumber}, {IssueDate: dd-MM-yy}, {Country}, {PersonName}";
			}
		}


		//public void WriteToConsole()
		//{
		//	Console.WriteLine(PropertiesString);
		//}
	}
}
