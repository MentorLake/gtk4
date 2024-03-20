using System.Runtime.InteropServices;
using MentorLake.Gtk4.Cairo;

namespace MentorLake.Gtk4.Gdk;
public static class GdkDrawContextAdaptors
{
    public static GdkDisplayHandle GetDisplay(this GdkDrawContextHandle context)
    {
        return GdkDrawContextExterns.gdk_draw_context_get_display(context);
    }

    public static GdkSurfaceHandle GetSurface(this GdkDrawContextHandle context)
    {
        return GdkDrawContextExterns.gdk_draw_context_get_surface(context);
    }

    public static GdkDrawContextHandle BeginFrame(this GdkDrawContextHandle context, cairo_regionHandle region)
    {
        GdkDrawContextExterns.gdk_draw_context_begin_frame(context, region);
        return context;
    }

    public static GdkDrawContextHandle EndFrame(this GdkDrawContextHandle context)
    {
        GdkDrawContextExterns.gdk_draw_context_end_frame(context);
        return context;
    }

    public static int IsInFrame(this GdkDrawContextHandle context)
    {
        return GdkDrawContextExterns.gdk_draw_context_is_in_frame(context);
    }

    public static cairo_regionHandle GetFrameRegion(this GdkDrawContextHandle context)
    {
        return GdkDrawContextExterns.gdk_draw_context_get_frame_region(context);
    }
}
