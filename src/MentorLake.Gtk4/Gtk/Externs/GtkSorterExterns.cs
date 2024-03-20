using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkSorterExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_sorter_compare")]
	internal static extern GtkOrdering gtk_sorter_compare(this GtkSorterHandle self, IntPtr item1, IntPtr item2);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_sorter_get_order")]
	internal static extern GtkSorterOrder gtk_sorter_get_order(this GtkSorterHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_sorter_changed")]
	internal static extern void gtk_sorter_changed(this GtkSorterHandle self, GtkSorterChange change);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_list_row_sorter_new")]
	internal static extern GtkTreeListRowSorterHandle gtk_tree_list_row_sorter_new(this GtkSorterHandle sorter);
}
