using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkGridLayoutChildExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_layout_child_set_row")]
	internal static extern void gtk_grid_layout_child_set_row(this GtkGridLayoutChildHandle child, int row);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_layout_child_get_row")]
	internal static extern int gtk_grid_layout_child_get_row(this GtkGridLayoutChildHandle child);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_layout_child_set_column")]
	internal static extern void gtk_grid_layout_child_set_column(this GtkGridLayoutChildHandle child, int column);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_layout_child_get_column")]
	internal static extern int gtk_grid_layout_child_get_column(this GtkGridLayoutChildHandle child);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_layout_child_set_column_span")]
	internal static extern void gtk_grid_layout_child_set_column_span(this GtkGridLayoutChildHandle child, int span);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_layout_child_get_column_span")]
	internal static extern int gtk_grid_layout_child_get_column_span(this GtkGridLayoutChildHandle child);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_layout_child_set_row_span")]
	internal static extern void gtk_grid_layout_child_set_row_span(this GtkGridLayoutChildHandle child, int span);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_layout_child_get_row_span")]
	internal static extern int gtk_grid_layout_child_get_row_span(this GtkGridLayoutChildHandle child);
}
