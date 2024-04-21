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

public interface GtkOrientableHandle
{
}

public static class GtkOrientableHandleExtensions
{
	public static GtkOrientation GetOrientation(this GtkOrientableHandle orientable)
	{
		return GtkOrientableExterns.gtk_orientable_get_orientation(orientable);
	}

	public static GtkOrientableHandle SetOrientation(this GtkOrientableHandle orientable, GtkOrientation orientation)
	{
		GtkOrientableExterns.gtk_orientable_set_orientation(orientable, orientation);
		return orientable;
	}

}

internal class GtkOrientableExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkOrientation gtk_orientable_get_orientation(GtkOrientableHandle orientable);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_orientable_set_orientation(GtkOrientableHandle orientable, GtkOrientation orientation);

}
