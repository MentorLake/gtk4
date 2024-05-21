namespace MentorLake.Gtk4.GLib;

public class GDateTimeHandle : BaseSafeHandle
{
	public static GDateTimeHandle New(GTimeZoneHandle tz, int year, int month, int day, int hour, int minute, double seconds)
	{
		return GDateTimeExterns.g_date_time_new(tz, year, month, day, hour, minute, seconds);
	}

	public static GDateTimeHandle NewFromIso8601(string text, GTimeZoneHandle default_tz)
	{
		return GDateTimeExterns.g_date_time_new_from_iso8601(text, default_tz);
	}

	public static GDateTimeHandle NewFromTimevalLocal(GTimeValHandle tv)
	{
		return GDateTimeExterns.g_date_time_new_from_timeval_local(tv);
	}

	public static GDateTimeHandle NewFromTimevalUtc(GTimeValHandle tv)
	{
		return GDateTimeExterns.g_date_time_new_from_timeval_utc(tv);
	}

	public static GDateTimeHandle NewFromUnixLocal(long t)
	{
		return GDateTimeExterns.g_date_time_new_from_unix_local(t);
	}

	public static GDateTimeHandle NewFromUnixLocalUsec(long usecs)
	{
		return GDateTimeExterns.g_date_time_new_from_unix_local_usec(usecs);
	}

	public static GDateTimeHandle NewFromUnixUtc(long t)
	{
		return GDateTimeExterns.g_date_time_new_from_unix_utc(t);
	}

	public static GDateTimeHandle NewFromUnixUtcUsec(long usecs)
	{
		return GDateTimeExterns.g_date_time_new_from_unix_utc_usec(usecs);
	}

	public static GDateTimeHandle NewLocal(int year, int month, int day, int hour, int minute, double seconds)
	{
		return GDateTimeExterns.g_date_time_new_local(year, month, day, hour, minute, seconds);
	}

	public static GDateTimeHandle NewNow(GTimeZoneHandle tz)
	{
		return GDateTimeExterns.g_date_time_new_now(tz);
	}

	public static GDateTimeHandle NewNowLocal()
	{
		return GDateTimeExterns.g_date_time_new_now_local();
	}

	public static GDateTimeHandle NewNowUtc()
	{
		return GDateTimeExterns.g_date_time_new_now_utc();
	}

	public static GDateTimeHandle NewUtc(int year, int month, int day, int hour, int minute, double seconds)
	{
		return GDateTimeExterns.g_date_time_new_utc(year, month, day, hour, minute, seconds);
	}

}


public static class GDateTimeHandleExtensions
{
	public static GDateTimeHandle Add(this GDateTimeHandle datetime, GTimeSpan timespan)
	{
		return GDateTimeExterns.g_date_time_add(datetime, timespan);
	}

	public static GDateTimeHandle AddDays(this GDateTimeHandle datetime, int days)
	{
		return GDateTimeExterns.g_date_time_add_days(datetime, days);
	}

	public static GDateTimeHandle AddFull(this GDateTimeHandle datetime, int years, int months, int days, int hours, int minutes, double seconds)
	{
		return GDateTimeExterns.g_date_time_add_full(datetime, years, months, days, hours, minutes, seconds);
	}

	public static GDateTimeHandle AddHours(this GDateTimeHandle datetime, int hours)
	{
		return GDateTimeExterns.g_date_time_add_hours(datetime, hours);
	}

	public static GDateTimeHandle AddMinutes(this GDateTimeHandle datetime, int minutes)
	{
		return GDateTimeExterns.g_date_time_add_minutes(datetime, minutes);
	}

	public static GDateTimeHandle AddMonths(this GDateTimeHandle datetime, int months)
	{
		return GDateTimeExterns.g_date_time_add_months(datetime, months);
	}

	public static GDateTimeHandle AddSeconds(this GDateTimeHandle datetime, double seconds)
	{
		return GDateTimeExterns.g_date_time_add_seconds(datetime, seconds);
	}

	public static GDateTimeHandle AddWeeks(this GDateTimeHandle datetime, int weeks)
	{
		return GDateTimeExterns.g_date_time_add_weeks(datetime, weeks);
	}

	public static GDateTimeHandle AddYears(this GDateTimeHandle datetime, int years)
	{
		return GDateTimeExterns.g_date_time_add_years(datetime, years);
	}

	public static int Compare(this IntPtr dt1, IntPtr dt2)
	{
		return GDateTimeExterns.g_date_time_compare(dt1, dt2);
	}

	public static GTimeSpan Difference(this GDateTimeHandle end, GDateTimeHandle begin)
	{
		return GDateTimeExterns.g_date_time_difference(end, begin);
	}

	public static bool Equal(this IntPtr dt1, IntPtr dt2)
	{
		return GDateTimeExterns.g_date_time_equal(dt1, dt2);
	}

	public static string Format(this GDateTimeHandle datetime, string format)
	{
		return GDateTimeExterns.g_date_time_format(datetime, format);
	}

	public static string FormatIso8601(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_format_iso8601(datetime);
	}

	public static int GetDayOfMonth(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_get_day_of_month(datetime);
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

	public static int GetMicrosecond(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_get_microsecond(datetime);
	}

	public static int GetMinute(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_get_minute(datetime);
	}

	public static int GetMonth(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_get_month(datetime);
	}

	public static int GetSecond(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_get_second(datetime);
	}

	public static double GetSeconds(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_get_seconds(datetime);
	}

	public static GTimeZoneHandle GetTimezone(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_get_timezone(datetime);
	}

	public static string GetTimezoneAbbreviation(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_get_timezone_abbreviation(datetime);
	}

	public static GTimeSpan GetUtcOffset(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_get_utc_offset(datetime);
	}

	public static int GetWeekNumberingYear(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_get_week_numbering_year(datetime);
	}

	public static int GetWeekOfYear(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_get_week_of_year(datetime);
	}

	public static int GetYear(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_get_year(datetime);
	}

	public static GDateTimeHandle GetYmd(this GDateTimeHandle datetime, out int year, out int month, out int day)
	{
		GDateTimeExterns.g_date_time_get_ymd(datetime, out year, out month, out day);
		return datetime;
	}

	public static uint Hash(this IntPtr datetime)
	{
		return GDateTimeExterns.g_date_time_hash(datetime);
	}

	public static bool IsDaylightSavings(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_is_daylight_savings(datetime);
	}

	public static GDateTimeHandle Ref(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_ref(datetime);
	}

	public static GDateTimeHandle ToLocal(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_to_local(datetime);
	}

	public static bool ToTimeval(this GDateTimeHandle datetime, GTimeValHandle tv)
	{
		return GDateTimeExterns.g_date_time_to_timeval(datetime, tv);
	}

	public static GDateTimeHandle ToTimezone(this GDateTimeHandle datetime, GTimeZoneHandle tz)
	{
		return GDateTimeExterns.g_date_time_to_timezone(datetime, tz);
	}

	public static long ToUnix(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_to_unix(datetime);
	}

	public static long ToUnixUsec(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_to_unix_usec(datetime);
	}

	public static GDateTimeHandle ToUtc(this GDateTimeHandle datetime)
	{
		return GDateTimeExterns.g_date_time_to_utc(datetime);
	}

	public static GDateTimeHandle Unref(this GDateTimeHandle datetime)
	{
		GDateTimeExterns.g_date_time_unref(datetime);
		return datetime;
	}

}
internal class GDateTimeExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GDateTimeHandle g_date_time_new(GTimeZoneHandle tz, int year, int month, int day, int hour, int minute, double seconds);

	[DllImport(Libraries.GLib)]
	internal static extern GDateTimeHandle g_date_time_new_from_iso8601(string text, GTimeZoneHandle default_tz);

	[DllImport(Libraries.GLib)]
	internal static extern GDateTimeHandle g_date_time_new_from_timeval_local(GTimeValHandle tv);

	[DllImport(Libraries.GLib)]
	internal static extern GDateTimeHandle g_date_time_new_from_timeval_utc(GTimeValHandle tv);

	[DllImport(Libraries.GLib)]
	internal static extern GDateTimeHandle g_date_time_new_from_unix_local(long t);

	[DllImport(Libraries.GLib)]
	internal static extern GDateTimeHandle g_date_time_new_from_unix_local_usec(long usecs);

	[DllImport(Libraries.GLib)]
	internal static extern GDateTimeHandle g_date_time_new_from_unix_utc(long t);

	[DllImport(Libraries.GLib)]
	internal static extern GDateTimeHandle g_date_time_new_from_unix_utc_usec(long usecs);

	[DllImport(Libraries.GLib)]
	internal static extern GDateTimeHandle g_date_time_new_local(int year, int month, int day, int hour, int minute, double seconds);

	[DllImport(Libraries.GLib)]
	internal static extern GDateTimeHandle g_date_time_new_now(GTimeZoneHandle tz);

	[DllImport(Libraries.GLib)]
	internal static extern GDateTimeHandle g_date_time_new_now_local();

	[DllImport(Libraries.GLib)]
	internal static extern GDateTimeHandle g_date_time_new_now_utc();

	[DllImport(Libraries.GLib)]
	internal static extern GDateTimeHandle g_date_time_new_utc(int year, int month, int day, int hour, int minute, double seconds);

	[DllImport(Libraries.GLib)]
	internal static extern GDateTimeHandle g_date_time_add(GDateTimeHandle datetime, GTimeSpan timespan);

	[DllImport(Libraries.GLib)]
	internal static extern GDateTimeHandle g_date_time_add_days(GDateTimeHandle datetime, int days);

	[DllImport(Libraries.GLib)]
	internal static extern GDateTimeHandle g_date_time_add_full(GDateTimeHandle datetime, int years, int months, int days, int hours, int minutes, double seconds);

	[DllImport(Libraries.GLib)]
	internal static extern GDateTimeHandle g_date_time_add_hours(GDateTimeHandle datetime, int hours);

	[DllImport(Libraries.GLib)]
	internal static extern GDateTimeHandle g_date_time_add_minutes(GDateTimeHandle datetime, int minutes);

	[DllImport(Libraries.GLib)]
	internal static extern GDateTimeHandle g_date_time_add_months(GDateTimeHandle datetime, int months);

	[DllImport(Libraries.GLib)]
	internal static extern GDateTimeHandle g_date_time_add_seconds(GDateTimeHandle datetime, double seconds);

	[DllImport(Libraries.GLib)]
	internal static extern GDateTimeHandle g_date_time_add_weeks(GDateTimeHandle datetime, int weeks);

	[DllImport(Libraries.GLib)]
	internal static extern GDateTimeHandle g_date_time_add_years(GDateTimeHandle datetime, int years);

	[DllImport(Libraries.GLib)]
	internal static extern int g_date_time_compare(IntPtr dt1, IntPtr dt2);

	[DllImport(Libraries.GLib)]
	internal static extern GTimeSpan g_date_time_difference(GDateTimeHandle end, GDateTimeHandle begin);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_date_time_equal(IntPtr dt1, IntPtr dt2);

	[DllImport(Libraries.GLib)]
	internal static extern string g_date_time_format(GDateTimeHandle datetime, string format);

	[DllImport(Libraries.GLib)]
	internal static extern string g_date_time_format_iso8601(GDateTimeHandle datetime);

	[DllImport(Libraries.GLib)]
	internal static extern int g_date_time_get_day_of_month(GDateTimeHandle datetime);

	[DllImport(Libraries.GLib)]
	internal static extern int g_date_time_get_day_of_week(GDateTimeHandle datetime);

	[DllImport(Libraries.GLib)]
	internal static extern int g_date_time_get_day_of_year(GDateTimeHandle datetime);

	[DllImport(Libraries.GLib)]
	internal static extern int g_date_time_get_hour(GDateTimeHandle datetime);

	[DllImport(Libraries.GLib)]
	internal static extern int g_date_time_get_microsecond(GDateTimeHandle datetime);

	[DllImport(Libraries.GLib)]
	internal static extern int g_date_time_get_minute(GDateTimeHandle datetime);

	[DllImport(Libraries.GLib)]
	internal static extern int g_date_time_get_month(GDateTimeHandle datetime);

	[DllImport(Libraries.GLib)]
	internal static extern int g_date_time_get_second(GDateTimeHandle datetime);

	[DllImport(Libraries.GLib)]
	internal static extern double g_date_time_get_seconds(GDateTimeHandle datetime);

	[DllImport(Libraries.GLib)]
	internal static extern GTimeZoneHandle g_date_time_get_timezone(GDateTimeHandle datetime);

	[DllImport(Libraries.GLib)]
	internal static extern string g_date_time_get_timezone_abbreviation(GDateTimeHandle datetime);

	[DllImport(Libraries.GLib)]
	internal static extern GTimeSpan g_date_time_get_utc_offset(GDateTimeHandle datetime);

	[DllImport(Libraries.GLib)]
	internal static extern int g_date_time_get_week_numbering_year(GDateTimeHandle datetime);

	[DllImport(Libraries.GLib)]
	internal static extern int g_date_time_get_week_of_year(GDateTimeHandle datetime);

	[DllImport(Libraries.GLib)]
	internal static extern int g_date_time_get_year(GDateTimeHandle datetime);

	[DllImport(Libraries.GLib)]
	internal static extern void g_date_time_get_ymd(GDateTimeHandle datetime, out int year, out int month, out int day);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_date_time_hash(IntPtr datetime);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_date_time_is_daylight_savings(GDateTimeHandle datetime);

	[DllImport(Libraries.GLib)]
	internal static extern GDateTimeHandle g_date_time_ref(GDateTimeHandle datetime);

	[DllImport(Libraries.GLib)]
	internal static extern GDateTimeHandle g_date_time_to_local(GDateTimeHandle datetime);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_date_time_to_timeval(GDateTimeHandle datetime, GTimeValHandle tv);

	[DllImport(Libraries.GLib)]
	internal static extern GDateTimeHandle g_date_time_to_timezone(GDateTimeHandle datetime, GTimeZoneHandle tz);

	[DllImport(Libraries.GLib)]
	internal static extern long g_date_time_to_unix(GDateTimeHandle datetime);

	[DllImport(Libraries.GLib)]
	internal static extern long g_date_time_to_unix_usec(GDateTimeHandle datetime);

	[DllImport(Libraries.GLib)]
	internal static extern GDateTimeHandle g_date_time_to_utc(GDateTimeHandle datetime);

	[DllImport(Libraries.GLib)]
	internal static extern void g_date_time_unref(GDateTimeHandle datetime);

}

public struct GDateTime
{
}
