using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gdk;
public static class GdkToplevelSizeAdaptors
{
    public static GdkToplevelSizeHandle GetBounds(this GdkToplevelSizeHandle size, out int bounds_width, out int bounds_height)
    {
        GdkToplevelSizeExterns.gdk_toplevel_size_get_bounds(size, out bounds_width, out bounds_height);
        return size;
    }

    public static GdkToplevelSizeHandle SetSize(this GdkToplevelSizeHandle size, int width, int height)
    {
        GdkToplevelSizeExterns.gdk_toplevel_size_set_size(size, width, height);
        return size;
    }

    public static GdkToplevelSizeHandle SetMinSize(this GdkToplevelSizeHandle size, int min_width, int min_height)
    {
        GdkToplevelSizeExterns.gdk_toplevel_size_set_min_size(size, min_width, min_height);
        return size;
    }

    public static GdkToplevelSizeHandle SetShadowWidth(this GdkToplevelSizeHandle size, int left, int right, int top, int bottom)
    {
        GdkToplevelSizeExterns.gdk_toplevel_size_set_shadow_width(size, left, right, top, bottom);
        return size;
    }
}
