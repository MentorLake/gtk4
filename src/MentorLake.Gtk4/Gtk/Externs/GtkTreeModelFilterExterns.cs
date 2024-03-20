using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;

public static class GtkTreeModelFilterExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_filter_set_visible_func")]
	internal static extern void gtk_tree_model_filter_set_visible_func(this GtkTreeModelFilterHandle filter, GtkTreeModelFilterVisibleFunc func, IntPtr data, GDestroyNotify destroy);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_filter_set_modify_func")]
	internal static extern void gtk_tree_model_filter_set_modify_func(this GtkTreeModelFilterHandle filter, int n_columns, GTypeHandle types, GtkTreeModelFilterModifyFunc func, IntPtr data, GDestroyNotify destroy);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_filter_set_visible_column")]
	internal static extern void gtk_tree_model_filter_set_visible_column(this GtkTreeModelFilterHandle filter, int column);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_filter_get_model")]
	internal static extern GtkTreeModelHandle gtk_tree_model_filter_get_model(this GtkTreeModelFilterHandle filter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_filter_convert_child_iter_to_iter")]
	internal static extern int gtk_tree_model_filter_convert_child_iter_to_iter(this GtkTreeModelFilterHandle filter, GtkTreeIterHandle filter_iter, GtkTreeIterHandle child_iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_filter_convert_iter_to_child_iter")]
	internal static extern void gtk_tree_model_filter_convert_iter_to_child_iter(this GtkTreeModelFilterHandle filter, GtkTreeIterHandle child_iter, GtkTreeIterHandle filter_iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_filter_convert_child_path_to_path")]
	internal static extern GtkTreePathHandle gtk_tree_model_filter_convert_child_path_to_path(this GtkTreeModelFilterHandle filter, GtkTreePathHandle child_path);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_filter_convert_path_to_child_path")]
	internal static extern GtkTreePathHandle gtk_tree_model_filter_convert_path_to_child_path(this GtkTreeModelFilterHandle filter, GtkTreePathHandle filter_path);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_filter_refilter")]
	internal static extern void gtk_tree_model_filter_refilter(this GtkTreeModelFilterHandle filter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_filter_clear_cache")]
	internal static extern void gtk_tree_model_filter_clear_cache(this GtkTreeModelFilterHandle filter);
}
