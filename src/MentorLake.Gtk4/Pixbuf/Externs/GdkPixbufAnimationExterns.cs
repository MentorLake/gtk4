using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Pixbuf;
public static class GdkPixbufAnimationExterns
{
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_animation_ref")]
    internal static extern GdkPixbufAnimationHandle gdk_pixbuf_animation_ref(this GdkPixbufAnimationHandle animation);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_animation_unref")]
    [Obsolete]
    internal static extern void gdk_pixbuf_animation_unref(this GdkPixbufAnimationHandle animation);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_animation_get_width")]
    internal static extern int gdk_pixbuf_animation_get_width(this GdkPixbufAnimationHandle animation);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_animation_get_height")]
    internal static extern int gdk_pixbuf_animation_get_height(this GdkPixbufAnimationHandle animation);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_animation_is_static_image")]
    internal static extern int gdk_pixbuf_animation_is_static_image(this GdkPixbufAnimationHandle animation);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_animation_get_static_image")]
    internal static extern GdkPixbufHandle gdk_pixbuf_animation_get_static_image(this GdkPixbufAnimationHandle animation);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_animation_get_iter")]
    internal static extern GdkPixbufAnimationIterHandle gdk_pixbuf_animation_get_iter(this GdkPixbufAnimationHandle animation, GTimeValHandle start_time);
    [DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkPixbufAnimationHandle gdk_pixbuf_animation_new_from_file(string filename, out GErrorHandle error);
    [DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkPixbufAnimationHandle gdk_pixbuf_animation_new_from_stream(GInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error);
    [DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkPixbufAnimationHandle gdk_pixbuf_animation_new_from_resource(string resource_path, out GErrorHandle error);
}
