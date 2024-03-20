using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkGridLayoutAdaptors
{
    public static GtkGridLayoutHandle SetRowHomogeneous(this GtkGridLayoutHandle grid, int homogeneous)
    {
        GtkGridLayoutExterns.gtk_grid_layout_set_row_homogeneous(grid, homogeneous);
        return grid;
    }

    public static int GetRowHomogeneous(this GtkGridLayoutHandle grid)
    {
        return GtkGridLayoutExterns.gtk_grid_layout_get_row_homogeneous(grid);
    }

    public static GtkGridLayoutHandle SetRowSpacing(this GtkGridLayoutHandle grid, uint spacing)
    {
        GtkGridLayoutExterns.gtk_grid_layout_set_row_spacing(grid, spacing);
        return grid;
    }

    public static uint GetRowSpacing(this GtkGridLayoutHandle grid)
    {
        return GtkGridLayoutExterns.gtk_grid_layout_get_row_spacing(grid);
    }

    public static GtkGridLayoutHandle SetColumnHomogeneous(this GtkGridLayoutHandle grid, int homogeneous)
    {
        GtkGridLayoutExterns.gtk_grid_layout_set_column_homogeneous(grid, homogeneous);
        return grid;
    }

    public static int GetColumnHomogeneous(this GtkGridLayoutHandle grid)
    {
        return GtkGridLayoutExterns.gtk_grid_layout_get_column_homogeneous(grid);
    }

    public static GtkGridLayoutHandle SetColumnSpacing(this GtkGridLayoutHandle grid, uint spacing)
    {
        GtkGridLayoutExterns.gtk_grid_layout_set_column_spacing(grid, spacing);
        return grid;
    }

    public static uint GetColumnSpacing(this GtkGridLayoutHandle grid)
    {
        return GtkGridLayoutExterns.gtk_grid_layout_get_column_spacing(grid);
    }

    public static GtkGridLayoutHandle SetRowBaselinePosition(this GtkGridLayoutHandle grid, int row, GtkBaselinePosition pos)
    {
        GtkGridLayoutExterns.gtk_grid_layout_set_row_baseline_position(grid, row, pos);
        return grid;
    }

    public static GtkBaselinePosition GetRowBaselinePosition(this GtkGridLayoutHandle grid, int row)
    {
        return GtkGridLayoutExterns.gtk_grid_layout_get_row_baseline_position(grid, row);
    }

    public static GtkGridLayoutHandle SetBaselineRow(this GtkGridLayoutHandle grid, int row)
    {
        GtkGridLayoutExterns.gtk_grid_layout_set_baseline_row(grid, row);
        return grid;
    }

    public static int GetBaselineRow(this GtkGridLayoutHandle grid)
    {
        return GtkGridLayoutExterns.gtk_grid_layout_get_baseline_row(grid);
    }
}
