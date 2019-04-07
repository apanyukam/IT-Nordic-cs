﻿using System;

namespace CWConsoleApp13_01
{
	class Program
	{
		static void Main(string[] args)
		{

			var plane = new Plane(100, 4);
			plane.TakeUpper(120);
			plane.TakeLower(100);
			plane.WriteAllProperties();

			var helicopter = new Helicopter(80, 3);
			helicopter.TakeUpper(120);
			helicopter.TakeLower(60);
			helicopter.WtiteAllProperties();
		}
	}
}
