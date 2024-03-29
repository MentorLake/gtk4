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

public class GtkMultiFilterHandle : GtkFilterHandle
{
}

public static class GtkMultiFilterHandleExtensions
{
	public static GtkMultiFilterHandle Append(this GtkMultiFilterHandle self, GtkFilterHandle filter)
	{
		GtkMultiFilterExterns.gtk_multi_filter_append(self, filter);
		return self;
	}

	public static GtkMultiFilterHandle Remove(this GtkMultiFilterHandle self, uint position)
	{
		GtkMultiFilterExterns.gtk_multi_filter_remove(self, position);
		return self;
	}

}

internal class GtkMultiFilterExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_multi_filter_append(GtkMultiFilterHandle self, GtkFilterHandle filter);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_multi_filter_remove(GtkMultiFilterHandle self, uint position);
}
