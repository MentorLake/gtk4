using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkGridLayoutExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_layout_set_row_homogeneous")]
	internal static extern void gtk_grid_layout_set_row_homogeneous(this GtkGridLayoutHandle grid, int homogeneous);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_layout_get_row_homogeneous")]
	internal static extern int gtk_grid_layout_get_row_homogeneous(this GtkGridLayoutHandle grid);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_layout_set_row_spacing")]
	internal static extern void gtk_grid_layout_set_row_spacing(this GtkGridLayoutHandle grid, uint spacing);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_layout_get_row_spacing")]
	internal static extern uint gtk_grid_layout_get_row_spacing(this GtkGridLayoutHandle grid);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_layout_set_column_homogeneous")]
	internal static extern void gtk_grid_layout_set_column_homogeneous(this GtkGridLayoutHandle grid, int homogeneous);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_layout_get_column_homogeneous")]
	internal static extern int gtk_grid_layout_get_column_homogeneous(this GtkGridLayoutHandle grid);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_layout_set_column_spacing")]
	internal static extern void gtk_grid_layout_set_column_spacing(this GtkGridLayoutHandle grid, uint spacing);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_layout_get_column_spacing")]
	internal static extern uint gtk_grid_layout_get_column_spacing(this GtkGridLayoutHandle grid);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_layout_set_row_baseline_position")]
	internal static extern void gtk_grid_layout_set_row_baseline_position(this GtkGridLayoutHandle grid, int row, GtkBaselinePosition pos);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_layout_get_row_baseline_position")]
	internal static extern GtkBaselinePosition gtk_grid_layout_get_row_baseline_position(this GtkGridLayoutHandle grid, int row);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_layout_set_baseline_row")]
	internal static extern void gtk_grid_layout_set_baseline_row(this GtkGridLayoutHandle grid, int row);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_layout_get_baseline_row")]
	internal static extern int gtk_grid_layout_get_baseline_row(this GtkGridLayoutHandle grid);
}
