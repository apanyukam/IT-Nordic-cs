﻿using System;

class ReminderItem
{
	public DateTimeOffset AlarmDate { get; set; }
	public string AlarmMessage { get; set; }

	public TimeSpan TimeToAlarm
	{
		get
		{
			return AlarmDate.Subtract(DateTimeOffset.UtcNow);
		}
	}

	public bool IsOutdated
	{
		get
		{
			return TimeToAlarm < TimeSpan.Zero ? true : false;
		}
	}

	//public ReminderItem(DateTimeOffset alarmDate, string alarmMessage)
	//{
	//	AlarmDate = alarmDate;
	//	AlarmMessage = alarmMessage;
	//}

	public void WriteProperties()
	{
		Console.WriteLine(
			$"{nameof(AlarmDate)}:{AlarmDate}\n" +
			$"{nameof(AlarmMessage)}: {AlarmMessage}\n" +
			$"{nameof(TimeToAlarm)}: {TimeToAlarm}\n" +
			$"{nameof(IsOutdated)}: {IsOutdated}\n");
	}
}

