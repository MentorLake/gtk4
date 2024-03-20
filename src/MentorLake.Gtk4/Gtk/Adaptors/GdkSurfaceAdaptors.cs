using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;
public static class GdkSurfaceAdaptors
{
    public static GtkNativeHandle GtkNativeGetForSurface(this GdkSurfaceHandle surface)
    {
        return GdkSurfaceExterns.gtk_native_get_for_surface(surface);
    }
}
