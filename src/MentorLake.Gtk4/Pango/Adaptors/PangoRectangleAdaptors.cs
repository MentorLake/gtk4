using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Pango;
public static class PangoRectangleAdaptors
{
    public static PangoRectangleHandle PangoExtentsToPixels(this PangoRectangleHandle inclusive, PangoRectangleHandle nearest)
    {
        PangoRectangleExterns.pango_extents_to_pixels(inclusive, nearest);
        return inclusive;
    }

    public static PangoAttributeHandle PangoAttrShapeNew(this PangoRectangleHandle ink_rect, PangoRectangleHandle logical_rect)
    {
        return PangoRectangleExterns.pango_attr_shape_new(ink_rect, logical_rect);
    }

    public static PangoAttributeHandle PangoAttrShapeNewWithData(this PangoRectangleHandle ink_rect, PangoRectangleHandle logical_rect, IntPtr data, PangoAttrDataCopyFunc copy_func, GDestroyNotify destroy_func)
    {
        return PangoRectangleExterns.pango_attr_shape_new_with_data(ink_rect, logical_rect, data, copy_func, destroy_func);
    }
}
