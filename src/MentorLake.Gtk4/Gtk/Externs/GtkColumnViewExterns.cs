using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;

public static class GtkColumnViewExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_get_columns")]
	internal static extern GListModelHandle gtk_column_view_get_columns(this GtkColumnViewHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_append_column")]
	internal static extern void gtk_column_view_append_column(this GtkColumnViewHandle self, GtkColumnViewColumnHandle column);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_remove_column")]
	internal static extern void gtk_column_view_remove_column(this GtkColumnViewHandle self, GtkColumnViewColumnHandle column);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_insert_column")]
	internal static extern void gtk_column_view_insert_column(this GtkColumnViewHandle self, uint position, GtkColumnViewColumnHandle column);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_get_model")]
	internal static extern GtkSelectionModelHandle gtk_column_view_get_model(this GtkColumnViewHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_set_model")]
	internal static extern void gtk_column_view_set_model(this GtkColumnViewHandle self, GtkSelectionModelHandle model);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_get_show_row_separators")]
	internal static extern int gtk_column_view_get_show_row_separators(this GtkColumnViewHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_set_show_row_separators")]
	internal static extern void gtk_column_view_set_show_row_separators(this GtkColumnViewHandle self, int show_row_separators);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_get_show_column_separators")]
	internal static extern int gtk_column_view_get_show_column_separators(this GtkColumnViewHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_set_show_column_separators")]
	internal static extern void gtk_column_view_set_show_column_separators(this GtkColumnViewHandle self, int show_column_separators);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_get_sorter")]
	internal static extern GtkSorterHandle gtk_column_view_get_sorter(this GtkColumnViewHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_sort_by_column")]
	internal static extern void gtk_column_view_sort_by_column(this GtkColumnViewHandle self, GtkColumnViewColumnHandle column, GtkSortType direction);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_set_single_click_activate")]
	internal static extern void gtk_column_view_set_single_click_activate(this GtkColumnViewHandle self, int single_click_activate);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_get_single_click_activate")]
	internal static extern int gtk_column_view_get_single_click_activate(this GtkColumnViewHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_set_reorderable")]
	internal static extern void gtk_column_view_set_reorderable(this GtkColumnViewHandle self, int reorderable);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_get_reorderable")]
	internal static extern int gtk_column_view_get_reorderable(this GtkColumnViewHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_set_enable_rubberband")]
	internal static extern void gtk_column_view_set_enable_rubberband(this GtkColumnViewHandle self, int enable_rubberband);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_column_view_get_enable_rubberband")]
	internal static extern int gtk_column_view_get_enable_rubberband(this GtkColumnViewHandle self);
}
