using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gdk;

public static class GdkRectangleExterns
{
	[DllImport(Libraries.Gdk, EntryPoint = "gdk_rectangle_intersect")]
	internal static extern int gdk_rectangle_intersect(this GdkRectangleHandle src1, GdkRectangleHandle src2, GdkRectangleHandle dest);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_rectangle_union")]
	internal static extern void gdk_rectangle_union(this GdkRectangleHandle src1, GdkRectangleHandle src2, GdkRectangleHandle dest);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_rectangle_equal")]
	internal static extern int gdk_rectangle_equal(this GdkRectangleHandle rect1, GdkRectangleHandle rect2);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_rectangle_contains_point")]
	internal static extern int gdk_rectangle_contains_point(this GdkRectangleHandle rect, int x, int y);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_popup_layout_new")]
	internal static extern GdkPopupLayoutHandle gdk_popup_layout_new(this GdkRectangleHandle anchor_rect, GdkGravity rect_anchor, GdkGravity surface_anchor);
}
