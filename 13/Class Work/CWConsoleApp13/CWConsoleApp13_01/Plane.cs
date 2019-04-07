using System;
using System.Collections.Generic;
using System.Text;

namespace CWConsoleApp13_01
{
	public class Plane: FlyingObject
	{
		public byte EnginesCount { get; private set; }

		public Plane(int maxHeight, byte enginesCount) : base(maxHeight)
		{
			EnginesCount = enginesCount;
			Console.WriteLine("It’s a plane, welcome aboard!");
		}

		public void WriteAllProperties()
		{
			Console.WriteLine(
				$"Properties of {GetType().Name}:" +
				$"\n\t{nameof(EnginesCount)}:\t{EnginesCount}" +
				$"\n\t{nameof(MaxHeight)}:\t{MaxHeight}" +
				$"\n\t{nameof(CurrentHeight)}:\t{CurrentHeight}\n");
		}

	}

}
