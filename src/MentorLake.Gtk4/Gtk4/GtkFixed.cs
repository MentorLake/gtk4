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

public class GtkFixedHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkFixedHandle New()
	{
		return GtkFixedExterns.gtk_fixed_new();
	}

}

public static class GtkFixedHandleExtensions
{
	public static GtkFixedHandle GetChildPosition(this GtkFixedHandle @fixed, GtkWidgetHandle widget, out double x, out double y)
	{
		GtkFixedExterns.gtk_fixed_get_child_position(@fixed, widget, out x, out y);
		return @fixed;
	}

	public static GskTransformHandle GetChildTransform(this GtkFixedHandle @fixed, GtkWidgetHandle widget)
	{
		return GtkFixedExterns.gtk_fixed_get_child_transform(@fixed, widget);
	}

	public static GtkFixedHandle Move(this GtkFixedHandle @fixed, GtkWidgetHandle widget, double x, double y)
	{
		GtkFixedExterns.gtk_fixed_move(@fixed, widget, x, y);
		return @fixed;
	}

	public static GtkFixedHandle Put(this GtkFixedHandle @fixed, GtkWidgetHandle widget, double x, double y)
	{
		GtkFixedExterns.gtk_fixed_put(@fixed, widget, x, y);
		return @fixed;
	}

	public static GtkFixedHandle Remove(this GtkFixedHandle @fixed, GtkWidgetHandle widget)
	{
		GtkFixedExterns.gtk_fixed_remove(@fixed, widget);
		return @fixed;
	}

	public static GtkFixedHandle SetChildTransform(this GtkFixedHandle @fixed, GtkWidgetHandle widget, GskTransformHandle transform)
	{
		GtkFixedExterns.gtk_fixed_set_child_transform(@fixed, widget, transform);
		return @fixed;
	}

}

internal class GtkFixedExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFixedHandle gtk_fixed_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_fixed_get_child_position(GtkFixedHandle @fixed, GtkWidgetHandle widget, out double x, out double y);

	[DllImport(Libraries.Gtk4)]
	internal static extern GskTransformHandle gtk_fixed_get_child_transform(GtkFixedHandle @fixed, GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_fixed_move(GtkFixedHandle @fixed, GtkWidgetHandle widget, double x, double y);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_fixed_put(GtkFixedHandle @fixed, GtkWidgetHandle widget, double x, double y);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_fixed_remove(GtkFixedHandle @fixed, GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_fixed_set_child_transform(GtkFixedHandle @fixed, GtkWidgetHandle widget, GskTransformHandle transform);

}
