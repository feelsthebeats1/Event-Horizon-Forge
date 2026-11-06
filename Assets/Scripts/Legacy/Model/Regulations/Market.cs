using System;

namespace Model
{
	namespace Regulations
	{
		// Stock renewal lives in MarketSettings as minutes. The shop reads -1 as
		// "this stock never refills".
		public static class Market
		{
			public static long RenewalTicks(double minutes) => minutes < 0 ? -1L : TimeSpan.FromMinutes(minutes).Ticks;
		}
	}
}
