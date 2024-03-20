using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkScrolledWindowAdaptors
{
	public static GtkScrolledWindowHandle SetHadjustment(this GtkScrolledWindowHandle scrolled_window, GtkAdjustmentHandle hadjustment)
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_hadjustment(scrolled_window, hadjustment);
		return scrolled_window;
	}

	public static GtkScrolledWindowHandle SetVadjustment(this GtkScrolledWindowHandle scrolled_window, GtkAdjustmentHandle vadjustment)
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_vadjustment(scrolled_window, vadjustment);
		return scrolled_window;
	}

	public static GtkAdjustmentHandle GetHadjustment(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_hadjustment(scrolled_window);
	}

	public static GtkAdjustmentHandle GetVadjustment(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_vadjustment(scrolled_window);
	}

	public static GtkWidgetHandle GetHscrollbar(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_hscrollbar(scrolled_window);
	}

	public static GtkWidgetHandle GetVscrollbar(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_vscrollbar(scrolled_window);
	}

	public static GtkScrolledWindowHandle SetPolicy(this GtkScrolledWindowHandle scrolled_window, GtkPolicyType hscrollbar_policy, GtkPolicyType vscrollbar_policy)
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_policy(scrolled_window, hscrollbar_policy, vscrollbar_policy);
		return scrolled_window;
	}

	public static GtkScrolledWindowHandle GetPolicy(this GtkScrolledWindowHandle scrolled_window, out GtkPolicyType hscrollbar_policy, out GtkPolicyType vscrollbar_policy)
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_get_policy(scrolled_window, out hscrollbar_policy, out vscrollbar_policy);
		return scrolled_window;
	}

	public static GtkScrolledWindowHandle SetPlacement(this GtkScrolledWindowHandle scrolled_window, GtkCornerType window_placement)
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_placement(scrolled_window, window_placement);
		return scrolled_window;
	}

	public static GtkScrolledWindowHandle UnsetPlacement(this GtkScrolledWindowHandle scrolled_window)
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_unset_placement(scrolled_window);
		return scrolled_window;
	}

	public static GtkCornerType GetPlacement(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_placement(scrolled_window);
	}

	public static GtkScrolledWindowHandle SetHasFrame(this GtkScrolledWindowHandle scrolled_window, int has_frame)
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_has_frame(scrolled_window, has_frame);
		return scrolled_window;
	}

	public static int GetHasFrame(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_has_frame(scrolled_window);
	}

	public static int GetMinContentWidth(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_min_content_width(scrolled_window);
	}

	public static GtkScrolledWindowHandle SetMinContentWidth(this GtkScrolledWindowHandle scrolled_window, int width)
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_min_content_width(scrolled_window, width);
		return scrolled_window;
	}

	public static int GetMinContentHeight(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_min_content_height(scrolled_window);
	}

	public static GtkScrolledWindowHandle SetMinContentHeight(this GtkScrolledWindowHandle scrolled_window, int height)
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_min_content_height(scrolled_window, height);
		return scrolled_window;
	}

	public static GtkScrolledWindowHandle SetKineticScrolling(this GtkScrolledWindowHandle scrolled_window, int kinetic_scrolling)
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_kinetic_scrolling(scrolled_window, kinetic_scrolling);
		return scrolled_window;
	}

	public static int GetKineticScrolling(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_kinetic_scrolling(scrolled_window);
	}

	public static GtkScrolledWindowHandle SetOverlayScrolling(this GtkScrolledWindowHandle scrolled_window, int overlay_scrolling)
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_overlay_scrolling(scrolled_window, overlay_scrolling);
		return scrolled_window;
	}

	public static int GetOverlayScrolling(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_overlay_scrolling(scrolled_window);
	}

	public static GtkScrolledWindowHandle SetMaxContentWidth(this GtkScrolledWindowHandle scrolled_window, int width)
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_max_content_width(scrolled_window, width);
		return scrolled_window;
	}

	public static int GetMaxContentWidth(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_max_content_width(scrolled_window);
	}

	public static GtkScrolledWindowHandle SetMaxContentHeight(this GtkScrolledWindowHandle scrolled_window, int height)
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_max_content_height(scrolled_window, height);
		return scrolled_window;
	}

	public static int GetMaxContentHeight(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_max_content_height(scrolled_window);
	}

	public static GtkScrolledWindowHandle SetPropagateNaturalWidth(this GtkScrolledWindowHandle scrolled_window, int propagate)
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_propagate_natural_width(scrolled_window, propagate);
		return scrolled_window;
	}

	public static int GetPropagateNaturalWidth(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_propagate_natural_width(scrolled_window);
	}

	public static GtkScrolledWindowHandle SetPropagateNaturalHeight(this GtkScrolledWindowHandle scrolled_window, int propagate)
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_propagate_natural_height(scrolled_window, propagate);
		return scrolled_window;
	}

	public static int GetPropagateNaturalHeight(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_propagate_natural_height(scrolled_window);
	}

	public static GtkScrolledWindowHandle SetChild(this GtkScrolledWindowHandle scrolled_window, GtkWidgetHandle child)
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_child(scrolled_window, child);
		return scrolled_window;
	}

	public static GtkWidgetHandle GetChild(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_child(scrolled_window);
	}
}
