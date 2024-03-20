using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkGridExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_attach")]
    internal static extern void gtk_grid_attach(this GtkGridHandle grid, GtkWidgetHandle child, int column, int row, int width, int height);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_attach_next_to")]
    internal static extern void gtk_grid_attach_next_to(this GtkGridHandle grid, GtkWidgetHandle child, GtkWidgetHandle sibling, GtkPositionType side, int width, int height);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_get_child_at")]
    internal static extern GtkWidgetHandle gtk_grid_get_child_at(this GtkGridHandle grid, int column, int row);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_remove")]
    internal static extern void gtk_grid_remove(this GtkGridHandle grid, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_insert_row")]
    internal static extern void gtk_grid_insert_row(this GtkGridHandle grid, int position);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_insert_column")]
    internal static extern void gtk_grid_insert_column(this GtkGridHandle grid, int position);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_remove_row")]
    internal static extern void gtk_grid_remove_row(this GtkGridHandle grid, int position);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_remove_column")]
    internal static extern void gtk_grid_remove_column(this GtkGridHandle grid, int position);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_insert_next_to")]
    internal static extern void gtk_grid_insert_next_to(this GtkGridHandle grid, GtkWidgetHandle sibling, GtkPositionType side);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_set_row_homogeneous")]
    internal static extern void gtk_grid_set_row_homogeneous(this GtkGridHandle grid, int homogeneous);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_get_row_homogeneous")]
    internal static extern int gtk_grid_get_row_homogeneous(this GtkGridHandle grid);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_set_row_spacing")]
    internal static extern void gtk_grid_set_row_spacing(this GtkGridHandle grid, uint spacing);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_get_row_spacing")]
    internal static extern uint gtk_grid_get_row_spacing(this GtkGridHandle grid);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_set_column_homogeneous")]
    internal static extern void gtk_grid_set_column_homogeneous(this GtkGridHandle grid, int homogeneous);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_get_column_homogeneous")]
    internal static extern int gtk_grid_get_column_homogeneous(this GtkGridHandle grid);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_set_column_spacing")]
    internal static extern void gtk_grid_set_column_spacing(this GtkGridHandle grid, uint spacing);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_get_column_spacing")]
    internal static extern uint gtk_grid_get_column_spacing(this GtkGridHandle grid);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_set_row_baseline_position")]
    internal static extern void gtk_grid_set_row_baseline_position(this GtkGridHandle grid, int row, GtkBaselinePosition pos);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_get_row_baseline_position")]
    internal static extern GtkBaselinePosition gtk_grid_get_row_baseline_position(this GtkGridHandle grid, int row);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_set_baseline_row")]
    internal static extern void gtk_grid_set_baseline_row(this GtkGridHandle grid, int row);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_get_baseline_row")]
    internal static extern int gtk_grid_get_baseline_row(this GtkGridHandle grid);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_grid_query_child")]
    internal static extern void gtk_grid_query_child(this GtkGridHandle grid, GtkWidgetHandle child, out int column, out int row, out int width, out int height);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkGridHandle gtk_grid_new();
}
