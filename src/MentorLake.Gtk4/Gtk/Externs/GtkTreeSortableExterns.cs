using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;

public static class GtkTreeSortableExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_sortable_sort_column_changed")]
	internal static extern void gtk_tree_sortable_sort_column_changed(this GtkTreeSortableHandle sortable);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_sortable_get_sort_column_id")]
	internal static extern int gtk_tree_sortable_get_sort_column_id(this GtkTreeSortableHandle sortable, out int sort_column_id, out GtkSortType order);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_sortable_set_sort_column_id")]
	internal static extern void gtk_tree_sortable_set_sort_column_id(this GtkTreeSortableHandle sortable, int sort_column_id, GtkSortType order);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_sortable_set_sort_func")]
	internal static extern void gtk_tree_sortable_set_sort_func(this GtkTreeSortableHandle sortable, int sort_column_id, GtkTreeIterCompareFunc sort_func, IntPtr user_data, GDestroyNotify destroy);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_sortable_set_default_sort_func")]
	internal static extern void gtk_tree_sortable_set_default_sort_func(this GtkTreeSortableHandle sortable, GtkTreeIterCompareFunc sort_func, IntPtr user_data, GDestroyNotify destroy);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_sortable_has_default_sort_func")]
	internal static extern int gtk_tree_sortable_has_default_sort_func(this GtkTreeSortableHandle sortable);
}
