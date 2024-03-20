using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;

public static class GSequenceIterExterns
{
	[DllImport(Libraries.GLib, EntryPoint = "g_sequence_foreach_range")]
	internal static extern void g_sequence_foreach_range(this GSequenceIterHandle begin, GSequenceIterHandle end, IntPtr func, IntPtr user_data);

	[DllImport(Libraries.GLib, EntryPoint = "g_sequence_insert_before")]
	internal static extern GSequenceIterHandle g_sequence_insert_before(this GSequenceIterHandle iter, IntPtr data);

	[DllImport(Libraries.GLib, EntryPoint = "g_sequence_move")]
	internal static extern void g_sequence_move(this GSequenceIterHandle src, GSequenceIterHandle dest);

	[DllImport(Libraries.GLib, EntryPoint = "g_sequence_swap")]
	internal static extern void g_sequence_swap(this GSequenceIterHandle a, GSequenceIterHandle b);

	[DllImport(Libraries.GLib, EntryPoint = "g_sequence_sort_changed")]
	internal static extern void g_sequence_sort_changed(this GSequenceIterHandle iter, GCompareDataFunc cmp_func, IntPtr cmp_data);

	[DllImport(Libraries.GLib, EntryPoint = "g_sequence_sort_changed_iter")]
	internal static extern void g_sequence_sort_changed_iter(this GSequenceIterHandle iter, GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data);

	[DllImport(Libraries.GLib, EntryPoint = "g_sequence_remove")]
	internal static extern void g_sequence_remove(this GSequenceIterHandle iter);

	[DllImport(Libraries.GLib, EntryPoint = "g_sequence_remove_range")]
	internal static extern void g_sequence_remove_range(this GSequenceIterHandle begin, GSequenceIterHandle end);

	[DllImport(Libraries.GLib, EntryPoint = "g_sequence_move_range")]
	internal static extern void g_sequence_move_range(this GSequenceIterHandle dest, GSequenceIterHandle begin, GSequenceIterHandle end);

	[DllImport(Libraries.GLib, EntryPoint = "g_sequence_get")]
	internal static extern IntPtr g_sequence_get(this GSequenceIterHandle iter);

	[DllImport(Libraries.GLib, EntryPoint = "g_sequence_set")]
	internal static extern void g_sequence_set(this GSequenceIterHandle iter, IntPtr data);

	[DllImport(Libraries.GLib, EntryPoint = "g_sequence_iter_is_begin")]
	internal static extern int g_sequence_iter_is_begin(this GSequenceIterHandle iter);

	[DllImport(Libraries.GLib, EntryPoint = "g_sequence_iter_is_end")]
	internal static extern int g_sequence_iter_is_end(this GSequenceIterHandle iter);

	[DllImport(Libraries.GLib, EntryPoint = "g_sequence_iter_next")]
	internal static extern GSequenceIterHandle g_sequence_iter_next(this GSequenceIterHandle iter);

	[DllImport(Libraries.GLib, EntryPoint = "g_sequence_iter_prev")]
	internal static extern GSequenceIterHandle g_sequence_iter_prev(this GSequenceIterHandle iter);

	[DllImport(Libraries.GLib, EntryPoint = "g_sequence_iter_get_position")]
	internal static extern int g_sequence_iter_get_position(this GSequenceIterHandle iter);

	[DllImport(Libraries.GLib, EntryPoint = "g_sequence_iter_move")]
	internal static extern GSequenceIterHandle g_sequence_iter_move(this GSequenceIterHandle iter, int delta);

	[DllImport(Libraries.GLib, EntryPoint = "g_sequence_iter_get_sequence")]
	internal static extern GSequenceHandle g_sequence_iter_get_sequence(this GSequenceIterHandle iter);

	[DllImport(Libraries.GLib, EntryPoint = "g_sequence_iter_compare")]
	internal static extern int g_sequence_iter_compare(this GSequenceIterHandle a, GSequenceIterHandle b);

	[DllImport(Libraries.GLib, EntryPoint = "g_sequence_range_get_midpoint")]
	internal static extern GSequenceIterHandle g_sequence_range_get_midpoint(this GSequenceIterHandle begin, GSequenceIterHandle end);
}
