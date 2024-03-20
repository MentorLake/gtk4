using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;

public static class GtkTreeSelectionExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_selection_set_mode")]
	internal static extern void gtk_tree_selection_set_mode(this GtkTreeSelectionHandle selection, GtkSelectionMode type);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_selection_get_mode")]
	internal static extern GtkSelectionMode gtk_tree_selection_get_mode(this GtkTreeSelectionHandle selection);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_selection_set_select_function")]
	internal static extern void gtk_tree_selection_set_select_function(this GtkTreeSelectionHandle selection, GtkTreeSelectionFunc func, IntPtr data, GDestroyNotify destroy);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_selection_get_user_data")]
	internal static extern IntPtr gtk_tree_selection_get_user_data(this GtkTreeSelectionHandle selection);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_selection_get_tree_view")]
	internal static extern GtkTreeViewHandle gtk_tree_selection_get_tree_view(this GtkTreeSelectionHandle selection);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_selection_get_select_function")]
	internal static extern GtkTreeSelectionFunc gtk_tree_selection_get_select_function(this GtkTreeSelectionHandle selection);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_selection_get_selected")]
	internal static extern int gtk_tree_selection_get_selected(this GtkTreeSelectionHandle selection, out GtkTreeModelHandle model, GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_selection_get_selected_rows")]
	internal static extern GListHandle gtk_tree_selection_get_selected_rows(this GtkTreeSelectionHandle selection, out GtkTreeModelHandle model);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_selection_count_selected_rows")]
	internal static extern int gtk_tree_selection_count_selected_rows(this GtkTreeSelectionHandle selection);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_selection_selected_foreach")]
	internal static extern void gtk_tree_selection_selected_foreach(this GtkTreeSelectionHandle selection, GtkTreeSelectionForeachFunc func, IntPtr data);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_selection_select_path")]
	internal static extern void gtk_tree_selection_select_path(this GtkTreeSelectionHandle selection, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_selection_unselect_path")]
	internal static extern void gtk_tree_selection_unselect_path(this GtkTreeSelectionHandle selection, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_selection_select_iter")]
	internal static extern void gtk_tree_selection_select_iter(this GtkTreeSelectionHandle selection, GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_selection_unselect_iter")]
	internal static extern void gtk_tree_selection_unselect_iter(this GtkTreeSelectionHandle selection, GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_selection_path_is_selected")]
	internal static extern int gtk_tree_selection_path_is_selected(this GtkTreeSelectionHandle selection, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_selection_iter_is_selected")]
	internal static extern int gtk_tree_selection_iter_is_selected(this GtkTreeSelectionHandle selection, GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_selection_select_all")]
	internal static extern void gtk_tree_selection_select_all(this GtkTreeSelectionHandle selection);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_selection_unselect_all")]
	internal static extern void gtk_tree_selection_unselect_all(this GtkTreeSelectionHandle selection);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_selection_select_range")]
	internal static extern void gtk_tree_selection_select_range(this GtkTreeSelectionHandle selection, GtkTreePathHandle start_path, GtkTreePathHandle end_path);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_selection_unselect_range")]
	internal static extern void gtk_tree_selection_unselect_range(this GtkTreeSelectionHandle selection, GtkTreePathHandle start_path, GtkTreePathHandle end_path);
}
