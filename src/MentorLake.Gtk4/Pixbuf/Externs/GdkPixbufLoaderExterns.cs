using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Pixbuf;
public static class GdkPixbufLoaderExterns
{
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_loader_set_size")]
    internal static extern void gdk_pixbuf_loader_set_size(this GdkPixbufLoaderHandle loader, int width, int height);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_loader_write")]
    internal static extern int gdk_pixbuf_loader_write(this GdkPixbufLoaderHandle loader, string buf, nuint count, out GErrorHandle error);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_loader_write_bytes")]
    internal static extern int gdk_pixbuf_loader_write_bytes(this GdkPixbufLoaderHandle loader, GBytesHandle buffer, out GErrorHandle error);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_loader_get_pixbuf")]
    internal static extern GdkPixbufHandle gdk_pixbuf_loader_get_pixbuf(this GdkPixbufLoaderHandle loader);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_loader_get_animation")]
    internal static extern GdkPixbufAnimationHandle gdk_pixbuf_loader_get_animation(this GdkPixbufLoaderHandle loader);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_loader_close")]
    internal static extern int gdk_pixbuf_loader_close(this GdkPixbufLoaderHandle loader, out GErrorHandle error);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_loader_get_format")]
    internal static extern GdkPixbufFormatHandle gdk_pixbuf_loader_get_format(this GdkPixbufLoaderHandle loader);
    [DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkPixbufLoaderHandle gdk_pixbuf_loader_new();
    [DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkPixbufLoaderHandle gdk_pixbuf_loader_new_with_type(string image_type, out GErrorHandle error);
    [DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkPixbufLoaderHandle gdk_pixbuf_loader_new_with_mime_type(string mime_type, out GErrorHandle error);
}
