using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;
public static class cairo_rectangle_listAdaptors
{
    public static cairo_rectangle_listHandle CairoRectangleListDestroy(this cairo_rectangle_listHandle rectangle_list)
    {
        cairo_rectangle_listExterns.cairo_rectangle_list_destroy(rectangle_list);
        return rectangle_list;
    }
}
