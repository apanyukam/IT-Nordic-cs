using System;

namespace CWConsoleApp15_01
{
	class Program
	{
		static void Main(string[] args)
		{
			var personal1= new Account<int>(123, "Igor");
			personal1.WriteProporties();

			var personal2 = new Account<string>("125", "Oleg");
			personal2.WriteProporties();

			var personal3 = new Account<Guid>(Guid.NewGuid(), "Irina");
			personal3.WriteProporties();

		}
	}
}
  