using System;
using System.Collections.Generic;
using System.Text;

namespace HWConsoleApp13
{
	class FileLogWriter : ILogWriter
	{
		
		void ILogWriter.LogError(string message)
		{
			throw new NotImplementedException();
		}

		void ILogWriter.LogInfo(string message)
		{
			throw new NotImplementedException();
		}

		void ILogWriter.LogWarning(string message)
		{
			throw new NotImplementedException();
		}
	}
}
