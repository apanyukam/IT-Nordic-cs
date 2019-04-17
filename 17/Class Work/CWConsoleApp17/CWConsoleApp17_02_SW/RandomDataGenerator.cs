using System;
using System.Collections.Generic;
using System.Text;

namespace CWConsoleApp17_02_SW
{
	public delegate void RandomDataGeneratedHandler(int byteDone, int totalBytes);

	class RandomDataGenerator
	{
		public event RandomDataGeneratedHandler RandomDataGenerated;

		public event EventHandler RandomDataGenerationDone;

		public byte[] GetRandomData(int dataSize, int bytesDoneToRaiseEvent)
		{
			byte[] result = new byte[dataSize];
			Random rand = new Random();

			for (int i = 0; i < dataSize; i++)
			{
				result[i] = (byte)rand.Next(256);

				if ((i + 1) % bytesDoneToRaiseEvent == 0)
				{
					OnRandomDataGenerated(i + 1, dataSize);
				}
			}

			if (RandomDataGenerationDone != null)
			{
				RandomDataGenerationDone(this, EventArgs.Empty);
			}
			return result;
		}

		private void OnRandomDataGenerated(int v, int dataSize)
		{
			if (RandomDataGenerated != null)
			{
				RandomDataGenerated(v, dataSize);
			}
		}
	}
}
