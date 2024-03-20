using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;
public static class cairo_rectangle_intAdaptors
{
    public static cairo_regionHandle CairoRegionCreateRectangle(this cairo_rectangle_intHandle rectangle)
    {
        return cairo_rectangle_intExterns.cairo_region_create_rectangle(rectangle);
    }

    public static cairo_regionHandle CairoRegionCreateRectangles(this cairo_rectangle_intHandle rects, int count)
    {
        return cairo_rectangle_intExterns.cairo_region_create_rectangles(rects, count);
    }
}
