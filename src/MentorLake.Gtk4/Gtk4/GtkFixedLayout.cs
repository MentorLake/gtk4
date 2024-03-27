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

public class GtkFixedLayoutHandle : GtkLayoutManagerHandle
{
	public static GtkFixedLayoutHandle New()
	{
		return GtkFixedLayoutExterns.gtk_fixed_layout_new();
	}
}

public static class GtkFixedLayoutSignals
{
}

public static class GtkFixedLayoutHandleExtensions
{
}

internal class GtkFixedLayoutExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFixedLayoutHandle gtk_fixed_layout_new();
}
