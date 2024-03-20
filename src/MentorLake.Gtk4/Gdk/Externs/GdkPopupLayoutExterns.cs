using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gdk;

public static class GdkPopupLayoutExterns
{
	[DllImport(Libraries.Gdk, EntryPoint = "gdk_popup_layout_ref")]
	internal static extern GdkPopupLayoutHandle gdk_popup_layout_ref(this GdkPopupLayoutHandle layout);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_popup_layout_unref")]
	internal static extern void gdk_popup_layout_unref(this GdkPopupLayoutHandle layout);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_popup_layout_copy")]
	internal static extern GdkPopupLayoutHandle gdk_popup_layout_copy(this GdkPopupLayoutHandle layout);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_popup_layout_equal")]
	internal static extern int gdk_popup_layout_equal(this GdkPopupLayoutHandle layout, GdkPopupLayoutHandle other);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_popup_layout_set_anchor_rect")]
	internal static extern void gdk_popup_layout_set_anchor_rect(this GdkPopupLayoutHandle layout, GdkRectangleHandle anchor_rect);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_popup_layout_get_anchor_rect")]
	internal static extern GdkRectangleHandle gdk_popup_layout_get_anchor_rect(this GdkPopupLayoutHandle layout);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_popup_layout_set_rect_anchor")]
	internal static extern void gdk_popup_layout_set_rect_anchor(this GdkPopupLayoutHandle layout, GdkGravity anchor);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_popup_layout_get_rect_anchor")]
	internal static extern GdkGravity gdk_popup_layout_get_rect_anchor(this GdkPopupLayoutHandle layout);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_popup_layout_set_surface_anchor")]
	internal static extern void gdk_popup_layout_set_surface_anchor(this GdkPopupLayoutHandle layout, GdkGravity anchor);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_popup_layout_get_surface_anchor")]
	internal static extern GdkGravity gdk_popup_layout_get_surface_anchor(this GdkPopupLayoutHandle layout);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_popup_layout_set_anchor_hints")]
	internal static extern void gdk_popup_layout_set_anchor_hints(this GdkPopupLayoutHandle layout, GdkAnchorHints anchor_hints);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_popup_layout_get_anchor_hints")]
	internal static extern GdkAnchorHints gdk_popup_layout_get_anchor_hints(this GdkPopupLayoutHandle layout);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_popup_layout_set_offset")]
	internal static extern void gdk_popup_layout_set_offset(this GdkPopupLayoutHandle layout, int dx, int dy);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_popup_layout_get_offset")]
	internal static extern void gdk_popup_layout_get_offset(this GdkPopupLayoutHandle layout, out int dx, out int dy);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_popup_layout_set_shadow_width")]
	internal static extern void gdk_popup_layout_set_shadow_width(this GdkPopupLayoutHandle layout, int left, int right, int top, int bottom);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_popup_layout_get_shadow_width")]
	internal static extern void gdk_popup_layout_get_shadow_width(this GdkPopupLayoutHandle layout, out int left, out int right, out int top, out int bottom);
}
