namespace MentorLake.Gtk4.Gdk4;

public class GdkToplevelLayoutHandle : BaseSafeHandle
{
	public static GdkToplevelLayoutHandle New()
	{
		return GdkToplevelLayoutExterns.gdk_toplevel_layout_new();
	}

}


public static class GdkToplevelLayoutHandleExtensions
{
	public static GdkToplevelLayoutHandle Copy(this GdkToplevelLayoutHandle layout)
	{
		return GdkToplevelLayoutExterns.gdk_toplevel_layout_copy(layout);
	}

	public static bool Equal(this GdkToplevelLayoutHandle layout, GdkToplevelLayoutHandle other)
	{
		return GdkToplevelLayoutExterns.gdk_toplevel_layout_equal(layout, other);
	}

	public static bool GetFullscreen(this GdkToplevelLayoutHandle layout, out bool fullscreen)
	{
		return GdkToplevelLayoutExterns.gdk_toplevel_layout_get_fullscreen(layout, out fullscreen);
	}

	public static GdkMonitorHandle GetFullscreenMonitor(this GdkToplevelLayoutHandle layout)
	{
		return GdkToplevelLayoutExterns.gdk_toplevel_layout_get_fullscreen_monitor(layout);
	}

	public static bool GetMaximized(this GdkToplevelLayoutHandle layout, out bool maximized)
	{
		return GdkToplevelLayoutExterns.gdk_toplevel_layout_get_maximized(layout, out maximized);
	}

	public static bool GetResizable(this GdkToplevelLayoutHandle layout)
	{
		return GdkToplevelLayoutExterns.gdk_toplevel_layout_get_resizable(layout);
	}

	public static GdkToplevelLayoutHandle Ref(this GdkToplevelLayoutHandle layout)
	{
		return GdkToplevelLayoutExterns.gdk_toplevel_layout_ref(layout);
	}

	public static GdkToplevelLayoutHandle SetFullscreen(this GdkToplevelLayoutHandle layout, bool fullscreen, GdkMonitorHandle monitor)
	{
		GdkToplevelLayoutExterns.gdk_toplevel_layout_set_fullscreen(layout, fullscreen, monitor);
		return layout;
	}

	public static GdkToplevelLayoutHandle SetMaximized(this GdkToplevelLayoutHandle layout, bool maximized)
	{
		GdkToplevelLayoutExterns.gdk_toplevel_layout_set_maximized(layout, maximized);
		return layout;
	}

	public static GdkToplevelLayoutHandle SetResizable(this GdkToplevelLayoutHandle layout, bool resizable)
	{
		GdkToplevelLayoutExterns.gdk_toplevel_layout_set_resizable(layout, resizable);
		return layout;
	}

	public static GdkToplevelLayoutHandle Unref(this GdkToplevelLayoutHandle layout)
	{
		GdkToplevelLayoutExterns.gdk_toplevel_layout_unref(layout);
		return layout;
	}

}
internal class GdkToplevelLayoutExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkToplevelLayoutHandle gdk_toplevel_layout_new();

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkToplevelLayoutHandle gdk_toplevel_layout_copy(GdkToplevelLayoutHandle layout);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_toplevel_layout_equal(GdkToplevelLayoutHandle layout, GdkToplevelLayoutHandle other);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_toplevel_layout_get_fullscreen(GdkToplevelLayoutHandle layout, out bool fullscreen);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkMonitorHandle gdk_toplevel_layout_get_fullscreen_monitor(GdkToplevelLayoutHandle layout);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_toplevel_layout_get_maximized(GdkToplevelLayoutHandle layout, out bool maximized);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_toplevel_layout_get_resizable(GdkToplevelLayoutHandle layout);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkToplevelLayoutHandle gdk_toplevel_layout_ref(GdkToplevelLayoutHandle layout);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_toplevel_layout_set_fullscreen(GdkToplevelLayoutHandle layout, bool fullscreen, GdkMonitorHandle monitor);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_toplevel_layout_set_maximized(GdkToplevelLayoutHandle layout, bool maximized);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_toplevel_layout_set_resizable(GdkToplevelLayoutHandle layout, bool resizable);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_toplevel_layout_unref(GdkToplevelLayoutHandle layout);

}

public struct GdkToplevelLayout
{
}
