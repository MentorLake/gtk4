namespace MentorLake.Gtk4.Gdk4;

public interface GdkPopupHandle
{
}

internal class GdkPopupHandleImpl : BaseSafeHandle, GdkPopupHandle
{
}

public static class GdkPopupHandleExtensions
{
	public static bool GetAutohide(this GdkPopupHandle popup)
	{
		return GdkPopupExterns.gdk_popup_get_autohide(popup);
	}

	public static GdkSurfaceHandle GetParent(this GdkPopupHandle popup)
	{
		return GdkPopupExterns.gdk_popup_get_parent(popup);
	}

	public static int GetPositionX(this GdkPopupHandle popup)
	{
		return GdkPopupExterns.gdk_popup_get_position_x(popup);
	}

	public static int GetPositionY(this GdkPopupHandle popup)
	{
		return GdkPopupExterns.gdk_popup_get_position_y(popup);
	}

	public static GdkGravity GetRectAnchor(this GdkPopupHandle popup)
	{
		return GdkPopupExterns.gdk_popup_get_rect_anchor(popup);
	}

	public static GdkGravity GetSurfaceAnchor(this GdkPopupHandle popup)
	{
		return GdkPopupExterns.gdk_popup_get_surface_anchor(popup);
	}

	public static bool Present(this GdkPopupHandle popup, int width, int height, GdkPopupLayoutHandle layout)
	{
		return GdkPopupExterns.gdk_popup_present(popup, width, height, layout);
	}

}

internal class GdkPopupExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_popup_get_autohide(GdkPopupHandle popup);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkSurfaceHandle gdk_popup_get_parent(GdkPopupHandle popup);

	[DllImport(Libraries.Gdk4)]
	internal static extern int gdk_popup_get_position_x(GdkPopupHandle popup);

	[DllImport(Libraries.Gdk4)]
	internal static extern int gdk_popup_get_position_y(GdkPopupHandle popup);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkGravity gdk_popup_get_rect_anchor(GdkPopupHandle popup);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkGravity gdk_popup_get_surface_anchor(GdkPopupHandle popup);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_popup_present(GdkPopupHandle popup, int width, int height, GdkPopupLayoutHandle layout);

}
