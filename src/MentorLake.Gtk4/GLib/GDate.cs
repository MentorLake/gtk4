namespace MentorLake.Gtk4.GLib;

public class GDateHandle : BaseSafeHandle
{
	public static GDateHandle New()
	{
		return GDateExterns.g_date_new();
	}

	public static GDateHandle NewDmy(GDateDay day, GDateMonth month, GDateYear year)
	{
		return GDateExterns.g_date_new_dmy(day, month, year);
	}

	public static GDateHandle NewJulian(uint julian_day)
	{
		return GDateExterns.g_date_new_julian(julian_day);
	}

}

internal class GDateExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GDateHandle g_date_new();

	[DllImport(Libraries.GLib)]
	internal static extern GDateHandle g_date_new_dmy(GDateDay day, GDateMonth month, GDateYear year);

	[DllImport(Libraries.GLib)]
	internal static extern GDateHandle g_date_new_julian(uint julian_day);

}

public struct GDate
{
	public uint julian_days;
	public uint julian;
	public uint dmy;
	public uint day;
	public uint month;
	public uint year;
}
