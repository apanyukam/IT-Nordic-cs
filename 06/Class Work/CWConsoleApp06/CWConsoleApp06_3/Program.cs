using System;

class Program
{
	static void Main()
	{
		// Weekly school marks
		var marks = new[]
		{
			new [] { 2, 3, 3, 2, 3 }, // Monday (it was a good weekend :)
			new [] { 2, 4, 5, 3 },    // Tuesday (anyway better than Monday)
			null,                     // Wednesday (felt sick, stayed at home :( )
			new [] { 5, 5, 5, 5 },    // Thursday (God mode :)
			new [] { 4 }              // Friday (a very short day)
		};

		// Overall average mark by the week
		int overalMarkWeek = 0;

		// Overall number of marks by the week
		int overallMarkDay = 0;

		// Iterating through the days
		for (int dayWeek = 0; dayWeek < marks.Length; dayWeek++)
		{
			if (marks[dayWeek] == null)
			{
				Console.WriteLine($"The average mark for day {dayWeek} is N/A");
				continue;
			}

			// Iterating through the marks during that day
			int dailySum = 0;
			for (int markIndex = 0; markIndex < marks[dayWeek].Length; markIndex++)
			{
				dailySum += marks[dayWeek][markIndex];
			}

			Console.WriteLine("The average mark for day {0} is {1:0.0}",
				dayWeek,
				(float)dailySum / marks[dayWeek].Length);

			overalMarkWeek += dailySum;
			overallMarkDay += marks[dayWeek].Length;
		}

		Console.WriteLine("The average mark for all the week is {0:0.0}",
			(float)overalMarkWeek / overallMarkDay);

		Console.WriteLine("Press any key to exit...");
		Console.ReadKey();
	}
}
