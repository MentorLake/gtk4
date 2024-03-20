using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gdk;
public static class GdkCursorExterns
{
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_cursor_get_fallback")]
    internal static extern GdkCursorHandle gdk_cursor_get_fallback(this GdkCursorHandle cursor);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_cursor_get_name")]
    internal static extern string gdk_cursor_get_name(this GdkCursorHandle cursor);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_cursor_get_texture")]
    internal static extern GdkTextureHandle gdk_cursor_get_texture(this GdkCursorHandle cursor);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_cursor_get_hotspot_x")]
    internal static extern int gdk_cursor_get_hotspot_x(this GdkCursorHandle cursor);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_cursor_get_hotspot_y")]
    internal static extern int gdk_cursor_get_hotspot_y(this GdkCursorHandle cursor);
    [DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkCursorHandle gdk_cursor_new_from_name(string name, GdkCursorHandle fallback);
}
