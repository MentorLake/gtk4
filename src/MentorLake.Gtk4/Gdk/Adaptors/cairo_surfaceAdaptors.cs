using System.Runtime.InteropServices;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Pixbuf;

namespace MentorLake.Gtk4.Gdk;
public static class cairo_surfaceAdaptors
{
    public static GdkPixbufHandle GdkPixbufGetFromSurface(this cairo_surfaceHandle surface, int src_x, int src_y, int width, int height)
    {
        return cairo_surfaceExterns.gdk_pixbuf_get_from_surface(surface, src_x, src_y, width, height);
    }

    public static cairo_regionHandle GdkCairoRegionCreateFromSurface(this cairo_surfaceHandle surface)
    {
        return cairo_surfaceExterns.gdk_cairo_region_create_from_surface(surface);
    }
}
