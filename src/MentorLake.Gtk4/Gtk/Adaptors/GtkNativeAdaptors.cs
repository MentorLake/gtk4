using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.Gsk;

namespace MentorLake.Gtk4.Gtk;
public static class GtkNativeAdaptors
{
    public static GtkNativeHandle Realize(this GtkNativeHandle self)
    {
        GtkNativeExterns.gtk_native_realize(self);
        return self;
    }

    public static GtkNativeHandle Unrealize(this GtkNativeHandle self)
    {
        GtkNativeExterns.gtk_native_unrealize(self);
        return self;
    }

    public static GdkSurfaceHandle GetSurface(this GtkNativeHandle self)
    {
        return GtkNativeExterns.gtk_native_get_surface(self);
    }

    public static GskRendererHandle GetRenderer(this GtkNativeHandle self)
    {
        return GtkNativeExterns.gtk_native_get_renderer(self);
    }

    public static GtkNativeHandle GetSurfaceTransform(this GtkNativeHandle self, out double x, out double y)
    {
        GtkNativeExterns.gtk_native_get_surface_transform(self, out x, out y);
        return self;
    }
}
