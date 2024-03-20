using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Pixbuf;
public static class GdkPixbufAnimationIterAdaptors
{
    public static int GetDelayTime(this GdkPixbufAnimationIterHandle iter)
    {
        return GdkPixbufAnimationIterExterns.gdk_pixbuf_animation_iter_get_delay_time(iter);
    }

    public static GdkPixbufHandle GetPixbuf(this GdkPixbufAnimationIterHandle iter)
    {
        return GdkPixbufAnimationIterExterns.gdk_pixbuf_animation_iter_get_pixbuf(iter);
    }

    public static int OnCurrentlyLoadingFrame(this GdkPixbufAnimationIterHandle iter)
    {
        return GdkPixbufAnimationIterExterns.gdk_pixbuf_animation_iter_on_currently_loading_frame(iter);
    }

    public static int Advance(this GdkPixbufAnimationIterHandle iter, GTimeValHandle current_time)
    {
        return GdkPixbufAnimationIterExterns.gdk_pixbuf_animation_iter_advance(iter, current_time);
    }
}
