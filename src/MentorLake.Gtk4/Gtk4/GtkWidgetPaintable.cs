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

public class GtkWidgetPaintableHandle : GObjectHandle
{
	public static GtkWidgetPaintableHandle New(GtkWidgetHandle widget)
	{
		return GtkWidgetPaintableExterns.gtk_widget_paintable_new(widget);
	}

}

public static class GtkWidgetPaintableHandleExtensions
{
	public static GtkWidgetHandle GetWidget(this GtkWidgetPaintableHandle self)
	{
		return GtkWidgetPaintableExterns.gtk_widget_paintable_get_widget(self);
	}

	public static GtkWidgetPaintableHandle SetWidget(this GtkWidgetPaintableHandle self, GtkWidgetHandle widget)
	{
		GtkWidgetPaintableExterns.gtk_widget_paintable_set_widget(self, widget);
		return self;
	}

}

internal class GtkWidgetPaintableExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetPaintableHandle gtk_widget_paintable_new(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_widget_paintable_get_widget(GtkWidgetPaintableHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_paintable_set_widget(GtkWidgetPaintableHandle self, GtkWidgetHandle widget);
}
