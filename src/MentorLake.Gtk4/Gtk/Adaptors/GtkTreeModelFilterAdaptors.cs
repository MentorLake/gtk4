using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTreeModelFilterAdaptors
{
    public static GtkTreeModelFilterHandle SetVisibleFunc(this GtkTreeModelFilterHandle filter, GtkTreeModelFilterVisibleFunc func, IntPtr data, GDestroyNotify destroy)
    {
        GtkTreeModelFilterExterns.gtk_tree_model_filter_set_visible_func(filter, func, data, destroy);
        return filter;
    }

    public static GtkTreeModelFilterHandle SetModifyFunc(this GtkTreeModelFilterHandle filter, int n_columns, GTypeHandle types, GtkTreeModelFilterModifyFunc func, IntPtr data, GDestroyNotify destroy)
    {
        GtkTreeModelFilterExterns.gtk_tree_model_filter_set_modify_func(filter, n_columns, types, func, data, destroy);
        return filter;
    }

    public static GtkTreeModelFilterHandle SetVisibleColumn(this GtkTreeModelFilterHandle filter, int column)
    {
        GtkTreeModelFilterExterns.gtk_tree_model_filter_set_visible_column(filter, column);
        return filter;
    }

    public static GtkTreeModelHandle GetModel(this GtkTreeModelFilterHandle filter)
    {
        return GtkTreeModelFilterExterns.gtk_tree_model_filter_get_model(filter);
    }

    public static int ConvertChildIterToIter(this GtkTreeModelFilterHandle filter, GtkTreeIterHandle filter_iter, GtkTreeIterHandle child_iter)
    {
        return GtkTreeModelFilterExterns.gtk_tree_model_filter_convert_child_iter_to_iter(filter, filter_iter, child_iter);
    }

    public static GtkTreeModelFilterHandle ConvertIterToChildIter(this GtkTreeModelFilterHandle filter, GtkTreeIterHandle child_iter, GtkTreeIterHandle filter_iter)
    {
        GtkTreeModelFilterExterns.gtk_tree_model_filter_convert_iter_to_child_iter(filter, child_iter, filter_iter);
        return filter;
    }

    public static GtkTreePathHandle ConvertChildPathToPath(this GtkTreeModelFilterHandle filter, GtkTreePathHandle child_path)
    {
        return GtkTreeModelFilterExterns.gtk_tree_model_filter_convert_child_path_to_path(filter, child_path);
    }

    public static GtkTreePathHandle ConvertPathToChildPath(this GtkTreeModelFilterHandle filter, GtkTreePathHandle filter_path)
    {
        return GtkTreeModelFilterExterns.gtk_tree_model_filter_convert_path_to_child_path(filter, filter_path);
    }

    public static GtkTreeModelFilterHandle Refilter(this GtkTreeModelFilterHandle filter)
    {
        GtkTreeModelFilterExterns.gtk_tree_model_filter_refilter(filter);
        return filter;
    }

    public static GtkTreeModelFilterHandle ClearCache(this GtkTreeModelFilterHandle filter)
    {
        GtkTreeModelFilterExterns.gtk_tree_model_filter_clear_cache(filter);
        return filter;
    }
}
