using System;
using System.Collections.Generic;
using System.Text;

namespace CWConsoleApp17_01
{
	public enum WorkType
	{
		Work,
		DoNothing
	}

	public delegate void WorkPerformerEventHandler(
		int hours, WorkType workType);

	public class Worker

	{
		public event WorkPerformerEventHandler WorkPerformed;

		public event EventHandler WorkCompleted;

		public void DoWork(int hours, WorkType workType)
		{
			for (int i = 0; i < hours; i++)
			{
				//if (WorkPerformed)  //1 способ
				//	WorkPerformed(i + 1, workType);

				//WorkPerformed?.Invoke(i + 1, workType); // 2 способ 

				//var del = (WorkPerformed as WorkPerformerEventHandler); // 3 способ
				//if (del != null)
				//	del.Invoke(i + 1, workType);

				//(WorkPerformed as WorkPerformerEventHandler)?.Invoke(i + 1, workType); // 4 способ

				OnWorkPerformed(i + 1, workType);

			}

			OnWorkCompleted(this, EventArgs.Empty);
		}

		protected virtual void OnWorkPerformed(int data, WorkType workType)
		{
			(WorkPerformed as WorkPerformerEventHandler)?.Invoke(data, workType);
		}

		protected virtual void OnWorkCompleted(object sender, EventArgs e)
		{
			WorkCompleted?.Invoke(this, EventArgs.Empty);
		}
	}
}
