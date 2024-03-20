using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gdk;
public static class GdkPopupAdaptors
{
    public static int Present(this GdkPopupHandle popup, int width, int height, GdkPopupLayoutHandle layout)
    {
        return GdkPopupExterns.gdk_popup_present(popup, width, height, layout);
    }

    public static GdkGravity GetSurfaceAnchor(this GdkPopupHandle popup)
    {
        return GdkPopupExterns.gdk_popup_get_surface_anchor(popup);
    }

    public static GdkGravity GetRectAnchor(this GdkPopupHandle popup)
    {
        return GdkPopupExterns.gdk_popup_get_rect_anchor(popup);
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

    public static int GetAutohide(this GdkPopupHandle popup)
    {
        return GdkPopupExterns.gdk_popup_get_autohide(popup);
    }
}
