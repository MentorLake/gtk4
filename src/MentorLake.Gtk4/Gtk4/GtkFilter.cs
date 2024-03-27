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

public class GtkFilterHandle : GObjectHandle
{
}

public class GtkFilterSignal
{
	public string Value { get; set; }
	public GtkFilterSignal(string value) => Value = value;
}

public static class GtkFilterSignals
{
	public static GtkFilterSignal Changed = new("changed");
}

public static class GtkFilterHandleExtensions
{
	public static GtkFilterHandle Changed(this GtkFilterHandle self, GtkFilterChange change)
	{
		GtkFilterExterns.gtk_filter_changed(self, change);
		return self;
	}

	public static GtkFilterMatch GetStrictness(this GtkFilterHandle self)
	{
		return GtkFilterExterns.gtk_filter_get_strictness(self);
	}

	public static bool Match(this GtkFilterHandle self, GObjectHandle item)
	{
		return GtkFilterExterns.gtk_filter_match(self, item);
	}

	public static GtkFilterHandle Connect(this GtkFilterHandle instance, GtkFilterSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkFilterExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_filter_changed(GtkFilterHandle self, GtkFilterChange change);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFilterMatch gtk_filter_get_strictness(GtkFilterHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_filter_match(GtkFilterHandle self, GObjectHandle item);
}
