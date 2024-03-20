using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;

public static class GListExterns
{
	[DllImport(Libraries.GLib, EntryPoint = "g_list_free")]
	internal static extern void g_list_free(this GListHandle list);

	[DllImport(Libraries.GLib, EntryPoint = "g_list_free_1")]
	internal static extern void g_list_free_1(this GListHandle list);

	[DllImport(Libraries.GLib, EntryPoint = "g_list_free_full")]
	internal static extern void g_list_free_full(this GListHandle list, GDestroyNotify free_func);

	[DllImport(Libraries.GLib, EntryPoint = "g_list_append")]
	internal static extern GListHandle g_list_append(this GListHandle list, IntPtr data);

	[DllImport(Libraries.GLib, EntryPoint = "g_list_prepend")]
	internal static extern GListHandle g_list_prepend(this GListHandle list, IntPtr data);

	[DllImport(Libraries.GLib, EntryPoint = "g_list_insert")]
	internal static extern GListHandle g_list_insert(this GListHandle list, IntPtr data, int position);

	[DllImport(Libraries.GLib, EntryPoint = "g_list_insert_sorted")]
	internal static extern GListHandle g_list_insert_sorted(this GListHandle list, IntPtr data, GCompareFunc func);

	[DllImport(Libraries.GLib, EntryPoint = "g_list_insert_sorted_with_data")]
	internal static extern GListHandle g_list_insert_sorted_with_data(this GListHandle list, IntPtr data, GCompareDataFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib, EntryPoint = "g_list_insert_before")]
	internal static extern GListHandle g_list_insert_before(this GListHandle list, GListHandle sibling, IntPtr data);

	[DllImport(Libraries.GLib, EntryPoint = "g_list_insert_before_link")]
	internal static extern GListHandle g_list_insert_before_link(this GListHandle list, GListHandle sibling, GListHandle link_);

	[DllImport(Libraries.GLib, EntryPoint = "g_list_concat")]
	internal static extern GListHandle g_list_concat(this GListHandle list1, GListHandle list2);

	[DllImport(Libraries.GLib, EntryPoint = "g_list_remove")]
	internal static extern GListHandle g_list_remove(this GListHandle list, IntPtr data);

	[DllImport(Libraries.GLib, EntryPoint = "g_list_remove_all")]
	internal static extern GListHandle g_list_remove_all(this GListHandle list, IntPtr data);

	[DllImport(Libraries.GLib, EntryPoint = "g_list_remove_link")]
	internal static extern GListHandle g_list_remove_link(this GListHandle list, GListHandle llink);

	[DllImport(Libraries.GLib, EntryPoint = "g_list_delete_link")]
	internal static extern GListHandle g_list_delete_link(this GListHandle list, GListHandle link_);

	[DllImport(Libraries.GLib, EntryPoint = "g_list_reverse")]
	internal static extern GListHandle g_list_reverse(this GListHandle list);

	[DllImport(Libraries.GLib, EntryPoint = "g_list_copy")]
	internal static extern GListHandle g_list_copy(this GListHandle list);

	[DllImport(Libraries.GLib, EntryPoint = "g_list_copy_deep")]
	internal static extern GListHandle g_list_copy_deep(this GListHandle list, GCopyFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib, EntryPoint = "g_list_nth")]
	internal static extern GListHandle g_list_nth(this GListHandle list, uint n);

	[DllImport(Libraries.GLib, EntryPoint = "g_list_nth_prev")]
	internal static extern GListHandle g_list_nth_prev(this GListHandle list, uint n);

	[DllImport(Libraries.GLib, EntryPoint = "g_list_find")]
	internal static extern GListHandle g_list_find(this GListHandle list, IntPtr data);

	[DllImport(Libraries.GLib, EntryPoint = "g_list_find_custom")]
	internal static extern GListHandle g_list_find_custom(this GListHandle list, IntPtr data, GCompareFunc func);

	[DllImport(Libraries.GLib, EntryPoint = "g_list_position")]
	internal static extern int g_list_position(this GListHandle list, GListHandle llink);

	[DllImport(Libraries.GLib, EntryPoint = "g_list_index")]
	internal static extern int g_list_index(this GListHandle list, IntPtr data);

	[DllImport(Libraries.GLib, EntryPoint = "g_list_last")]
	internal static extern GListHandle g_list_last(this GListHandle list);

	[DllImport(Libraries.GLib, EntryPoint = "g_list_first")]
	internal static extern GListHandle g_list_first(this GListHandle list);

	[DllImport(Libraries.GLib, EntryPoint = "g_list_length")]
	internal static extern uint g_list_length(this GListHandle list);

	[DllImport(Libraries.GLib, EntryPoint = "g_list_foreach")]
	internal static extern void g_list_foreach(this GListHandle list, IntPtr func, IntPtr user_data);

	[DllImport(Libraries.GLib, EntryPoint = "g_list_sort")]
	internal static extern GListHandle g_list_sort(this GListHandle list, GCompareFunc compare_func);

	[DllImport(Libraries.GLib, EntryPoint = "g_list_sort_with_data")]
	internal static extern GListHandle g_list_sort_with_data(this GListHandle list, GCompareDataFunc compare_func, IntPtr user_data);

	[DllImport(Libraries.GLib, EntryPoint = "g_list_nth_data")]
	internal static extern IntPtr g_list_nth_data(this GListHandle list, uint n);
}
