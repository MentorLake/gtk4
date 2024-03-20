using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkTreeListRowSorterExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_list_row_sorter_get_sorter")]
	internal static extern GtkSorterHandle gtk_tree_list_row_sorter_get_sorter(this GtkTreeListRowSorterHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_list_row_sorter_set_sorter")]
	internal static extern void gtk_tree_list_row_sorter_set_sorter(this GtkTreeListRowSorterHandle self, GtkSorterHandle sorter);
}
