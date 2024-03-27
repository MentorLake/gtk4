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

public class GDesktopAppInfoLookupHandle  : GObjectHandle
{
}

public static class GDesktopAppInfoLookupHandleExtensions
{
	public static GAppInfoHandle GetDefaultForUriScheme(this GDesktopAppInfoLookupHandle lookup, string uri_scheme)
	{
		return GDesktopAppInfoLookupExterns.g_desktop_app_info_lookup_get_default_for_uri_scheme(lookup, uri_scheme);
	}

}

internal class GDesktopAppInfoLookupExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GAppInfoHandle g_desktop_app_info_lookup_get_default_for_uri_scheme(GDesktopAppInfoLookupHandle lookup, string uri_scheme);
}
