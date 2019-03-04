using System;
using System.Collections.Generic;
using System.Text;

namespace HWConsoleApp3_v3
{
	class PersonAgeCalculator
	{
		public void PersonInputCalculate(int[] ageDigital, int[] ageFourYear)
		{
			for (int i = 0; i < ageDigital.Length; i++)
			{
				ageFourYear[i] = ageDigital[i]+4;
			}
		}
		
	}
}
