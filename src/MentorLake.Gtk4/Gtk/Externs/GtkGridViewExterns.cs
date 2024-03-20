using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkGridViewExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_view_get_model")]
	internal static extern GtkSelectionModelHandle gtk_grid_view_get_model(this GtkGridViewHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_view_set_model")]
	internal static extern void gtk_grid_view_set_model(this GtkGridViewHandle self, GtkSelectionModelHandle model);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_view_set_factory")]
	internal static extern void gtk_grid_view_set_factory(this GtkGridViewHandle self, GtkListItemFactoryHandle factory);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_view_get_factory")]
	internal static extern GtkListItemFactoryHandle gtk_grid_view_get_factory(this GtkGridViewHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_view_get_min_columns")]
	internal static extern uint gtk_grid_view_get_min_columns(this GtkGridViewHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_view_set_min_columns")]
	internal static extern void gtk_grid_view_set_min_columns(this GtkGridViewHandle self, uint min_columns);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_view_get_max_columns")]
	internal static extern uint gtk_grid_view_get_max_columns(this GtkGridViewHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_view_set_max_columns")]
	internal static extern void gtk_grid_view_set_max_columns(this GtkGridViewHandle self, uint max_columns);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_view_set_enable_rubberband")]
	internal static extern void gtk_grid_view_set_enable_rubberband(this GtkGridViewHandle self, int enable_rubberband);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_view_get_enable_rubberband")]
	internal static extern int gtk_grid_view_get_enable_rubberband(this GtkGridViewHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_view_set_single_click_activate")]
	internal static extern void gtk_grid_view_set_single_click_activate(this GtkGridViewHandle self, int single_click_activate);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_view_get_single_click_activate")]
	internal static extern int gtk_grid_view_get_single_click_activate(this GtkGridViewHandle self);
}
