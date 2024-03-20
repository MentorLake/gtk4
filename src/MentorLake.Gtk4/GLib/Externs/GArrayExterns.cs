using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GArrayExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_array_steal")]
    internal static extern IntPtr g_array_steal(this GArrayHandle array, ref nuint len);
    [DllImport(Libraries.GLib, EntryPoint = "g_array_copy")]
    internal static extern GArrayHandle g_array_copy(this GArrayHandle array);
    [DllImport(Libraries.GLib, EntryPoint = "g_array_free")]
    internal static extern string g_array_free(this GArrayHandle array, int free_segment);
    [DllImport(Libraries.GLib, EntryPoint = "g_array_ref")]
    internal static extern GArrayHandle g_array_ref(this GArrayHandle array);
    [DllImport(Libraries.GLib, EntryPoint = "g_array_unref")]
    internal static extern void g_array_unref(this GArrayHandle array);
    [DllImport(Libraries.GLib, EntryPoint = "g_array_get_element_size")]
    internal static extern uint g_array_get_element_size(this GArrayHandle array);
    [DllImport(Libraries.GLib, EntryPoint = "g_array_append_vals")]
    internal static extern GArrayHandle g_array_append_vals(this GArrayHandle array, IntPtr data, uint len);
    [DllImport(Libraries.GLib, EntryPoint = "g_array_prepend_vals")]
    internal static extern GArrayHandle g_array_prepend_vals(this GArrayHandle array, IntPtr data, uint len);
    [DllImport(Libraries.GLib, EntryPoint = "g_array_insert_vals")]
    internal static extern GArrayHandle g_array_insert_vals(this GArrayHandle array, uint index_, IntPtr data, uint len);
    [DllImport(Libraries.GLib, EntryPoint = "g_array_set_size")]
    internal static extern GArrayHandle g_array_set_size(this GArrayHandle array, uint length);
    [DllImport(Libraries.GLib, EntryPoint = "g_array_remove_index")]
    internal static extern GArrayHandle g_array_remove_index(this GArrayHandle array, uint index_);
    [DllImport(Libraries.GLib, EntryPoint = "g_array_remove_index_fast")]
    internal static extern GArrayHandle g_array_remove_index_fast(this GArrayHandle array, uint index_);
    [DllImport(Libraries.GLib, EntryPoint = "g_array_remove_range")]
    internal static extern GArrayHandle g_array_remove_range(this GArrayHandle array, uint index_, uint length);
    [DllImport(Libraries.GLib, EntryPoint = "g_array_sort")]
    internal static extern void g_array_sort(this GArrayHandle array, GCompareFunc compare_func);
    [DllImport(Libraries.GLib, EntryPoint = "g_array_sort_with_data")]
    internal static extern void g_array_sort_with_data(this GArrayHandle array, GCompareDataFunc compare_func, IntPtr user_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_array_binary_search")]
    internal static extern int g_array_binary_search(this GArrayHandle array, IntPtr target, GCompareFunc compare_func, out uint out_match_index);
    [DllImport(Libraries.GLib, EntryPoint = "g_array_set_clear_func")]
    internal static extern void g_array_set_clear_func(this GArrayHandle array, GDestroyNotify clear_func);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GArrayHandle g_array_new(int zero_terminated, int clear_, uint element_size);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GArrayHandle g_array_sized_new(int zero_terminated, int clear_, uint element_size, uint reserved_size);
}
