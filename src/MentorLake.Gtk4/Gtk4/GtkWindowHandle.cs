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

public class GtkWindowHandleHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkWindowHandleHandle New()
	{
		return GtkWindowHandleExterns.gtk_window_handle_new();
	}

}

public static class GtkWindowHandleHandleExtensions
{
	public static GtkWidgetHandle GetChild(this GtkWindowHandleHandle self)
	{
		return GtkWindowHandleExterns.gtk_window_handle_get_child(self);
	}

	public static GtkWindowHandleHandle SetChild(this GtkWindowHandleHandle self, GtkWidgetHandle child)
	{
		GtkWindowHandleExterns.gtk_window_handle_set_child(self, child);
		return self;
	}

}

internal class GtkWindowHandleExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWindowHandleHandle gtk_window_handle_new();
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_window_handle_get_child(GtkWindowHandleHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_handle_set_child(GtkWindowHandleHandle self, GtkWidgetHandle child);
}
