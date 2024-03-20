using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gsk;

namespace MentorLake.Gtk4.Gtk;
public static class GtkFixedAdaptors
{
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

	public static GtkFixedHandle Move(this GtkFixedHandle @fixed, GtkWidgetHandle widget, double x, double y)
	{
		GtkFixedExterns.gtk_fixed_move(@fixed, widget, x, y);
		return @fixed;
	}

	public static GtkFixedHandle GetChildPosition(this GtkFixedHandle @fixed, GtkWidgetHandle widget, out double x, out double y)
	{
		GtkFixedExterns.gtk_fixed_get_child_position(@fixed, widget, out x, out y);
		return @fixed;
	}

	public static GtkFixedHandle SetChildTransform(this GtkFixedHandle @fixed, GtkWidgetHandle widget, GskTransformHandle transform)
	{
		GtkFixedExterns.gtk_fixed_set_child_transform(@fixed, widget, transform);
		return @fixed;
	}

	public static GskTransformHandle GetChildTransform(this GtkFixedHandle @fixed, GtkWidgetHandle widget)
	{
		return GtkFixedExterns.gtk_fixed_get_child_transform(@fixed, widget);
	}
}
