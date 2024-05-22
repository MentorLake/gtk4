namespace MentorLake.Gtk4.Gdk4X11;

public class GdkX11SurfaceHandle : GdkSurfaceHandle
{
	public static GdkSurfaceHandle LookupForDisplay(GdkDisplayHandle display, IntPtr window)
	{
		return GdkX11SurfaceExterns.gdk_x11_surface_lookup_for_display(display, window);
	}

}

public static class GdkX11SurfaceHandleExtensions
{
	public static uint GetDesktop(this GdkX11SurfaceHandle surface)
	{
		return GdkX11SurfaceExterns.gdk_x11_surface_get_desktop(surface);
	}

	public static GdkSurfaceHandle GetGroup(this GdkX11SurfaceHandle surface)
	{
		return GdkX11SurfaceExterns.gdk_x11_surface_get_group(surface);
	}

	public static IntPtr GetXid(this GdkX11SurfaceHandle surface)
	{
		return GdkX11SurfaceExterns.gdk_x11_surface_get_xid(surface);
	}

	public static GdkX11SurfaceHandle MoveToCurrentDesktop(this GdkX11SurfaceHandle surface)
	{
		GdkX11SurfaceExterns.gdk_x11_surface_move_to_current_desktop(surface);
		return surface;
	}

	public static GdkX11SurfaceHandle MoveToDesktop(this GdkX11SurfaceHandle surface, uint desktop)
	{
		GdkX11SurfaceExterns.gdk_x11_surface_move_to_desktop(surface, desktop);
		return surface;
	}

	public static GdkX11SurfaceHandle SetFrameSyncEnabled(this GdkX11SurfaceHandle surface, bool frame_sync_enabled)
	{
		GdkX11SurfaceExterns.gdk_x11_surface_set_frame_sync_enabled(surface, frame_sync_enabled);
		return surface;
	}

	public static GdkX11SurfaceHandle SetGroup(this GdkX11SurfaceHandle surface, GdkSurfaceHandle leader)
	{
		GdkX11SurfaceExterns.gdk_x11_surface_set_group(surface, leader);
		return surface;
	}

	public static GdkX11SurfaceHandle SetSkipPagerHint(this GdkX11SurfaceHandle surface, bool skips_pager)
	{
		GdkX11SurfaceExterns.gdk_x11_surface_set_skip_pager_hint(surface, skips_pager);
		return surface;
	}

	public static GdkX11SurfaceHandle SetSkipTaskbarHint(this GdkX11SurfaceHandle surface, bool skips_taskbar)
	{
		GdkX11SurfaceExterns.gdk_x11_surface_set_skip_taskbar_hint(surface, skips_taskbar);
		return surface;
	}

	public static GdkX11SurfaceHandle SetThemeVariant(this GdkX11SurfaceHandle surface, string variant)
	{
		GdkX11SurfaceExterns.gdk_x11_surface_set_theme_variant(surface, variant);
		return surface;
	}

	public static GdkX11SurfaceHandle SetUrgencyHint(this GdkX11SurfaceHandle surface, bool urgent)
	{
		GdkX11SurfaceExterns.gdk_x11_surface_set_urgency_hint(surface, urgent);
		return surface;
	}

	public static GdkX11SurfaceHandle SetUserTime(this GdkX11SurfaceHandle surface, uint timestamp)
	{
		GdkX11SurfaceExterns.gdk_x11_surface_set_user_time(surface, timestamp);
		return surface;
	}

	public static GdkX11SurfaceHandle SetUtf8Property(this GdkX11SurfaceHandle surface, string name, string value)
	{
		GdkX11SurfaceExterns.gdk_x11_surface_set_utf8_property(surface, name, value);
		return surface;
	}

}

internal class GdkX11SurfaceExterns
{
	[DllImport(Libraries.Gdk4X11)]
	internal static extern uint gdk_x11_surface_get_desktop(GdkSurfaceHandle surface);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern GdkSurfaceHandle gdk_x11_surface_get_group(GdkSurfaceHandle surface);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern IntPtr gdk_x11_surface_get_xid(GdkSurfaceHandle surface);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern void gdk_x11_surface_move_to_current_desktop(GdkSurfaceHandle surface);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern void gdk_x11_surface_move_to_desktop(GdkSurfaceHandle surface, uint desktop);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern void gdk_x11_surface_set_frame_sync_enabled(GdkSurfaceHandle surface, bool frame_sync_enabled);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern void gdk_x11_surface_set_group(GdkSurfaceHandle surface, GdkSurfaceHandle leader);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern void gdk_x11_surface_set_skip_pager_hint(GdkSurfaceHandle surface, bool skips_pager);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern void gdk_x11_surface_set_skip_taskbar_hint(GdkSurfaceHandle surface, bool skips_taskbar);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern void gdk_x11_surface_set_theme_variant(GdkSurfaceHandle surface, string variant);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern void gdk_x11_surface_set_urgency_hint(GdkSurfaceHandle surface, bool urgent);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern void gdk_x11_surface_set_user_time(GdkSurfaceHandle surface, uint timestamp);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern void gdk_x11_surface_set_utf8_property(GdkSurfaceHandle surface, string name, string value);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern GdkSurfaceHandle gdk_x11_surface_lookup_for_display(GdkDisplayHandle display, IntPtr window);

}
