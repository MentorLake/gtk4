using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gtk4;

public class GtkLayoutManagerHandle : GObjectHandle
{
}

public static class GtkLayoutManagerHandleExtensions
{
	public static GtkLayoutManagerHandle Allocate(this GtkLayoutManagerHandle manager, GtkWidgetHandle widget, int width, int height, int baseline)
	{
		GtkLayoutManagerExterns.gtk_layout_manager_allocate(manager, widget, width, height, baseline);
		return manager;
	}

	public static GtkLayoutChildHandle GetLayoutChild(this GtkLayoutManagerHandle manager, GtkWidgetHandle child)
	{
		return GtkLayoutManagerExterns.gtk_layout_manager_get_layout_child(manager, child);
	}

	public static GtkSizeRequestMode GetRequestMode(this GtkLayoutManagerHandle manager)
	{
		return GtkLayoutManagerExterns.gtk_layout_manager_get_request_mode(manager);
	}

	public static GtkWidgetHandle GetWidget(this GtkLayoutManagerHandle manager)
	{
		return GtkLayoutManagerExterns.gtk_layout_manager_get_widget(manager);
	}

	public static GtkLayoutManagerHandle LayoutChanged(this GtkLayoutManagerHandle manager)
	{
		GtkLayoutManagerExterns.gtk_layout_manager_layout_changed(manager);
		return manager;
	}

	public static GtkLayoutManagerHandle Measure(this GtkLayoutManagerHandle manager, GtkWidgetHandle widget, GtkOrientation orientation, int for_size, out int minimum, out int natural, out int minimum_baseline, out int natural_baseline)
	{
		GtkLayoutManagerExterns.gtk_layout_manager_measure(manager, widget, orientation, for_size, out minimum, out natural, out minimum_baseline, out natural_baseline);
		return manager;
	}

}

internal class GtkLayoutManagerExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_layout_manager_allocate(GtkLayoutManagerHandle manager, GtkWidgetHandle widget, int width, int height, int baseline);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkLayoutChildHandle gtk_layout_manager_get_layout_child(GtkLayoutManagerHandle manager, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSizeRequestMode gtk_layout_manager_get_request_mode(GtkLayoutManagerHandle manager);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_layout_manager_get_widget(GtkLayoutManagerHandle manager);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_layout_manager_layout_changed(GtkLayoutManagerHandle manager);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_layout_manager_measure(GtkLayoutManagerHandle manager, GtkWidgetHandle widget, GtkOrientation orientation, int for_size, out int minimum, out int natural, out int minimum_baseline, out int natural_baseline);

}
