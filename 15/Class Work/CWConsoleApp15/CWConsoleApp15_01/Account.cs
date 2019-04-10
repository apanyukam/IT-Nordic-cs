using System;
using System.Collections.Generic;
using System.Text;

namespace CWConsoleApp15_01
{
	class Account<T>
	{
		public string Name { get; private set; }
		public T Id { get; private set; }

		public Account(T id, string name)
		{
			Id = id;
			Name = name;
		}

		public void WriteProporties()
		{
			Console.WriteLine($"Name: {Name}, Id: {Id}");
		}
	}
}
