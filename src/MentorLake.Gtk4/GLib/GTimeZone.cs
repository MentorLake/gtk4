using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

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
}

public struct GTimeZone
{
}
