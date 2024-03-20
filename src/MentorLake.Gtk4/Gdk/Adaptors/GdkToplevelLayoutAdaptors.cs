using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gdk;
public static class GdkToplevelLayoutAdaptors
{
	public static GdkToplevelLayoutHandle Ref(this GdkToplevelLayoutHandle layout)
	{
		return GdkToplevelLayoutExterns.gdk_toplevel_layout_ref(layout);
	}

	public static GdkToplevelLayoutHandle Unref(this GdkToplevelLayoutHandle layout)
	{
		GdkToplevelLayoutExterns.gdk_toplevel_layout_unref(layout);
		return layout;
	}

	public static GdkToplevelLayoutHandle Copy(this GdkToplevelLayoutHandle layout)
	{
		return GdkToplevelLayoutExterns.gdk_toplevel_layout_copy(layout);
	}

	public static int Equal(this GdkToplevelLayoutHandle layout, GdkToplevelLayoutHandle other)
	{
		return GdkToplevelLayoutExterns.gdk_toplevel_layout_equal(layout, other);
	}

	public static GdkToplevelLayoutHandle SetMaximized(this GdkToplevelLayoutHandle layout, int maximized)
	{
		GdkToplevelLayoutExterns.gdk_toplevel_layout_set_maximized(layout, maximized);
		return layout;
	}

	public static GdkToplevelLayoutHandle SetFullscreen(this GdkToplevelLayoutHandle layout, int fullscreen, GdkMonitorHandle monitor)
	{
		GdkToplevelLayoutExterns.gdk_toplevel_layout_set_fullscreen(layout, fullscreen, monitor);
		return layout;
	}

	public static int GetMaximized(this GdkToplevelLayoutHandle layout, out bool maximized)
	{
		return GdkToplevelLayoutExterns.gdk_toplevel_layout_get_maximized(layout, out maximized);
	}

	public static int GetFullscreen(this GdkToplevelLayoutHandle layout, out bool fullscreen)
	{
		return GdkToplevelLayoutExterns.gdk_toplevel_layout_get_fullscreen(layout, out fullscreen);
	}

	public static GdkMonitorHandle GetFullscreenMonitor(this GdkToplevelLayoutHandle layout)
	{
		return GdkToplevelLayoutExterns.gdk_toplevel_layout_get_fullscreen_monitor(layout);
	}

	public static GdkToplevelLayoutHandle SetResizable(this GdkToplevelLayoutHandle layout, int resizable)
	{
		GdkToplevelLayoutExterns.gdk_toplevel_layout_set_resizable(layout, resizable);
		return layout;
	}

	public static int GetResizable(this GdkToplevelLayoutHandle layout)
	{
		return GdkToplevelLayoutExterns.gdk_toplevel_layout_get_resizable(layout);
	}
}
