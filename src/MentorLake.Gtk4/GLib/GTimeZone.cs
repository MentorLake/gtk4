namespace MentorLake.Gtk4.GLib;

public class GTimeZoneHandle : BaseSafeHandle
{
	public static GTimeZoneHandle New(string identifier)
	{
		return GTimeZoneExterns.g_time_zone_new(identifier);
	}

	public static GTimeZoneHandle NewIdentifier(string identifier)
	{
		return GTimeZoneExterns.g_time_zone_new_identifier(identifier);
	}

	public static GTimeZoneHandle NewLocal()
	{
		return GTimeZoneExterns.g_time_zone_new_local();
	}

	public static GTimeZoneHandle NewOffset(int seconds)
	{
		return GTimeZoneExterns.g_time_zone_new_offset(seconds);
	}

	public static GTimeZoneHandle NewUtc()
	{
		return GTimeZoneExterns.g_time_zone_new_utc();
	}

}


public static class GTimeZoneHandleExtensions
{
	public static int AdjustTime(this GTimeZoneHandle tz, GTimeType type, ref long time_)
	{
		return GTimeZoneExterns.g_time_zone_adjust_time(tz, type, ref time_);
	}

	public static int FindInterval(this GTimeZoneHandle tz, GTimeType type, long time_)
	{
		return GTimeZoneExterns.g_time_zone_find_interval(tz, type, time_);
	}

	public static string GetAbbreviation(this GTimeZoneHandle tz, int interval)
	{
		return GTimeZoneExterns.g_time_zone_get_abbreviation(tz, interval);
	}

	public static string GetIdentifier(this GTimeZoneHandle tz)
	{
		return GTimeZoneExterns.g_time_zone_get_identifier(tz);
	}

	public static int GetOffset(this GTimeZoneHandle tz, int interval)
	{
		return GTimeZoneExterns.g_time_zone_get_offset(tz, interval);
	}

	public static bool IsDst(this GTimeZoneHandle tz, int interval)
	{
		return GTimeZoneExterns.g_time_zone_is_dst(tz, interval);
	}

	public static GTimeZoneHandle Ref(this GTimeZoneHandle tz)
	{
		return GTimeZoneExterns.g_time_zone_ref(tz);
	}

	public static GTimeZoneHandle Unref(this GTimeZoneHandle tz)
	{
		GTimeZoneExterns.g_time_zone_unref(tz);
		return tz;
	}

}
internal class GTimeZoneExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GTimeZoneHandle g_time_zone_new(string identifier);

	[DllImport(Libraries.GLib)]
	internal static extern GTimeZoneHandle g_time_zone_new_identifier(string identifier);

	[DllImport(Libraries.GLib)]
	internal static extern GTimeZoneHandle g_time_zone_new_local();

	[DllImport(Libraries.GLib)]
	internal static extern GTimeZoneHandle g_time_zone_new_offset(int seconds);

	[DllImport(Libraries.GLib)]
	internal static extern GTimeZoneHandle g_time_zone_new_utc();

	[DllImport(Libraries.GLib)]
	internal static extern int g_time_zone_adjust_time(GTimeZoneHandle tz, GTimeType type, ref long time_);

	[DllImport(Libraries.GLib)]
	internal static extern int g_time_zone_find_interval(GTimeZoneHandle tz, GTimeType type, long time_);

	[DllImport(Libraries.GLib)]
	internal static extern string g_time_zone_get_abbreviation(GTimeZoneHandle tz, int interval);

	[DllImport(Libraries.GLib)]
	internal static extern string g_time_zone_get_identifier(GTimeZoneHandle tz);

	[DllImport(Libraries.GLib)]
	internal static extern int g_time_zone_get_offset(GTimeZoneHandle tz, int interval);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_time_zone_is_dst(GTimeZoneHandle tz, int interval);

	[DllImport(Libraries.GLib)]
	internal static extern GTimeZoneHandle g_time_zone_ref(GTimeZoneHandle tz);

	[DllImport(Libraries.GLib)]
	internal static extern void g_time_zone_unref(GTimeZoneHandle tz);

}

public struct GTimeZone
{
}
