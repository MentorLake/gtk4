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

public class GMarkupParseContextHandle : BaseSafeHandle
{
	public static GMarkupParseContextHandle New(GMarkupParserHandle parser, GMarkupParseFlags flags, IntPtr user_data, GDestroyNotify user_data_dnotify)
	{
		return GMarkupParseContextExterns.g_markup_parse_context_new(parser, flags, user_data, user_data_dnotify);
	}

}

internal class GMarkupParseContextExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GMarkupParseContextHandle g_markup_parse_context_new(GMarkupParserHandle parser, GMarkupParseFlags flags, IntPtr user_data, GDestroyNotify user_data_dnotify);

}

public struct GMarkupParseContext
{
}
