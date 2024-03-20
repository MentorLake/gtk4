using System.Runtime.InteropServices;
using MentorLake.Gtk4.Cairo;

namespace MentorLake.Gtk4.Gdk;
public static class GdkCairoContextAdaptors
{
    public static cairoHandle CairoCreate(this GdkCairoContextHandle self)
    {
        return GdkCairoContextExterns.gdk_cairo_context_cairo_create(self);
    }
}
