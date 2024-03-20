using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GPtrArrayExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_ptr_array_steal")]
    internal static extern IntPtr[] g_ptr_array_steal(this GPtrArrayHandle array, ref nuint len);
    [DllImport(Libraries.GLib, EntryPoint = "g_ptr_array_copy")]
    internal static extern GPtrArrayHandle g_ptr_array_copy(this GPtrArrayHandle array, GCopyFunc func, IntPtr user_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_ptr_array_free")]
    internal static extern IntPtr[] g_ptr_array_free(this GPtrArrayHandle array, int free_seg);
    [DllImport(Libraries.GLib, EntryPoint = "g_ptr_array_ref")]
    internal static extern GPtrArrayHandle g_ptr_array_ref(this GPtrArrayHandle array);
    [DllImport(Libraries.GLib, EntryPoint = "g_ptr_array_unref")]
    internal static extern void g_ptr_array_unref(this GPtrArrayHandle array);
    [DllImport(Libraries.GLib, EntryPoint = "g_ptr_array_set_free_func")]
    internal static extern void g_ptr_array_set_free_func(this GPtrArrayHandle array, GDestroyNotify element_free_func);
    [DllImport(Libraries.GLib, EntryPoint = "g_ptr_array_set_size")]
    internal static extern void g_ptr_array_set_size(this GPtrArrayHandle array, int length);
    [DllImport(Libraries.GLib, EntryPoint = "g_ptr_array_remove_index")]
    internal static extern IntPtr g_ptr_array_remove_index(this GPtrArrayHandle array, uint index_);
    [DllImport(Libraries.GLib, EntryPoint = "g_ptr_array_remove_index_fast")]
    internal static extern IntPtr g_ptr_array_remove_index_fast(this GPtrArrayHandle array, uint index_);
    [DllImport(Libraries.GLib, EntryPoint = "g_ptr_array_steal_index")]
    internal static extern IntPtr g_ptr_array_steal_index(this GPtrArrayHandle array, uint index_);
    [DllImport(Libraries.GLib, EntryPoint = "g_ptr_array_steal_index_fast")]
    internal static extern IntPtr g_ptr_array_steal_index_fast(this GPtrArrayHandle array, uint index_);
    [DllImport(Libraries.GLib, EntryPoint = "g_ptr_array_remove")]
    internal static extern int g_ptr_array_remove(this GPtrArrayHandle array, IntPtr data);
    [DllImport(Libraries.GLib, EntryPoint = "g_ptr_array_remove_fast")]
    internal static extern int g_ptr_array_remove_fast(this GPtrArrayHandle array, IntPtr data);
    [DllImport(Libraries.GLib, EntryPoint = "g_ptr_array_remove_range")]
    internal static extern GPtrArrayHandle g_ptr_array_remove_range(this GPtrArrayHandle array, uint index_, uint length);
    [DllImport(Libraries.GLib, EntryPoint = "g_ptr_array_add")]
    internal static extern void g_ptr_array_add(this GPtrArrayHandle array, IntPtr data);
    [DllImport(Libraries.GLib, EntryPoint = "g_ptr_array_extend")]
    internal static extern void g_ptr_array_extend(this GPtrArrayHandle array_to_extend, GPtrArrayHandle array, GCopyFunc func, IntPtr user_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_ptr_array_extend_and_steal")]
    internal static extern void g_ptr_array_extend_and_steal(this GPtrArrayHandle array_to_extend, GPtrArrayHandle array);
    [DllImport(Libraries.GLib, EntryPoint = "g_ptr_array_insert")]
    internal static extern void g_ptr_array_insert(this GPtrArrayHandle array, int index_, IntPtr data);
    [DllImport(Libraries.GLib, EntryPoint = "g_ptr_array_sort")]
    internal static extern void g_ptr_array_sort(this GPtrArrayHandle array, GCompareFunc compare_func);
    [DllImport(Libraries.GLib, EntryPoint = "g_ptr_array_sort_with_data")]
    internal static extern void g_ptr_array_sort_with_data(this GPtrArrayHandle array, GCompareDataFunc compare_func, IntPtr user_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_ptr_array_foreach")]
    internal static extern void g_ptr_array_foreach(this GPtrArrayHandle array, IntPtr func, IntPtr user_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_ptr_array_find")]
    internal static extern int g_ptr_array_find(this GPtrArrayHandle haystack, IntPtr needle, out uint index_);
    [DllImport(Libraries.GLib, EntryPoint = "g_ptr_array_find_with_equal_func")]
    internal static extern int g_ptr_array_find_with_equal_func(this GPtrArrayHandle haystack, IntPtr needle, GEqualFunc equal_func, out uint index_);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GPtrArrayHandle g_ptr_array_new();
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GPtrArrayHandle g_ptr_array_new_with_free_func(GDestroyNotify element_free_func);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GPtrArrayHandle g_ptr_array_sized_new(uint reserved_size);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GPtrArrayHandle g_ptr_array_new_full(uint reserved_size, GDestroyNotify element_free_func);
}
