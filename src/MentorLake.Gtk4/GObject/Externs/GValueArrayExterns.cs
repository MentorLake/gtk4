using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.GObject;
public static class GValueArrayExterns
{
    [DllImport(Libraries.GObject, EntryPoint = "g_value_array_get_nth")]
    internal static extern GValueHandle g_value_array_get_nth(this GValueArrayHandle value_array, uint index_);
    [DllImport(Libraries.GObject, EntryPoint = "g_value_array_free")]
    [Obsolete]
    internal static extern void g_value_array_free(this GValueArrayHandle value_array);
    [DllImport(Libraries.GObject, EntryPoint = "g_value_array_copy")]
    internal static extern GValueArrayHandle g_value_array_copy(this GValueArrayHandle value_array);
    [DllImport(Libraries.GObject, EntryPoint = "g_value_array_prepend")]
    internal static extern GValueArrayHandle g_value_array_prepend(this GValueArrayHandle value_array, GValueHandle value);
    [DllImport(Libraries.GObject, EntryPoint = "g_value_array_append")]
    internal static extern GValueArrayHandle g_value_array_append(this GValueArrayHandle value_array, GValueHandle value);
    [DllImport(Libraries.GObject, EntryPoint = "g_value_array_insert")]
    internal static extern GValueArrayHandle g_value_array_insert(this GValueArrayHandle value_array, uint index_, GValueHandle value);
    [DllImport(Libraries.GObject, EntryPoint = "g_value_array_remove")]
    internal static extern GValueArrayHandle g_value_array_remove(this GValueArrayHandle value_array, uint index_);
    [DllImport(Libraries.GObject, EntryPoint = "g_value_array_sort")]
    internal static extern GValueArrayHandle g_value_array_sort(this GValueArrayHandle value_array, GCompareFunc compare_func);
    [DllImport(Libraries.GObject, EntryPoint = "g_value_array_sort_with_data")]
    internal static extern GValueArrayHandle g_value_array_sort_with_data(this GValueArrayHandle value_array, GCompareDataFunc compare_func, IntPtr user_data);
    [DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GValueArrayHandle g_value_array_new(uint n_prealloced);
}
