using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GTimeZoneAdaptors
{
	public static GTimeZoneHandle Ref(this GTimeZoneHandle tz)
	{
		return GTimeZoneExterns.g_time_zone_ref(tz);
	}

	public static GTimeZoneHandle Unref(this GTimeZoneHandle tz)
	{
		GTimeZoneExterns.g_time_zone_unref(tz);
		return tz;
	}

	public static int FindInterval(this GTimeZoneHandle tz, GTimeType type, nint time_)
	{
		return GTimeZoneExterns.g_time_zone_find_interval(tz, type, time_);
	}

	public static int AdjustTime(this GTimeZoneHandle tz, GTimeType type, ref nint time_)
	{
		return GTimeZoneExterns.g_time_zone_adjust_time(tz, type, ref time_);
	}

	public static string GetAbbreviation(this GTimeZoneHandle tz, int interval)
	{
		return GTimeZoneExterns.g_time_zone_get_abbreviation(tz, interval);
	}

	public static int GetOffset(this GTimeZoneHandle tz, int interval)
	{
		return GTimeZoneExterns.g_time_zone_get_offset(tz, interval);
	}

	public static int IsDst(this GTimeZoneHandle tz, int interval)
	{
		return GTimeZoneExterns.g_time_zone_is_dst(tz, interval);
	}

	public static string GetIdentifier(this GTimeZoneHandle tz)
	{
		return GTimeZoneExterns.g_time_zone_get_identifier(tz);
	}

	public static GDateTimeHandle GDateTimeNewNow(this GTimeZoneHandle tz)
	{
		return GTimeZoneExterns.g_date_time_new_now(tz);
	}

	public static GDateTimeHandle GDateTimeNew(this GTimeZoneHandle tz, int year, int month, int day, int hour, int minute, double seconds)
	{
		return GTimeZoneExterns.g_date_time_new(tz, year, month, day, hour, minute, seconds);
	}

	public static GTimeZoneHandle NewIdentifier(string identifier)
	{
		return GTimeZoneExterns.g_time_zone_new_identifier(identifier);
	}

	public static GTimeZoneHandle NewUtc()
	{
		return GTimeZoneExterns.g_time_zone_new_utc();
	}

	public static GTimeZoneHandle NewLocal()
	{
		return GTimeZoneExterns.g_time_zone_new_local();
	}

	public static GTimeZoneHandle NewOffset(int seconds)
	{
		return GTimeZoneExterns.g_time_zone_new_offset(seconds);
	}
}
