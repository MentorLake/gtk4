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

public class GtkScrolledWindowHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkScrolledWindowHandle New()
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_new();
	}

}

public class GtkScrolledWindowSignal
{
	public string Value { get; set; }
	public GtkScrolledWindowSignal(string value) => Value = value;
}

public static class GtkScrolledWindowSignals
{
	public static GtkScrolledWindowSignal EdgeOvershot = new("edge-overshot");
	public static GtkScrolledWindowSignal EdgeReached = new("edge-reached");
	public static GtkScrolledWindowSignal MoveFocusOut = new("move-focus-out");
	public static GtkScrolledWindowSignal ScrollChild = new("scroll-child");
}

public static class GtkScrolledWindowHandleExtensions
{
	public static GtkWidgetHandle GetChild(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_child(scrolled_window);
	}

	public static GtkAdjustmentHandle GetHadjustment(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_hadjustment(scrolled_window);
	}

	public static bool GetHasFrame(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_has_frame(scrolled_window);
	}

	public static GtkWidgetHandle GetHscrollbar(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_hscrollbar(scrolled_window);
	}

	public static bool GetKineticScrolling(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_kinetic_scrolling(scrolled_window);
	}

	public static int GetMaxContentHeight(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_max_content_height(scrolled_window);
	}

	public static int GetMaxContentWidth(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_max_content_width(scrolled_window);
	}

	public static int GetMinContentHeight(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_min_content_height(scrolled_window);
	}

	public static int GetMinContentWidth(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_min_content_width(scrolled_window);
	}

	public static bool GetOverlayScrolling(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_overlay_scrolling(scrolled_window);
	}

	public static GtkCornerType GetPlacement(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_placement(scrolled_window);
	}

	public static GtkScrolledWindowHandle GetPolicy(this GtkScrolledWindowHandle scrolled_window, out GtkPolicyType hscrollbar_policy, out GtkPolicyType vscrollbar_policy)
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_get_policy(scrolled_window, out hscrollbar_policy, out vscrollbar_policy);
		return scrolled_window;
	}

	public static bool GetPropagateNaturalHeight(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_propagate_natural_height(scrolled_window);
	}

	public static bool GetPropagateNaturalWidth(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_propagate_natural_width(scrolled_window);
	}

	public static GtkAdjustmentHandle GetVadjustment(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_vadjustment(scrolled_window);
	}

	public static GtkWidgetHandle GetVscrollbar(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_vscrollbar(scrolled_window);
	}

	public static GtkScrolledWindowHandle SetChild(this GtkScrolledWindowHandle scrolled_window, GtkWidgetHandle child)
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_child(scrolled_window, child);
		return scrolled_window;
	}

	public static GtkScrolledWindowHandle SetHadjustment(this GtkScrolledWindowHandle scrolled_window, GtkAdjustmentHandle hadjustment)
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_hadjustment(scrolled_window, hadjustment);
		return scrolled_window;
	}

	public static GtkScrolledWindowHandle SetHasFrame(this GtkScrolledWindowHandle scrolled_window, bool has_frame)
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_has_frame(scrolled_window, has_frame);
		return scrolled_window;
	}

	public static GtkScrolledWindowHandle SetKineticScrolling(this GtkScrolledWindowHandle scrolled_window, bool kinetic_scrolling)
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_kinetic_scrolling(scrolled_window, kinetic_scrolling);
		return scrolled_window;
	}

	public static GtkScrolledWindowHandle SetMaxContentHeight(this GtkScrolledWindowHandle scrolled_window, int height)
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_max_content_height(scrolled_window, height);
		return scrolled_window;
	}

	public static GtkScrolledWindowHandle SetMaxContentWidth(this GtkScrolledWindowHandle scrolled_window, int width)
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_max_content_width(scrolled_window, width);
		return scrolled_window;
	}

	public static GtkScrolledWindowHandle SetMinContentHeight(this GtkScrolledWindowHandle scrolled_window, int height)
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_min_content_height(scrolled_window, height);
		return scrolled_window;
	}

	public static GtkScrolledWindowHandle SetMinContentWidth(this GtkScrolledWindowHandle scrolled_window, int width)
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_min_content_width(scrolled_window, width);
		return scrolled_window;
	}

	public static GtkScrolledWindowHandle SetOverlayScrolling(this GtkScrolledWindowHandle scrolled_window, bool overlay_scrolling)
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_overlay_scrolling(scrolled_window, overlay_scrolling);
		return scrolled_window;
	}

	public static GtkScrolledWindowHandle SetPlacement(this GtkScrolledWindowHandle scrolled_window, GtkCornerType window_placement)
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_placement(scrolled_window, window_placement);
		return scrolled_window;
	}

	public static GtkScrolledWindowHandle SetPolicy(this GtkScrolledWindowHandle scrolled_window, GtkPolicyType hscrollbar_policy, GtkPolicyType vscrollbar_policy)
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_policy(scrolled_window, hscrollbar_policy, vscrollbar_policy);
		return scrolled_window;
	}

	public static GtkScrolledWindowHandle SetPropagateNaturalHeight(this GtkScrolledWindowHandle scrolled_window, bool propagate)
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_propagate_natural_height(scrolled_window, propagate);
		return scrolled_window;
	}

	public static GtkScrolledWindowHandle SetPropagateNaturalWidth(this GtkScrolledWindowHandle scrolled_window, bool propagate)
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_propagate_natural_width(scrolled_window, propagate);
		return scrolled_window;
	}

	public static GtkScrolledWindowHandle SetVadjustment(this GtkScrolledWindowHandle scrolled_window, GtkAdjustmentHandle vadjustment)
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_vadjustment(scrolled_window, vadjustment);
		return scrolled_window;
	}

	public static GtkScrolledWindowHandle UnsetPlacement(this GtkScrolledWindowHandle scrolled_window)
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_unset_placement(scrolled_window);
		return scrolled_window;
	}

	public static GtkScrolledWindowHandle Connect(this GtkScrolledWindowHandle instance, GtkScrolledWindowSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkScrolledWindowExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkScrolledWindowHandle gtk_scrolled_window_new();
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_scrolled_window_get_child(GtkScrolledWindowHandle scrolled_window);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAdjustmentHandle gtk_scrolled_window_get_hadjustment(GtkScrolledWindowHandle scrolled_window);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_scrolled_window_get_has_frame(GtkScrolledWindowHandle scrolled_window);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_scrolled_window_get_hscrollbar(GtkScrolledWindowHandle scrolled_window);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_scrolled_window_get_kinetic_scrolling(GtkScrolledWindowHandle scrolled_window);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_scrolled_window_get_max_content_height(GtkScrolledWindowHandle scrolled_window);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_scrolled_window_get_max_content_width(GtkScrolledWindowHandle scrolled_window);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_scrolled_window_get_min_content_height(GtkScrolledWindowHandle scrolled_window);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_scrolled_window_get_min_content_width(GtkScrolledWindowHandle scrolled_window);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_scrolled_window_get_overlay_scrolling(GtkScrolledWindowHandle scrolled_window);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCornerType gtk_scrolled_window_get_placement(GtkScrolledWindowHandle scrolled_window);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scrolled_window_get_policy(GtkScrolledWindowHandle scrolled_window, out GtkPolicyType hscrollbar_policy, out GtkPolicyType vscrollbar_policy);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_scrolled_window_get_propagate_natural_height(GtkScrolledWindowHandle scrolled_window);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_scrolled_window_get_propagate_natural_width(GtkScrolledWindowHandle scrolled_window);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAdjustmentHandle gtk_scrolled_window_get_vadjustment(GtkScrolledWindowHandle scrolled_window);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_scrolled_window_get_vscrollbar(GtkScrolledWindowHandle scrolled_window);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scrolled_window_set_child(GtkScrolledWindowHandle scrolled_window, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scrolled_window_set_hadjustment(GtkScrolledWindowHandle scrolled_window, GtkAdjustmentHandle hadjustment);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scrolled_window_set_has_frame(GtkScrolledWindowHandle scrolled_window, bool has_frame);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scrolled_window_set_kinetic_scrolling(GtkScrolledWindowHandle scrolled_window, bool kinetic_scrolling);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scrolled_window_set_max_content_height(GtkScrolledWindowHandle scrolled_window, int height);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scrolled_window_set_max_content_width(GtkScrolledWindowHandle scrolled_window, int width);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scrolled_window_set_min_content_height(GtkScrolledWindowHandle scrolled_window, int height);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scrolled_window_set_min_content_width(GtkScrolledWindowHandle scrolled_window, int width);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scrolled_window_set_overlay_scrolling(GtkScrolledWindowHandle scrolled_window, bool overlay_scrolling);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scrolled_window_set_placement(GtkScrolledWindowHandle scrolled_window, GtkCornerType window_placement);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scrolled_window_set_policy(GtkScrolledWindowHandle scrolled_window, GtkPolicyType hscrollbar_policy, GtkPolicyType vscrollbar_policy);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scrolled_window_set_propagate_natural_height(GtkScrolledWindowHandle scrolled_window, bool propagate);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scrolled_window_set_propagate_natural_width(GtkScrolledWindowHandle scrolled_window, bool propagate);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scrolled_window_set_vadjustment(GtkScrolledWindowHandle scrolled_window, GtkAdjustmentHandle vadjustment);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scrolled_window_unset_placement(GtkScrolledWindowHandle scrolled_window);
}
