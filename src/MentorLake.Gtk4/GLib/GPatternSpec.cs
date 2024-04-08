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

public class GPatternSpecHandle : BaseSafeHandle
{
	public static GPatternSpecHandle New(string pattern)
	{
		return GPatternSpecExterns.g_pattern_spec_new(pattern);
	}

}

internal class GPatternSpecExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GPatternSpecHandle g_pattern_spec_new(string pattern);
}

public struct GPatternSpec
{
}
