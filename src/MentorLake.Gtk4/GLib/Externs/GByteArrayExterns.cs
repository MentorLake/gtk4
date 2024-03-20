using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GByteArrayExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_byte_array_steal")]
    internal static extern byte[] g_byte_array_steal(this GByteArrayHandle array, ref nuint len);
    [DllImport(Libraries.GLib, EntryPoint = "g_byte_array_free")]
    internal static extern byte[] g_byte_array_free(this GByteArrayHandle array, int free_segment);
    [DllImport(Libraries.GLib, EntryPoint = "g_byte_array_free_to_bytes")]
    internal static extern GBytesHandle g_byte_array_free_to_bytes(this GByteArrayHandle array);
    [DllImport(Libraries.GLib, EntryPoint = "g_byte_array_ref")]
    internal static extern GByteArrayHandle g_byte_array_ref(this GByteArrayHandle array);
    [DllImport(Libraries.GLib, EntryPoint = "g_byte_array_unref")]
    internal static extern void g_byte_array_unref(this GByteArrayHandle array);
    [DllImport(Libraries.GLib, EntryPoint = "g_byte_array_append")]
    internal static extern GByteArrayHandle g_byte_array_append(this GByteArrayHandle array, byte[] data, uint len);
    [DllImport(Libraries.GLib, EntryPoint = "g_byte_array_prepend")]
    internal static extern GByteArrayHandle g_byte_array_prepend(this GByteArrayHandle array, byte[] data, uint len);
    [DllImport(Libraries.GLib, EntryPoint = "g_byte_array_set_size")]
    internal static extern GByteArrayHandle g_byte_array_set_size(this GByteArrayHandle array, uint length);
    [DllImport(Libraries.GLib, EntryPoint = "g_byte_array_remove_index")]
    internal static extern GByteArrayHandle g_byte_array_remove_index(this GByteArrayHandle array, uint index_);
    [DllImport(Libraries.GLib, EntryPoint = "g_byte_array_remove_index_fast")]
    internal static extern GByteArrayHandle g_byte_array_remove_index_fast(this GByteArrayHandle array, uint index_);
    [DllImport(Libraries.GLib, EntryPoint = "g_byte_array_remove_range")]
    internal static extern GByteArrayHandle g_byte_array_remove_range(this GByteArrayHandle array, uint index_, uint length);
    [DllImport(Libraries.GLib, EntryPoint = "g_byte_array_sort")]
    internal static extern void g_byte_array_sort(this GByteArrayHandle array, GCompareFunc compare_func);
    [DllImport(Libraries.GLib, EntryPoint = "g_byte_array_sort_with_data")]
    internal static extern void g_byte_array_sort_with_data(this GByteArrayHandle array, GCompareDataFunc compare_func, IntPtr user_data);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GByteArrayHandle g_byte_array_new();
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GByteArrayHandle g_byte_array_new_take(byte[] data, nuint len);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GByteArrayHandle g_byte_array_sized_new(uint reserved_size);
}
