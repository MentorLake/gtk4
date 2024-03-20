using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;

public static class GtkTreeListRowExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_list_row_get_item")]
	internal static extern IntPtr gtk_tree_list_row_get_item(this GtkTreeListRowHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_list_row_set_expanded")]
	internal static extern void gtk_tree_list_row_set_expanded(this GtkTreeListRowHandle self, int expanded);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_list_row_get_expanded")]
	internal static extern int gtk_tree_list_row_get_expanded(this GtkTreeListRowHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_list_row_is_expandable")]
	internal static extern int gtk_tree_list_row_is_expandable(this GtkTreeListRowHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_list_row_get_position")]
	internal static extern uint gtk_tree_list_row_get_position(this GtkTreeListRowHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_list_row_get_depth")]
	internal static extern uint gtk_tree_list_row_get_depth(this GtkTreeListRowHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_list_row_get_children")]
	internal static extern GListModelHandle gtk_tree_list_row_get_children(this GtkTreeListRowHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_list_row_get_parent")]
	internal static extern GtkTreeListRowHandle gtk_tree_list_row_get_parent(this GtkTreeListRowHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_list_row_get_child_row")]
	internal static extern GtkTreeListRowHandle gtk_tree_list_row_get_child_row(this GtkTreeListRowHandle self, uint position);
}
