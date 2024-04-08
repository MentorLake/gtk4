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

namespace MentorLake.Gtk4.Gio;

public class GThemedIconHandle : GObjectHandle, GIconHandle
{
	public static GThemedIconHandle New(string iconname)
	{
		return GThemedIconExterns.g_themed_icon_new(iconname);
	}

	public static GThemedIconHandle NewFromNames(string[] iconnames, int len)
	{
		return GThemedIconExterns.g_themed_icon_new_from_names(iconnames, len);
	}

	public static GThemedIconHandle NewWithDefaultFallbacks(string iconname)
	{
		return GThemedIconExterns.g_themed_icon_new_with_default_fallbacks(iconname);
	}

}

public static class GThemedIconHandleExtensions
{
	public static GThemedIconHandle AppendName(this GThemedIconHandle icon, string iconname)
	{
		GThemedIconExterns.g_themed_icon_append_name(icon, iconname);
		return icon;
	}

	public static string GetNames(this GThemedIconHandle icon)
	{
		return GThemedIconExterns.g_themed_icon_get_names(icon);
	}

	public static GThemedIconHandle PrependName(this GThemedIconHandle icon, string iconname)
	{
		GThemedIconExterns.g_themed_icon_prepend_name(icon, iconname);
		return icon;
	}

}

internal class GThemedIconExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GThemedIconHandle g_themed_icon_new(string iconname);
	[DllImport(Libraries.Gio)]
	internal static extern GThemedIconHandle g_themed_icon_new_from_names(string[] iconnames, int len);
	[DllImport(Libraries.Gio)]
	internal static extern GThemedIconHandle g_themed_icon_new_with_default_fallbacks(string iconname);
	[DllImport(Libraries.Gio)]
	internal static extern void g_themed_icon_append_name(GThemedIconHandle icon, string iconname);
	[DllImport(Libraries.Gio)]
	internal static extern string g_themed_icon_get_names(GThemedIconHandle icon);
	[DllImport(Libraries.Gio)]
	internal static extern void g_themed_icon_prepend_name(GThemedIconHandle icon, string iconname);
}
