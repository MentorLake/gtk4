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

	public static GtkWidgetHandle CreateWidgetForValue(this GValueHandle value)
	{
		return GtkDragIconExterns.gtk_drag_icon_create_widget_for_value(value);
	}

	public static GtkWidgetHandle GetForDrag(this GdkDragHandle drag)
	{
		return GtkDragIconExterns.gtk_drag_icon_get_for_drag(drag);
	}

	public static GtkDragIconHandle SetFromPaintable(this GtkDragIconHandle @handle, GdkDragHandle drag, GdkPaintableHandle paintable, int hot_x, int hot_y)
	{
		GtkDragIconExterns.gtk_drag_icon_set_from_paintable(drag, paintable, hot_x, hot_y);
		return @handle;
	}

}

internal class GtkDragIconExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_drag_icon_get_child(GtkDragIconHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drag_icon_set_child(GtkDragIconHandle self, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_drag_icon_create_widget_for_value(GValueHandle value);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_drag_icon_get_for_drag(GdkDragHandle drag);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drag_icon_set_from_paintable(GdkDragHandle drag, GdkPaintableHandle paintable, int hot_x, int hot_y);
}
