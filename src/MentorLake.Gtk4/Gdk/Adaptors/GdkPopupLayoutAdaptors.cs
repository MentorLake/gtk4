using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gdk;
public static class GdkPopupLayoutAdaptors
{
    public static GdkPopupLayoutHandle Ref(this GdkPopupLayoutHandle layout)
    {
        return GdkPopupLayoutExterns.gdk_popup_layout_ref(layout);
    }

    public static GdkPopupLayoutHandle Unref(this GdkPopupLayoutHandle layout)
    {
        GdkPopupLayoutExterns.gdk_popup_layout_unref(layout);
        return layout;
    }

    public static GdkPopupLayoutHandle Copy(this GdkPopupLayoutHandle layout)
    {
        return GdkPopupLayoutExterns.gdk_popup_layout_copy(layout);
    }

    public static int Equal(this GdkPopupLayoutHandle layout, GdkPopupLayoutHandle other)
    {
        return GdkPopupLayoutExterns.gdk_popup_layout_equal(layout, other);
    }

    public static GdkPopupLayoutHandle SetAnchorRect(this GdkPopupLayoutHandle layout, GdkRectangleHandle anchor_rect)
    {
        GdkPopupLayoutExterns.gdk_popup_layout_set_anchor_rect(layout, anchor_rect);
        return layout;
    }

    public static GdkRectangleHandle GetAnchorRect(this GdkPopupLayoutHandle layout)
    {
        return GdkPopupLayoutExterns.gdk_popup_layout_get_anchor_rect(layout);
    }

    public static GdkPopupLayoutHandle SetRectAnchor(this GdkPopupLayoutHandle layout, GdkGravity anchor)
    {
        GdkPopupLayoutExterns.gdk_popup_layout_set_rect_anchor(layout, anchor);
        return layout;
    }

    public static GdkGravity GetRectAnchor(this GdkPopupLayoutHandle layout)
    {
        return GdkPopupLayoutExterns.gdk_popup_layout_get_rect_anchor(layout);
    }

    public static GdkPopupLayoutHandle SetSurfaceAnchor(this GdkPopupLayoutHandle layout, GdkGravity anchor)
    {
        GdkPopupLayoutExterns.gdk_popup_layout_set_surface_anchor(layout, anchor);
        return layout;
    }

    public static GdkGravity GetSurfaceAnchor(this GdkPopupLayoutHandle layout)
    {
        return GdkPopupLayoutExterns.gdk_popup_layout_get_surface_anchor(layout);
    }

    public static GdkPopupLayoutHandle SetAnchorHints(this GdkPopupLayoutHandle layout, GdkAnchorHints anchor_hints)
    {
        GdkPopupLayoutExterns.gdk_popup_layout_set_anchor_hints(layout, anchor_hints);
        return layout;
    }

    public static GdkAnchorHints GetAnchorHints(this GdkPopupLayoutHandle layout)
    {
        return GdkPopupLayoutExterns.gdk_popup_layout_get_anchor_hints(layout);
    }

    public static GdkPopupLayoutHandle SetOffset(this GdkPopupLayoutHandle layout, int dx, int dy)
    {
        GdkPopupLayoutExterns.gdk_popup_layout_set_offset(layout, dx, dy);
        return layout;
    }

    public static GdkPopupLayoutHandle GetOffset(this GdkPopupLayoutHandle layout, out int dx, out int dy)
    {
        GdkPopupLayoutExterns.gdk_popup_layout_get_offset(layout, out dx, out dy);
        return layout;
    }

    public static GdkPopupLayoutHandle SetShadowWidth(this GdkPopupLayoutHandle layout, int left, int right, int top, int bottom)
    {
        GdkPopupLayoutExterns.gdk_popup_layout_set_shadow_width(layout, left, right, top, bottom);
        return layout;
    }

    public static GdkPopupLayoutHandle GetShadowWidth(this GdkPopupLayoutHandle layout, out int left, out int right, out int top, out int bottom)
    {
        GdkPopupLayoutExterns.gdk_popup_layout_get_shadow_width(layout, out left, out right, out top, out bottom);
        return layout;
    }
}
