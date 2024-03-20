using System.Runtime.InteropServices;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Pixbuf;

namespace MentorLake.Gtk4.Gdk;
public static class cairoAdaptors
{
    public static cairoHandle GdkCairoSetSourceRgba(this cairoHandle cr, GdkRGBAHandle rgba)
    {
        cairoExterns.gdk_cairo_set_source_rgba(cr, rgba);
        return cr;
    }

    public static cairoHandle GdkCairoSetSourcePixbuf(this cairoHandle cr, GdkPixbufHandle pixbuf, double pixbuf_x, double pixbuf_y)
    {
        cairoExterns.gdk_cairo_set_source_pixbuf(cr, pixbuf, pixbuf_x, pixbuf_y);
        return cr;
    }

    public static cairoHandle GdkCairoRectangle(this cairoHandle cr, GdkRectangleHandle rectangle)
    {
        cairoExterns.gdk_cairo_rectangle(cr, rectangle);
        return cr;
    }

    public static cairoHandle GdkCairoRegion(this cairoHandle cr, cairo_regionHandle region)
    {
        cairoExterns.gdk_cairo_region(cr, region);
        return cr;
    }

    public static cairoHandle GdkCairoDrawFromGl(this cairoHandle cr, GdkSurfaceHandle surface, int source, int source_type, int buffer_scale, int x, int y, int width, int height)
    {
        cairoExterns.gdk_cairo_draw_from_gl(cr, surface, source, source_type, buffer_scale, x, y, width, height);
        return cr;
    }
}
