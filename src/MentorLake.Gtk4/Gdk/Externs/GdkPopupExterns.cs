using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gdk;

public static class GdkPopupExterns
{
	[DllImport(Libraries.Gdk, EntryPoint = "gdk_popup_present")]
	internal static extern int gdk_popup_present(this GdkPopupHandle popup, int width, int height, GdkPopupLayoutHandle layout);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_popup_get_surface_anchor")]
	internal static extern GdkGravity gdk_popup_get_surface_anchor(this GdkPopupHandle popup);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_popup_get_rect_anchor")]
	internal static extern GdkGravity gdk_popup_get_rect_anchor(this GdkPopupHandle popup);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_popup_get_parent")]
	internal static extern GdkSurfaceHandle gdk_popup_get_parent(this GdkPopupHandle popup);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_popup_get_position_x")]
	internal static extern int gdk_popup_get_position_x(this GdkPopupHandle popup);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_popup_get_position_y")]
	internal static extern int gdk_popup_get_position_y(this GdkPopupHandle popup);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_popup_get_autohide")]
	internal static extern int gdk_popup_get_autohide(this GdkPopupHandle popup);
}
