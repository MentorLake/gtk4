using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gdk;
public static class GdkRectangleAdaptors
{
    public static int Intersect(this GdkRectangleHandle src1, GdkRectangleHandle src2, GdkRectangleHandle dest)
    {
        return GdkRectangleExterns.gdk_rectangle_intersect(src1, src2, dest);
    }

    public static GdkRectangleHandle Union(this GdkRectangleHandle src1, GdkRectangleHandle src2, GdkRectangleHandle dest)
    {
        GdkRectangleExterns.gdk_rectangle_union(src1, src2, dest);
        return src1;
    }

    public static int Equal(this GdkRectangleHandle rect1, GdkRectangleHandle rect2)
    {
        return GdkRectangleExterns.gdk_rectangle_equal(rect1, rect2);
    }

    public static int ContainsPoint(this GdkRectangleHandle rect, int x, int y)
    {
        return GdkRectangleExterns.gdk_rectangle_contains_point(rect, x, y);
    }

    public static GdkPopupLayoutHandle GdkPopupLayoutNew(this GdkRectangleHandle anchor_rect, GdkGravity rect_anchor, GdkGravity surface_anchor)
    {
        return GdkRectangleExterns.gdk_popup_layout_new(anchor_rect, rect_anchor, surface_anchor);
    }
}
