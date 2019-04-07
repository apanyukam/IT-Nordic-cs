using System;
using System.Collections.Generic;
using System.Text;

namespace HWConsoleApp13
{
	class MultipleLogWriter : ILogWriter
	{
		public void LogError(string message)
		{
			throw new NotImplementedException();
		}

		public void LogInfo(string message)
		{
			throw new NotImplementedException();
		}

		public void LogWarning(string message)
		{
			throw new NotImplementedException();
		}
	}
}
