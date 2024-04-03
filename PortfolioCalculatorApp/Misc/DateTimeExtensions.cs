

namespace PortfolioCalculatorApp.Misc;

public static class DateTimeExtensions
{
	public static bool IsWeekday(this DateTime date)
	{
		return date.DayOfWeek != DayOfWeek.Sunday &&
			date.DayOfWeek != DayOfWeek.Saturday;
	}
}
