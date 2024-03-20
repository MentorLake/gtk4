using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;

public static class GSListExterns
{
	[DllImport(Libraries.GLib, EntryPoint = "g_slist_free")]
	internal static extern void g_slist_free(this GSListHandle list);

	[DllImport(Libraries.GLib, EntryPoint = "g_slist_free_1")]
	internal static extern void g_slist_free_1(this GSListHandle list);

	[DllImport(Libraries.GLib, EntryPoint = "g_slist_free_full")]
	internal static extern void g_slist_free_full(this GSListHandle list, GDestroyNotify free_func);

	[DllImport(Libraries.GLib, EntryPoint = "g_slist_append")]
	internal static extern GSListHandle g_slist_append(this GSListHandle list, IntPtr data);

	[DllImport(Libraries.GLib, EntryPoint = "g_slist_prepend")]
	internal static extern GSListHandle g_slist_prepend(this GSListHandle list, IntPtr data);

	[DllImport(Libraries.GLib, EntryPoint = "g_slist_insert")]
	internal static extern GSListHandle g_slist_insert(this GSListHandle list, IntPtr data, int position);

	[DllImport(Libraries.GLib, EntryPoint = "g_slist_insert_sorted")]
	internal static extern GSListHandle g_slist_insert_sorted(this GSListHandle list, IntPtr data, GCompareFunc func);

	[DllImport(Libraries.GLib, EntryPoint = "g_slist_insert_sorted_with_data")]
	internal static extern GSListHandle g_slist_insert_sorted_with_data(this GSListHandle list, IntPtr data, GCompareDataFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib, EntryPoint = "g_slist_insert_before")]
	internal static extern GSListHandle g_slist_insert_before(this GSListHandle slist, GSListHandle sibling, IntPtr data);

	[DllImport(Libraries.GLib, EntryPoint = "g_slist_concat")]
	internal static extern GSListHandle g_slist_concat(this GSListHandle list1, GSListHandle list2);

	[DllImport(Libraries.GLib, EntryPoint = "g_slist_remove")]
	internal static extern GSListHandle g_slist_remove(this GSListHandle list, IntPtr data);

	[DllImport(Libraries.GLib, EntryPoint = "g_slist_remove_all")]
	internal static extern GSListHandle g_slist_remove_all(this GSListHandle list, IntPtr data);

	[DllImport(Libraries.GLib, EntryPoint = "g_slist_remove_link")]
	internal static extern GSListHandle g_slist_remove_link(this GSListHandle list, GSListHandle link_);

	[DllImport(Libraries.GLib, EntryPoint = "g_slist_delete_link")]
	internal static extern GSListHandle g_slist_delete_link(this GSListHandle list, GSListHandle link_);

	[DllImport(Libraries.GLib, EntryPoint = "g_slist_reverse")]
	internal static extern GSListHandle g_slist_reverse(this GSListHandle list);

	[DllImport(Libraries.GLib, EntryPoint = "g_slist_copy")]
	internal static extern GSListHandle g_slist_copy(this GSListHandle list);

	[DllImport(Libraries.GLib, EntryPoint = "g_slist_copy_deep")]
	internal static extern GSListHandle g_slist_copy_deep(this GSListHandle list, GCopyFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib, EntryPoint = "g_slist_nth")]
	internal static extern GSListHandle g_slist_nth(this GSListHandle list, uint n);

	[DllImport(Libraries.GLib, EntryPoint = "g_slist_find")]
	internal static extern GSListHandle g_slist_find(this GSListHandle list, IntPtr data);

	[DllImport(Libraries.GLib, EntryPoint = "g_slist_find_custom")]
	internal static extern GSListHandle g_slist_find_custom(this GSListHandle list, IntPtr data, GCompareFunc func);

	[DllImport(Libraries.GLib, EntryPoint = "g_slist_position")]
	internal static extern int g_slist_position(this GSListHandle list, GSListHandle llink);

	[DllImport(Libraries.GLib, EntryPoint = "g_slist_index")]
	internal static extern int g_slist_index(this GSListHandle list, IntPtr data);

	[DllImport(Libraries.GLib, EntryPoint = "g_slist_last")]
	internal static extern GSListHandle g_slist_last(this GSListHandle list);

	[DllImport(Libraries.GLib, EntryPoint = "g_slist_length")]
	internal static extern uint g_slist_length(this GSListHandle list);

	[DllImport(Libraries.GLib, EntryPoint = "g_slist_foreach")]
	internal static extern void g_slist_foreach(this GSListHandle list, IntPtr func, IntPtr user_data);

	[DllImport(Libraries.GLib, EntryPoint = "g_slist_sort")]
	internal static extern GSListHandle g_slist_sort(this GSListHandle list, GCompareFunc compare_func);

	[DllImport(Libraries.GLib, EntryPoint = "g_slist_sort_with_data")]
	internal static extern GSListHandle g_slist_sort_with_data(this GSListHandle list, GCompareDataFunc compare_func, IntPtr user_data);

	[DllImport(Libraries.GLib, EntryPoint = "g_slist_nth_data")]
	internal static extern IntPtr g_slist_nth_data(this GSListHandle list, uint n);
}
