using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gdk;
public static class GdkDragSurfaceAdaptors
{
    public static int Present(this GdkDragSurfaceHandle drag_surface, int width, int height)
    {
        return GdkDragSurfaceExterns.gdk_drag_surface_present(drag_surface, width, height);
    }
}
