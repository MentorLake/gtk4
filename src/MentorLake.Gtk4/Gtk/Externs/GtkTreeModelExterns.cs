using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;

public static class GtkTreeModelExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_get_flags")]
	internal static extern GtkTreeModelFlags gtk_tree_model_get_flags(this GtkTreeModelHandle tree_model);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_get_n_columns")]
	internal static extern int gtk_tree_model_get_n_columns(this GtkTreeModelHandle tree_model);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_get_column_type")]
	internal static extern GType gtk_tree_model_get_column_type(this GtkTreeModelHandle tree_model, int index_);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_get_iter")]
	internal static extern int gtk_tree_model_get_iter(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_get_iter_from_string")]
	internal static extern int gtk_tree_model_get_iter_from_string(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter, string path_string);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_get_string_from_iter")]
	internal static extern string gtk_tree_model_get_string_from_iter(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_get_iter_first")]
	internal static extern int gtk_tree_model_get_iter_first(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_get_path")]
	internal static extern GtkTreePathHandle gtk_tree_model_get_path(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_get_value")]
	internal static extern void gtk_tree_model_get_value(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter, int column, GValueHandle value);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_iter_previous")]
	internal static extern int gtk_tree_model_iter_previous(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_iter_next")]
	internal static extern int gtk_tree_model_iter_next(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_iter_children")]
	internal static extern int gtk_tree_model_iter_children(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter, GtkTreeIterHandle parent);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_iter_has_child")]
	internal static extern int gtk_tree_model_iter_has_child(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_iter_n_children")]
	internal static extern int gtk_tree_model_iter_n_children(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_iter_nth_child")]
	internal static extern int gtk_tree_model_iter_nth_child(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter, GtkTreeIterHandle parent, int n);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_iter_parent")]
	internal static extern int gtk_tree_model_iter_parent(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter, GtkTreeIterHandle child);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_ref_node")]
	internal static extern void gtk_tree_model_ref_node(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_unref_node")]
	internal static extern void gtk_tree_model_unref_node(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_get")]
	internal static extern void gtk_tree_model_get(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter, IntPtr @__argList);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_get_valist")]
	internal static extern void gtk_tree_model_get_valist(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter, IntPtr @__argList);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_foreach")]
	internal static extern void gtk_tree_model_foreach(this GtkTreeModelHandle model, GtkTreeModelForeachFunc func, IntPtr user_data);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_row_changed")]
	internal static extern void gtk_tree_model_row_changed(this GtkTreeModelHandle tree_model, GtkTreePathHandle path, GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_row_inserted")]
	internal static extern void gtk_tree_model_row_inserted(this GtkTreeModelHandle tree_model, GtkTreePathHandle path, GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_row_has_child_toggled")]
	internal static extern void gtk_tree_model_row_has_child_toggled(this GtkTreeModelHandle tree_model, GtkTreePathHandle path, GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_row_deleted")]
	internal static extern void gtk_tree_model_row_deleted(this GtkTreeModelHandle tree_model, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_rows_reordered")]
	internal static extern void gtk_tree_model_rows_reordered(this GtkTreeModelHandle tree_model, GtkTreePathHandle path, GtkTreeIterHandle iter, int[] new_order);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_rows_reordered_with_length")]
	internal static extern void gtk_tree_model_rows_reordered_with_length(this GtkTreeModelHandle tree_model, GtkTreePathHandle path, GtkTreeIterHandle iter, int[] new_order, int length);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_filter_new")]
	internal static extern GtkTreeModelHandle gtk_tree_model_filter_new(this GtkTreeModelHandle child_model, GtkTreePathHandle root);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_new_with_model")]
	internal static extern GtkTreeViewHandle gtk_tree_view_new_with_model(this GtkTreeModelHandle model);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_combo_box_new_with_model")]
	internal static extern GtkComboBoxHandle gtk_combo_box_new_with_model(this GtkTreeModelHandle model);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_combo_box_new_with_model_and_entry")]
	internal static extern GtkComboBoxHandle gtk_combo_box_new_with_model_and_entry(this GtkTreeModelHandle model);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_new_with_model")]
	internal static extern GtkIconViewHandle gtk_icon_view_new_with_model(this GtkTreeModelHandle model);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_create_row_drag_content")]
	internal static extern GdkContentProviderHandle gtk_tree_create_row_drag_content(this GtkTreeModelHandle tree_model, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_model_sort_new_with_model")]
	internal static extern GtkTreeModelHandle gtk_tree_model_sort_new_with_model(this GtkTreeModelHandle child_model);
}
