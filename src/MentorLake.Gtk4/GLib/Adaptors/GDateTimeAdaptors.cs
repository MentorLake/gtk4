using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GDateTimeAdaptors
{
	public static GDateTimeHandle Unref(this GDateTimeHandle datetime)
	{
		GDateTimeExterns.g_date_time_unref(datetime);
		return datetime;
	}

	public static GDateTimeHandle Ref(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_ref(datetime);
	}

	public static GDateTimeHandle Add(this GDateTimeHandle datetime, GTimeSpan timespan)
	{
		return GDateTimeExterns.g_date_time_add(datetime, timespan);
	}

	public static GDateTimeHandle AddYears(this GDateTimeHandle datetime, int years)
	{
		return GDateTimeExterns.g_date_time_add_years(datetime, years);
	}

	public static GDateTimeHandle AddMonths(this GDateTimeHandle datetime, int months)
	{
		return GDateTimeExterns.g_date_time_add_months(datetime, months);
	}

	public static GDateTimeHandle AddWeeks(this GDateTimeHandle datetime, int weeks)
	{
		return GDateTimeExterns.g_date_time_add_weeks(datetime, weeks);
	}

	public static GDateTimeHandle AddDays(this GDateTimeHandle datetime, int days)
	{
		return GDateTimeExterns.g_date_time_add_days(datetime, days);
	}

	public static GDateTimeHandle AddHours(this GDateTimeHandle datetime, int hours)
	{
		return GDateTimeExterns.g_date_time_add_hours(datetime, hours);
	}

	public static GDateTimeHandle AddMinutes(this GDateTimeHandle datetime, int minutes)
	{
		return GDateTimeExterns.g_date_time_add_minutes(datetime, minutes);
	}

	public static GDateTimeHandle AddSeconds(this GDateTimeHandle datetime, double seconds)
	{
		return GDateTimeExterns.g_date_time_add_seconds(datetime, seconds);
	}

	public static GDateTimeHandle AddFull(this GDateTimeHandle datetime, int years, int months, int days, int hours, int minutes, double seconds)
	{
		return GDateTimeExterns.g_date_time_add_full(datetime, years, months, days, hours, minutes, seconds);
	}

	public static GTimeSpan Difference(this GDateTimeHandle end, GDateTimeHandle begin)
	{
		return GDateTimeExterns.g_date_time_difference(end, begin);
	}

	public static GDateTimeHandle GetYmd(this GDateTimeHandle datetime, out int year, out int month, out int day)
	{
		GDateTimeExterns.g_date_time_get_ymd(datetime, out year, out month, out day);
		return datetime;
	}

	public static int GetYear(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_get_year(datetime);
	}

	public static int GetMonth(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_get_month(datetime);
	}

	public static int GetDayOfMonth(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_get_day_of_month(datetime);
	}

	public static int GetWeekNumberingYear(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_get_week_numbering_year(datetime);
	}

	public static int GetWeekOfYear(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_get_week_of_year(datetime);
	}

	public static int GetDayOfWeek(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_get_day_of_week(datetime);
	}

	public static int GetDayOfYear(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_get_day_of_year(datetime);
	}

	public static int GetHour(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_get_hour(datetime);
	}

	public static int GetMinute(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_get_minute(datetime);
	}

	public static int GetSecond(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_get_second(datetime);
	}

	public static int GetMicrosecond(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_get_microsecond(datetime);
	}

	public static double GetSeconds(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_get_seconds(datetime);
	}

	public static nint ToUnix(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_to_unix(datetime);
	}

	public static int ToTimeval(this GDateTimeHandle datetime, GTimeValHandle tv)
	{
		return GDateTimeExterns.g_date_time_to_timeval(datetime, tv);
	}

	public static GTimeSpan GetUtcOffset(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_get_utc_offset(datetime);
	}

	public static GTimeZoneHandle GetTimezone(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_get_timezone(datetime);
	}

	public static string GetTimezoneAbbreviation(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_get_timezone_abbreviation(datetime);
	}

	public static int IsDaylightSavings(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_is_daylight_savings(datetime);
	}

	public static GDateTimeHandle ToTimezone(this GDateTimeHandle datetime, GTimeZoneHandle tz)
	{
		return GDateTimeExterns.g_date_time_to_timezone(datetime, tz);
	}

	public static GDateTimeHandle ToLocal(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_to_local(datetime);
	}

	public static GDateTimeHandle ToUtc(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_to_utc(datetime);
	}

	public static string Format(this GDateTimeHandle datetime, string format)
	{
		return GDateTimeExterns.g_date_time_format(datetime, format);
	}

	public static string FormatIso8601(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_format_iso8601(datetime);
	}

	public static GDateTimeHandle NewNowUtc()
	{
		return GDateTimeExterns.g_date_time_new_now_utc();
	}

	public static GDateTimeHandle NewFromUnixLocal(nint t)
	{
		return GDateTimeExterns.g_date_time_new_from_unix_local(t);
	}

	public static GDateTimeHandle NewFromUnixUtc(nint t)
	{
		return GDateTimeExterns.g_date_time_new_from_unix_utc(t);
	}

	public static GDateTimeHandle NewFromTimevalLocal(GTimeValHandle tv)
	{
		return GDateTimeExterns.g_date_time_new_from_timeval_local(tv);
	}

	public static GDateTimeHandle NewFromTimevalUtc(GTimeValHandle tv)
	{
		return GDateTimeExterns.g_date_time_new_from_timeval_utc(tv);
	}

	public static GDateTimeHandle NewFromIso8601(string text, GTimeZoneHandle default_tz)
	{
		return GDateTimeExterns.g_date_time_new_from_iso8601(text, default_tz);
	}

	public static GDateTimeHandle NewLocal(int year, int month, int day, int hour, int minute, double seconds)
	{
		return GDateTimeExterns.g_date_time_new_local(year, month, day, hour, minute, seconds);
	}

	public static GDateTimeHandle NewUtc(int year, int month, int day, int hour, int minute, double seconds)
	{
		return GDateTimeExterns.g_date_time_new_utc(year, month, day, hour, minute, seconds);
	}
}
