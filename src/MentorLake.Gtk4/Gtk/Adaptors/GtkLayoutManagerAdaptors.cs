using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkLayoutManagerAdaptors
{
	public static GtkLayoutManagerHandle Measure(this GtkLayoutManagerHandle manager, GtkWidgetHandle widget, GtkOrientation orientation, int for_size, out int minimum, out int natural, out int minimum_baseline, out int natural_baseline)
	{
		GtkLayoutManagerExterns.gtk_layout_manager_measure(manager, widget, orientation, for_size, out minimum, out natural, out minimum_baseline, out natural_baseline);
		return manager;
	}

	public static GtkLayoutManagerHandle Allocate(this GtkLayoutManagerHandle manager, GtkWidgetHandle widget, int width, int height, int baseline)
	{
		GtkLayoutManagerExterns.gtk_layout_manager_allocate(manager, widget, width, height, baseline);
		return manager;
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

	public static GtkLayoutChildHandle GetLayoutChild(this GtkLayoutManagerHandle manager, GtkWidgetHandle child)
	{
		return GtkLayoutManagerExterns.gtk_layout_manager_get_layout_child(manager, child);
	}

	public static GtkLayoutManagerHandle GtkBoxLayoutNew(GtkOrientation orientation)
	{
		return GtkLayoutManagerExterns.gtk_box_layout_new(orientation);
	}

	public static GtkLayoutManagerHandle GtkCenterLayoutNew()
	{
		return GtkLayoutManagerExterns.gtk_center_layout_new();
	}

	public static GtkLayoutManagerHandle GtkConstraintLayoutNew()
	{
		return GtkLayoutManagerExterns.gtk_constraint_layout_new();
	}

	public static GtkLayoutManagerHandle GtkCustomLayoutNew(GtkCustomRequestModeFunc request_mode, GtkCustomMeasureFunc measure, GtkCustomAllocateFunc allocate)
	{
		return GtkLayoutManagerExterns.gtk_custom_layout_new(request_mode, measure, allocate);
	}

	public static GtkLayoutManagerHandle GtkFixedLayoutNew()
	{
		return GtkLayoutManagerExterns.gtk_fixed_layout_new();
	}

	public static GtkLayoutManagerHandle GtkGridLayoutNew()
	{
		return GtkLayoutManagerExterns.gtk_grid_layout_new();
	}

	public static GtkLayoutManagerHandle GtkOverlayLayoutNew()
	{
		return GtkLayoutManagerExterns.gtk_overlay_layout_new();
	}
}
