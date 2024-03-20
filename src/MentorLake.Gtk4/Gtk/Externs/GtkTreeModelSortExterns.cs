using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkTreeModelSortExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_sort_get_model")]
	internal static extern GtkTreeModelHandle gtk_tree_model_sort_get_model(this GtkTreeModelSortHandle tree_model);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_sort_convert_child_path_to_path")]
	internal static extern GtkTreePathHandle gtk_tree_model_sort_convert_child_path_to_path(this GtkTreeModelSortHandle tree_model_sort, GtkTreePathHandle child_path);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_sort_convert_child_iter_to_iter")]
	internal static extern int gtk_tree_model_sort_convert_child_iter_to_iter(this GtkTreeModelSortHandle tree_model_sort, GtkTreeIterHandle sort_iter, GtkTreeIterHandle child_iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_sort_convert_path_to_child_path")]
	internal static extern GtkTreePathHandle gtk_tree_model_sort_convert_path_to_child_path(this GtkTreeModelSortHandle tree_model_sort, GtkTreePathHandle sorted_path);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_sort_convert_iter_to_child_iter")]
	internal static extern void gtk_tree_model_sort_convert_iter_to_child_iter(this GtkTreeModelSortHandle tree_model_sort, GtkTreeIterHandle child_iter, GtkTreeIterHandle sorted_iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_sort_reset_default_sort_func")]
	internal static extern void gtk_tree_model_sort_reset_default_sort_func(this GtkTreeModelSortHandle tree_model_sort);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_sort_clear_cache")]
	internal static extern void gtk_tree_model_sort_clear_cache(this GtkTreeModelSortHandle tree_model_sort);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_sort_iter_is_valid")]
	internal static extern int gtk_tree_model_sort_iter_is_valid(this GtkTreeModelSortHandle tree_model_sort, GtkTreeIterHandle iter);
}
