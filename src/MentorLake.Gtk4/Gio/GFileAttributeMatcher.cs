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

public class GFileAttributeMatcherHandle : BaseSafeHandle
{
	public static GFileAttributeMatcherHandle New(string attributes)
	{
		return GFileAttributeMatcherExterns.g_file_attribute_matcher_new(attributes);
	}

}

internal class GFileAttributeMatcherExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GFileAttributeMatcherHandle g_file_attribute_matcher_new(string attributes);

}

public struct GFileAttributeMatcher
{
}
