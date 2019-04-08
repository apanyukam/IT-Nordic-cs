using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CWConsoleApp14
{
	class ErrorList : IDisposable, IEnumerable<string>
	{
		public static string OutputPrefixFormat;
		public string Category { get; private set; }
		private List<string> _errors;

		static ErrorList()
		{
			OutputPrefixFormat = "d MMMM, yyyy (h:mm)";
		}

		public ErrorList(string category)
		{
			_errors = new List<string>();
			Category = category;
		}


		public void WriteToConsole()
		{
			foreach(string error in _errors)
			{
				Console.WriteLine(DateTime.Now.ToString(OutputPrefixFormat) + ":" + error);
			}
		}

		public void Add(string error)
		{
			_errors.Add(error);
		}

		public void Dispose()
		{
			if (_errors != null)
			{
				_errors.Clear();
				_errors = null;
			}
		}

		public IEnumerator<string> GetEnumerator()
		{
			return _errors.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return _errors.GetEnumerator();
		}
	}
}
