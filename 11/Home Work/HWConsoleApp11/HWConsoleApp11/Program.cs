using System;
using System.Threading;

namespace HWConsoleApp11_Reminder
{
	class Program
	{
		static void Main(string[] args)
		{

			ReminderItem reminder1 = new ReminderItem();
			reminder1.AlarmDate = DateTimeOffset.Parse("2019-04-01 18:30");
			reminder1.AlarmMessage = "Lesson 12 Nordic It School";
			reminder1.WriteProperties();

			ReminderItem reminder2 = new ReminderItem();
			reminder2.AlarmDate = DateTimeOffset.Parse("2019-04-02 07:00");
			reminder2.AlarmMessage = "Getting to work";
			reminder2.WriteProperties();

		}
	}
}
