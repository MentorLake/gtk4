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

}

public struct GDateTime
{
}
