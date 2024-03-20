using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GBytesExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_bytes_new_from_bytes")]
    internal static extern GBytesHandle g_bytes_new_from_bytes(this GBytesHandle bytes, nuint offset, nuint length);
    [DllImport(Libraries.GLib, EntryPoint = "g_bytes_get_data")]
    internal static extern IntPtr g_bytes_get_data(this GBytesHandle bytes, out nuint size);
    [DllImport(Libraries.GLib, EntryPoint = "g_bytes_get_size")]
    internal static extern nuint g_bytes_get_size(this GBytesHandle bytes);
    [DllImport(Libraries.GLib, EntryPoint = "g_bytes_ref")]
    internal static extern GBytesHandle g_bytes_ref(this GBytesHandle bytes);
    [DllImport(Libraries.GLib, EntryPoint = "g_bytes_unref")]
    internal static extern void g_bytes_unref(this GBytesHandle bytes);
    [DllImport(Libraries.GLib, EntryPoint = "g_bytes_unref_to_data")]
    internal static extern IntPtr g_bytes_unref_to_data(this GBytesHandle bytes, out nuint size);
    [DllImport(Libraries.GLib, EntryPoint = "g_bytes_unref_to_array")]
    internal static extern GByteArrayHandle g_bytes_unref_to_array(this GBytesHandle bytes);
    [DllImport(Libraries.GLib, EntryPoint = "g_bytes_get_region")]
    internal static extern IntPtr g_bytes_get_region(this GBytesHandle bytes, nuint element_size, nuint offset, nuint n_elements);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GBytesHandle g_bytes_new(IntPtr data, nuint size);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GBytesHandle g_bytes_new_take(IntPtr data, nuint size);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GBytesHandle g_bytes_new_static(IntPtr data, nuint size);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GBytesHandle g_bytes_new_with_free_func(IntPtr data, nuint size, GDestroyNotify free_func, IntPtr user_data);
}
