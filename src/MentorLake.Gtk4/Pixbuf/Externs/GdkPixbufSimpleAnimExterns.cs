using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pixbuf;
public static class GdkPixbufSimpleAnimExterns
{
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_simple_anim_add_frame")]
    internal static extern void gdk_pixbuf_simple_anim_add_frame(this GdkPixbufSimpleAnimHandle animation, GdkPixbufHandle pixbuf);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_simple_anim_set_loop")]
    internal static extern void gdk_pixbuf_simple_anim_set_loop(this GdkPixbufSimpleAnimHandle animation, int loop);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_simple_anim_get_loop")]
    internal static extern int gdk_pixbuf_simple_anim_get_loop(this GdkPixbufSimpleAnimHandle animation);
    [DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkPixbufSimpleAnimHandle gdk_pixbuf_simple_anim_new(int width, int height, float rate);
}
