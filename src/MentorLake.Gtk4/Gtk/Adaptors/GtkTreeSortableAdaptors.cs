using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTreeSortableAdaptors
{
    public static GtkTreeSortableHandle SortColumnChanged(this GtkTreeSortableHandle sortable)
    {
        GtkTreeSortableExterns.gtk_tree_sortable_sort_column_changed(sortable);
        return sortable;
    }

    public static int GetSortColumnId(this GtkTreeSortableHandle sortable, out int sort_column_id, out GtkSortType order)
    {
        return GtkTreeSortableExterns.gtk_tree_sortable_get_sort_column_id(sortable, out sort_column_id, out order);
    }

    public static GtkTreeSortableHandle SetSortColumnId(this GtkTreeSortableHandle sortable, int sort_column_id, GtkSortType order)
    {
        GtkTreeSortableExterns.gtk_tree_sortable_set_sort_column_id(sortable, sort_column_id, order);
        return sortable;
    }

    public static GtkTreeSortableHandle SetSortFunc(this GtkTreeSortableHandle sortable, int sort_column_id, GtkTreeIterCompareFunc sort_func, IntPtr user_data, GDestroyNotify destroy)
    {
        GtkTreeSortableExterns.gtk_tree_sortable_set_sort_func(sortable, sort_column_id, sort_func, user_data, destroy);
        return sortable;
    }

    public static GtkTreeSortableHandle SetDefaultSortFunc(this GtkTreeSortableHandle sortable, GtkTreeIterCompareFunc sort_func, IntPtr user_data, GDestroyNotify destroy)
    {
        GtkTreeSortableExterns.gtk_tree_sortable_set_default_sort_func(sortable, sort_func, user_data, destroy);
        return sortable;
    }

    public static int HasDefaultSortFunc(this GtkTreeSortableHandle sortable)
    {
        return GtkTreeSortableExterns.gtk_tree_sortable_has_default_sort_func(sortable);
    }
}
