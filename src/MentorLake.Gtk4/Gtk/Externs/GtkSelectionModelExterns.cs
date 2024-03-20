using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkSelectionModelExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_selection_model_is_selected")]
	internal static extern int gtk_selection_model_is_selected(this GtkSelectionModelHandle model, uint position);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_selection_model_get_selection")]
	internal static extern GtkBitsetHandle gtk_selection_model_get_selection(this GtkSelectionModelHandle model);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_selection_model_get_selection_in_range")]
	internal static extern GtkBitsetHandle gtk_selection_model_get_selection_in_range(this GtkSelectionModelHandle model, uint position, uint n_items);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_selection_model_select_item")]
	internal static extern int gtk_selection_model_select_item(this GtkSelectionModelHandle model, uint position, int unselect_rest);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_selection_model_unselect_item")]
	internal static extern int gtk_selection_model_unselect_item(this GtkSelectionModelHandle model, uint position);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_selection_model_select_range")]
	internal static extern int gtk_selection_model_select_range(this GtkSelectionModelHandle model, uint position, uint n_items, int unselect_rest);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_selection_model_unselect_range")]
	internal static extern int gtk_selection_model_unselect_range(this GtkSelectionModelHandle model, uint position, uint n_items);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_selection_model_select_all")]
	internal static extern int gtk_selection_model_select_all(this GtkSelectionModelHandle model);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_selection_model_unselect_all")]
	internal static extern int gtk_selection_model_unselect_all(this GtkSelectionModelHandle model);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_selection_model_set_selection")]
	internal static extern int gtk_selection_model_set_selection(this GtkSelectionModelHandle model, GtkBitsetHandle selected, GtkBitsetHandle mask);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_selection_model_selection_changed")]
	internal static extern void gtk_selection_model_selection_changed(this GtkSelectionModelHandle model, uint position, uint n_items);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_new")]
	internal static extern GtkColumnViewHandle gtk_column_view_new(this GtkSelectionModelHandle model);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_view_new")]
	internal static extern GtkGridViewHandle gtk_grid_view_new(this GtkSelectionModelHandle model, GtkListItemFactoryHandle factory);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_list_view_new")]
	internal static extern GtkListViewHandle gtk_list_view_new(this GtkSelectionModelHandle model, GtkListItemFactoryHandle factory);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_selection_filter_model_new")]
	internal static extern GtkSelectionFilterModelHandle gtk_selection_filter_model_new(this GtkSelectionModelHandle model);
}
