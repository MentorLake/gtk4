namespace MentorLake.Gtk4.Gdk4;

public class GdkPopupLayoutHandle : BaseSafeHandle
{
	public static GdkPopupLayoutHandle New(GdkRectangleHandle anchor_rect, GdkGravity rect_anchor, GdkGravity surface_anchor)
	{
		return GdkPopupLayoutExterns.gdk_popup_layout_new(anchor_rect, rect_anchor, surface_anchor);
	}

}


public static class GdkPopupLayoutHandleExtensions
{
	public static GdkPopupLayoutHandle Copy(this GdkPopupLayoutHandle layout)
	{
		return GdkPopupLayoutExterns.gdk_popup_layout_copy(layout);
	}

	public static bool Equal(this GdkPopupLayoutHandle layout, GdkPopupLayoutHandle other)
	{
		return GdkPopupLayoutExterns.gdk_popup_layout_equal(layout, other);
	}

	public static GdkAnchorHints GetAnchorHints(this GdkPopupLayoutHandle layout)
	{
		return GdkPopupLayoutExterns.gdk_popup_layout_get_anchor_hints(layout);
	}

	public static GdkRectangleHandle GetAnchorRect(this GdkPopupLayoutHandle layout)
	{
		return GdkPopupLayoutExterns.gdk_popup_layout_get_anchor_rect(layout);
	}

	public static GdkPopupLayoutHandle GetOffset(this GdkPopupLayoutHandle layout, out int dx, out int dy)
	{
		GdkPopupLayoutExterns.gdk_popup_layout_get_offset(layout, out dx, out dy);
		return layout;
	}

	public static GdkGravity GetRectAnchor(this GdkPopupLayoutHandle layout)
	{
		return GdkPopupLayoutExterns.gdk_popup_layout_get_rect_anchor(layout);
	}

	public static GdkPopupLayoutHandle GetShadowWidth(this GdkPopupLayoutHandle layout, out int left, out int right, out int top, out int bottom)
	{
		GdkPopupLayoutExterns.gdk_popup_layout_get_shadow_width(layout, out left, out right, out top, out bottom);
		return layout;
	}

	public static GdkGravity GetSurfaceAnchor(this GdkPopupLayoutHandle layout)
	{
		return GdkPopupLayoutExterns.gdk_popup_layout_get_surface_anchor(layout);
	}

	public static GdkPopupLayoutHandle Ref(this GdkPopupLayoutHandle layout)
	{
		return GdkPopupLayoutExterns.gdk_popup_layout_ref(layout);
	}

	public static GdkPopupLayoutHandle SetAnchorHints(this GdkPopupLayoutHandle layout, GdkAnchorHints anchor_hints)
	{
		GdkPopupLayoutExterns.gdk_popup_layout_set_anchor_hints(layout, anchor_hints);
		return layout;
	}

	public static GdkPopupLayoutHandle SetAnchorRect(this GdkPopupLayoutHandle layout, GdkRectangleHandle anchor_rect)
	{
		GdkPopupLayoutExterns.gdk_popup_layout_set_anchor_rect(layout, anchor_rect);
		return layout;
	}

	public static GdkPopupLayoutHandle SetOffset(this GdkPopupLayoutHandle layout, int dx, int dy)
	{
		GdkPopupLayoutExterns.gdk_popup_layout_set_offset(layout, dx, dy);
		return layout;
	}

	public static GdkPopupLayoutHandle SetRectAnchor(this GdkPopupLayoutHandle layout, GdkGravity anchor)
	{
		GdkPopupLayoutExterns.gdk_popup_layout_set_rect_anchor(layout, anchor);
		return layout;
	}

	public static GdkPopupLayoutHandle SetShadowWidth(this GdkPopupLayoutHandle layout, int left, int right, int top, int bottom)
	{
		GdkPopupLayoutExterns.gdk_popup_layout_set_shadow_width(layout, left, right, top, bottom);
		return layout;
	}

	public static GdkPopupLayoutHandle SetSurfaceAnchor(this GdkPopupLayoutHandle layout, GdkGravity anchor)
	{
		GdkPopupLayoutExterns.gdk_popup_layout_set_surface_anchor(layout, anchor);
		return layout;
	}

	public static GdkPopupLayoutHandle Unref(this GdkPopupLayoutHandle layout)
	{
		GdkPopupLayoutExterns.gdk_popup_layout_unref(layout);
		return layout;
	}

}
internal class GdkPopupLayoutExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkPopupLayoutHandle gdk_popup_layout_new(GdkRectangleHandle anchor_rect, GdkGravity rect_anchor, GdkGravity surface_anchor);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkPopupLayoutHandle gdk_popup_layout_copy(GdkPopupLayoutHandle layout);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_popup_layout_equal(GdkPopupLayoutHandle layout, GdkPopupLayoutHandle other);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkAnchorHints gdk_popup_layout_get_anchor_hints(GdkPopupLayoutHandle layout);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkRectangleHandle gdk_popup_layout_get_anchor_rect(GdkPopupLayoutHandle layout);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_popup_layout_get_offset(GdkPopupLayoutHandle layout, out int dx, out int dy);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkGravity gdk_popup_layout_get_rect_anchor(GdkPopupLayoutHandle layout);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_popup_layout_get_shadow_width(GdkPopupLayoutHandle layout, out int left, out int right, out int top, out int bottom);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkGravity gdk_popup_layout_get_surface_anchor(GdkPopupLayoutHandle layout);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkPopupLayoutHandle gdk_popup_layout_ref(GdkPopupLayoutHandle layout);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_popup_layout_set_anchor_hints(GdkPopupLayoutHandle layout, GdkAnchorHints anchor_hints);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_popup_layout_set_anchor_rect(GdkPopupLayoutHandle layout, GdkRectangleHandle anchor_rect);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_popup_layout_set_offset(GdkPopupLayoutHandle layout, int dx, int dy);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_popup_layout_set_rect_anchor(GdkPopupLayoutHandle layout, GdkGravity anchor);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_popup_layout_set_shadow_width(GdkPopupLayoutHandle layout, int left, int right, int top, int bottom);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_popup_layout_set_surface_anchor(GdkPopupLayoutHandle layout, GdkGravity anchor);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_popup_layout_unref(GdkPopupLayoutHandle layout);

}

public struct GdkPopupLayout
{
}
