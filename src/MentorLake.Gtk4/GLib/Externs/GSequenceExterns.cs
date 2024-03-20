using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GSequenceExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_sequence_free")]
    internal static extern void g_sequence_free(this GSequenceHandle seq);
    [DllImport(Libraries.GLib, EntryPoint = "g_sequence_get_length")]
    internal static extern int g_sequence_get_length(this GSequenceHandle seq);
    [DllImport(Libraries.GLib, EntryPoint = "g_sequence_foreach")]
    internal static extern void g_sequence_foreach(this GSequenceHandle seq, IntPtr func, IntPtr user_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_sequence_sort")]
    internal static extern void g_sequence_sort(this GSequenceHandle seq, GCompareDataFunc cmp_func, IntPtr cmp_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_sequence_sort_iter")]
    internal static extern void g_sequence_sort_iter(this GSequenceHandle seq, GSequenceIterCompareFunc cmp_func, IntPtr cmp_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_sequence_is_empty")]
    internal static extern int g_sequence_is_empty(this GSequenceHandle seq);
    [DllImport(Libraries.GLib, EntryPoint = "g_sequence_get_begin_iter")]
    internal static extern GSequenceIterHandle g_sequence_get_begin_iter(this GSequenceHandle seq);
    [DllImport(Libraries.GLib, EntryPoint = "g_sequence_get_end_iter")]
    internal static extern GSequenceIterHandle g_sequence_get_end_iter(this GSequenceHandle seq);
    [DllImport(Libraries.GLib, EntryPoint = "g_sequence_get_iter_at_pos")]
    internal static extern GSequenceIterHandle g_sequence_get_iter_at_pos(this GSequenceHandle seq, int pos);
    [DllImport(Libraries.GLib, EntryPoint = "g_sequence_append")]
    internal static extern GSequenceIterHandle g_sequence_append(this GSequenceHandle seq, IntPtr data);
    [DllImport(Libraries.GLib, EntryPoint = "g_sequence_prepend")]
    internal static extern GSequenceIterHandle g_sequence_prepend(this GSequenceHandle seq, IntPtr data);
    [DllImport(Libraries.GLib, EntryPoint = "g_sequence_insert_sorted")]
    internal static extern GSequenceIterHandle g_sequence_insert_sorted(this GSequenceHandle seq, IntPtr data, GCompareDataFunc cmp_func, IntPtr cmp_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_sequence_insert_sorted_iter")]
    internal static extern GSequenceIterHandle g_sequence_insert_sorted_iter(this GSequenceHandle seq, IntPtr data, GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_sequence_search")]
    internal static extern GSequenceIterHandle g_sequence_search(this GSequenceHandle seq, IntPtr data, GCompareDataFunc cmp_func, IntPtr cmp_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_sequence_search_iter")]
    internal static extern GSequenceIterHandle g_sequence_search_iter(this GSequenceHandle seq, IntPtr data, GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_sequence_lookup")]
    internal static extern GSequenceIterHandle g_sequence_lookup(this GSequenceHandle seq, IntPtr data, GCompareDataFunc cmp_func, IntPtr cmp_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_sequence_lookup_iter")]
    internal static extern GSequenceIterHandle g_sequence_lookup_iter(this GSequenceHandle seq, IntPtr data, GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GSequenceHandle g_sequence_new(GDestroyNotify data_destroy);
}
