using System;
using System.Collections.Generic;
using System.Text;

namespace CWConsoleApp13_01
{
	public class Helicopter: FlyingObject
	{
		public byte BladesCount { get; private set;}

		public Helicopter(int maxHeight, byte bladesCount): base(maxHeight)
		{
			BladesCount = bladesCount;
			Console.WriteLine("It’s a helicopter, welcome aboard!");
		}

		public void WtiteAllProperties()
		{
			Console.WriteLine(
				$"Properties of {GetType().Name}:" +
				$"\n\t{nameof(BladesCount)}:\t{BladesCount}" +
				$"\n\t{nameof(MaxHeight)}:\t{MaxHeight}" +
				$"\n\t{nameof(CurrentHeight)}:\t{CurrentHeight}\n");
		}


	}
}
