using System;
using System.Diagnostics;

namespace CWConsoleApp09_01
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i = 1; i <= 10; i++)
			{
				int[] initialArray = GetTestArray(i*1000, 1000000);
				Stopwatch stopwatch = new Stopwatch();

				//WrieArrayState("Initial state:", initialArray);

				int[] bubbleSortedArray = (int[])initialArray.Clone();


				stopwatch.Start();

				BubbleSort(bubbleSortedArray);
				stopwatch.Stop();

				//WrieArrayState("Sorted state: ", bubbleSortedArray);

				Console.WriteLine($"Bubble sort done in {stopwatch.ElapsedMilliseconds} ms");

				int[] dotnetSortedArray = (int[])initialArray.Clone();

				stopwatch.Restart();
				Array.Sort(dotnetSortedArray);
				stopwatch.Stop();
				Console.WriteLine($"Dotnet sort done in {stopwatch.ElapsedMilliseconds} ms");
			}
		}

		private static int[] GetTestArray(int length, int maxValue)
		{
			var arr = new int[length];
			var rnd = new Random();
			for (var i = 0; i < arr.Length; i++)
			{
				arr[i] = rnd.Next(maxValue);

			}
			return arr;
		}

		private static void WrieArrayState(string message, int[] arr)
		{
			Console.WriteLine(message);
			for (var i = 0; i < arr.Length; i++)
			{
				Console.WriteLine(arr[i]);
			}
		}

		private static void BubbleSort(int[] arr)
		{
			for (int i = 0; i < arr.Length - 1; i++)
			{
				//var limit = arr.Length - 1 - i;
				for (int j = 0; j < arr.Length - 1 - i; j++)
				{
					if (arr[j] > arr[j + 1])
					{
						// поменять местами
						int temp = arr[j];
						arr[j] = arr[j + 1];
						arr[j + 1] = temp;

					}
				}
			}
		}
	}
}
// x=y