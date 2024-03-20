using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkColumnViewAdaptors
{
    public static GListModelHandle GetColumns(this GtkColumnViewHandle self)
    {
        return GtkColumnViewExterns.gtk_column_view_get_columns(self);
    }

    public static GtkColumnViewHandle AppendColumn(this GtkColumnViewHandle self, GtkColumnViewColumnHandle column)
    {
        GtkColumnViewExterns.gtk_column_view_append_column(self, column);
        return self;
    }

    public static GtkColumnViewHandle RemoveColumn(this GtkColumnViewHandle self, GtkColumnViewColumnHandle column)
    {
        GtkColumnViewExterns.gtk_column_view_remove_column(self, column);
        return self;
    }

    public static GtkColumnViewHandle InsertColumn(this GtkColumnViewHandle self, uint position, GtkColumnViewColumnHandle column)
    {
        GtkColumnViewExterns.gtk_column_view_insert_column(self, position, column);
        return self;
    }

    public static GtkSelectionModelHandle GetModel(this GtkColumnViewHandle self)
    {
        return GtkColumnViewExterns.gtk_column_view_get_model(self);
    }

    public static GtkColumnViewHandle SetModel(this GtkColumnViewHandle self, GtkSelectionModelHandle model)
    {
        GtkColumnViewExterns.gtk_column_view_set_model(self, model);
        return self;
    }

    public static int GetShowRowSeparators(this GtkColumnViewHandle self)
    {
        return GtkColumnViewExterns.gtk_column_view_get_show_row_separators(self);
    }

    public static GtkColumnViewHandle SetShowRowSeparators(this GtkColumnViewHandle self, int show_row_separators)
    {
        GtkColumnViewExterns.gtk_column_view_set_show_row_separators(self, show_row_separators);
        return self;
    }

    public static int GetShowColumnSeparators(this GtkColumnViewHandle self)
    {
        return GtkColumnViewExterns.gtk_column_view_get_show_column_separators(self);
    }

    public static GtkColumnViewHandle SetShowColumnSeparators(this GtkColumnViewHandle self, int show_column_separators)
    {
        GtkColumnViewExterns.gtk_column_view_set_show_column_separators(self, show_column_separators);
        return self;
    }

    public static GtkSorterHandle GetSorter(this GtkColumnViewHandle self)
    {
        return GtkColumnViewExterns.gtk_column_view_get_sorter(self);
    }

    public static GtkColumnViewHandle SortByColumn(this GtkColumnViewHandle self, GtkColumnViewColumnHandle column, GtkSortType direction)
    {
        GtkColumnViewExterns.gtk_column_view_sort_by_column(self, column, direction);
        return self;
    }

    public static GtkColumnViewHandle SetSingleClickActivate(this GtkColumnViewHandle self, int single_click_activate)
    {
        GtkColumnViewExterns.gtk_column_view_set_single_click_activate(self, single_click_activate);
        return self;
    }

    public static int GetSingleClickActivate(this GtkColumnViewHandle self)
    {
        return GtkColumnViewExterns.gtk_column_view_get_single_click_activate(self);
    }

    public static GtkColumnViewHandle SetReorderable(this GtkColumnViewHandle self, int reorderable)
    {
        GtkColumnViewExterns.gtk_column_view_set_reorderable(self, reorderable);
        return self;
    }

    public static int GetReorderable(this GtkColumnViewHandle self)
    {
        return GtkColumnViewExterns.gtk_column_view_get_reorderable(self);
    }

    public static GtkColumnViewHandle SetEnableRubberband(this GtkColumnViewHandle self, int enable_rubberband)
    {
        GtkColumnViewExterns.gtk_column_view_set_enable_rubberband(self, enable_rubberband);
        return self;
    }

    public static int GetEnableRubberband(this GtkColumnViewHandle self)
    {
        return GtkColumnViewExterns.gtk_column_view_get_enable_rubberband(self);
    }
}
