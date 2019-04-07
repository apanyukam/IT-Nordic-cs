using System;
using System.Collections.Generic;
using System.Text;

namespace CWConsoleApp12
{
	class BaseDocument // базовый класс
	{
		public string DocName { get; set; }
		public string DocNumber { get; set; }
		public DateTimeOffset IssueDate { get; set; }

		public BaseDocument (string docName, string docNumber, DateTimeOffset issueDate)
		{
			DocName = docName;
			DocNumber = docNumber;
			IssueDate = issueDate;
		}

		public virtual string PropertiesString
		{
			get
			{
				return $"{DocName}, {DocNumber}, {IssueDate: dd-MM-yy}";
			}
	    }

		public virtual void WriteToConsole()
		{
			Console.WriteLine(PropertiesString);
		}
	}
}
