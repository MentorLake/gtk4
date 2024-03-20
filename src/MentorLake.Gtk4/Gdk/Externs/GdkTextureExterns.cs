using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.Pixbuf;

namespace MentorLake.Gtk4.Gdk;
public static class GdkTextureExterns
{
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_texture_get_width")]
    internal static extern int gdk_texture_get_width(this GdkTextureHandle texture);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_texture_get_height")]
    internal static extern int gdk_texture_get_height(this GdkTextureHandle texture);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_texture_download")]
    internal static extern void gdk_texture_download(this GdkTextureHandle texture, string data, nuint stride);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_texture_save_to_png")]
    internal static extern int gdk_texture_save_to_png(this GdkTextureHandle texture, string filename);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_texture_save_to_png_bytes")]
    internal static extern GBytesHandle gdk_texture_save_to_png_bytes(this GdkTextureHandle texture);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_texture_save_to_tiff")]
    internal static extern int gdk_texture_save_to_tiff(this GdkTextureHandle texture, string filename);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_texture_save_to_tiff_bytes")]
    internal static extern GBytesHandle gdk_texture_save_to_tiff_bytes(this GdkTextureHandle texture);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_pixbuf_get_from_texture")]
    internal static extern GdkPixbufHandle gdk_pixbuf_get_from_texture(this GdkTextureHandle texture);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_cursor_new_from_texture")]
    internal static extern GdkCursorHandle gdk_cursor_new_from_texture(this GdkTextureHandle texture, int hotspot_x, int hotspot_y, GdkCursorHandle fallback);
    [DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkTextureHandle gdk_texture_new_for_pixbuf(GdkPixbufHandle pixbuf);
    [DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkTextureHandle gdk_texture_new_from_resource(string resource_path);
    [DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkTextureHandle gdk_texture_new_from_file(GFileHandle file, out GErrorHandle error);
    [DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkTextureHandle gdk_texture_new_from_filename(string path, out GErrorHandle error);
    [DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkTextureHandle gdk_texture_new_from_bytes(GBytesHandle bytes, out GErrorHandle error);
    [DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkTextureHandle gdk_gl_texture_new(GdkGLContextHandle context, uint id, int width, int height, GDestroyNotify destroy, IntPtr data);
    [DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkTextureHandle gdk_memory_texture_new(int width, int height, GdkMemoryFormat format, GBytesHandle bytes, nuint stride);
}
