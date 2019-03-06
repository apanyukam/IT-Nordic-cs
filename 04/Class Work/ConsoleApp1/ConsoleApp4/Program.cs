using System;

namespace HWConsoleApp4
{
	class Program
	{
		enum Conteiners : byte
		{
			None = 0x0,
			ConteinerOwn = 0x1,
			ConteinerFive = 0x1 << 1,
			ConteinerTwenty = 0x1 << 2,
		}
		static void Main(string[] args)
		{

			//Conteiners a = Conteiners.ConteinerOwn | Conteiners.ConteinerTwenty;


		}
	}
}
