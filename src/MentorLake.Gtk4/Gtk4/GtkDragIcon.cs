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

public class GtkDragIconHandle : GtkWidgetHandle
{
}

public static class GtkDragIconSignals
{
}

public static class GtkDragIconHandleExtensions
{
	public static GtkWidgetHandle GetChild(this GtkDragIconHandle self)
	{
		return GtkDragIconExterns.gtk_drag_icon_get_child(self);
	}

	public static GtkDragIconHandle SetChild(this GtkDragIconHandle self, GtkWidgetHandle child)
	{
		GtkDragIconExterns.gtk_drag_icon_set_child(self, child);
		return self;
	}

}

internal class GtkDragIconExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_drag_icon_get_child(GtkDragIconHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drag_icon_set_child(GtkDragIconHandle self, GtkWidgetHandle child);
}
