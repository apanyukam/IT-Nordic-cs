using System;
using System.Collections.Generic;
using System.Text;

namespace CWConsoleApp10_01
{
	class Pet
	{
		public string Kind;
		public string Name;
		public char Sex;
		public byte Age;

		public string PropertiesString
		{
			get
			{
				return $"{Name} is a {Kind} ({Sex}) of {Age} years  old.";
			}

		}

	}
}
