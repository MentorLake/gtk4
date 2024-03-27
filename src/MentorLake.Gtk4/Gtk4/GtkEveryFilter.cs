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

namespace MentorLake.Gtk4.Gtk4;

public class GtkEveryFilterHandle : GtkMultiFilterHandle
{
	public static GtkEveryFilterHandle New()
	{
		return GtkEveryFilterExterns.gtk_every_filter_new();
	}
}

public static class GtkEveryFilterSignals
{
}

public static class GtkEveryFilterHandleExtensions
{
}

internal class GtkEveryFilterExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkEveryFilterHandle gtk_every_filter_new();
}