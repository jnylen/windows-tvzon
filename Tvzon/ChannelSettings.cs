using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tvzon
{
	public class ChannelSettings
	{

		public ChannelSettings()
		{
			Channels = new List<Channel>();
		}
		public List<Channel> Channels { get; set; }
	}


	public class Channel
	{
		public string ChannelId { get; set; }

		public TimeRange Monday { get; set; }

		public TimeRange Tuesday { get; set; }
		public TimeRange Wednesday { get; set; }
		public TimeRange Thursday { get; set; }
		public TimeRange Friday { get; set; }
		public TimeRange Saturday { get; set; }
		public TimeRange Sunday { get; set; }


		public TimeRange GetTimeRange(DateTime date)
		{
			switch (date.DayOfWeek)
			{
				case DayOfWeek.Monday:
					return Monday;
				case DayOfWeek.Tuesday:
					return Tuesday;
				case DayOfWeek.Wednesday:
					return Wednesday;
				case DayOfWeek.Thursday:
					return Thursday;
				case DayOfWeek.Friday:
					return Friday;
				case DayOfWeek.Saturday:
					return Saturday;
			}
			return Sunday;
		}

	}


	public class TimeRange
	{
		public TimeSpan Start { get; set; }
		public TimeSpan End { get; set; }
	}

	

}
