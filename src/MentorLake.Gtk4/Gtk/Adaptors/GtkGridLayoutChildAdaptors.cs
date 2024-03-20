using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkGridLayoutChildAdaptors
{
    public static GtkGridLayoutChildHandle SetRow(this GtkGridLayoutChildHandle child, int row)
    {
        GtkGridLayoutChildExterns.gtk_grid_layout_child_set_row(child, row);
        return child;
    }

    public static int GetRow(this GtkGridLayoutChildHandle child)
    {
        return GtkGridLayoutChildExterns.gtk_grid_layout_child_get_row(child);
    }

    public static GtkGridLayoutChildHandle SetColumn(this GtkGridLayoutChildHandle child, int column)
    {
        GtkGridLayoutChildExterns.gtk_grid_layout_child_set_column(child, column);
        return child;
    }

    public static int GetColumn(this GtkGridLayoutChildHandle child)
    {
        return GtkGridLayoutChildExterns.gtk_grid_layout_child_get_column(child);
    }

    public static GtkGridLayoutChildHandle SetColumnSpan(this GtkGridLayoutChildHandle child, int span)
    {
        GtkGridLayoutChildExterns.gtk_grid_layout_child_set_column_span(child, span);
        return child;
    }

    public static int GetColumnSpan(this GtkGridLayoutChildHandle child)
    {
        return GtkGridLayoutChildExterns.gtk_grid_layout_child_get_column_span(child);
    }

    public static GtkGridLayoutChildHandle SetRowSpan(this GtkGridLayoutChildHandle child, int span)
    {
        GtkGridLayoutChildExterns.gtk_grid_layout_child_set_row_span(child, span);
        return child;
    }

    public static int GetRowSpan(this GtkGridLayoutChildHandle child)
    {
        return GtkGridLayoutChildExterns.gtk_grid_layout_child_get_row_span(child);
    }
}
