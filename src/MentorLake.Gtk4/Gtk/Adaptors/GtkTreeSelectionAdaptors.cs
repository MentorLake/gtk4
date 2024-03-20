using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTreeSelectionAdaptors
{
    public static GtkTreeSelectionHandle SetMode(this GtkTreeSelectionHandle selection, GtkSelectionMode type)
    {
        GtkTreeSelectionExterns.gtk_tree_selection_set_mode(selection, type);
        return selection;
    }

    public static GtkSelectionMode GetMode(this GtkTreeSelectionHandle selection)
    {
        return GtkTreeSelectionExterns.gtk_tree_selection_get_mode(selection);
    }

    public static GtkTreeSelectionHandle SetSelectFunction(this GtkTreeSelectionHandle selection, GtkTreeSelectionFunc func, IntPtr data, GDestroyNotify destroy)
    {
        GtkTreeSelectionExterns.gtk_tree_selection_set_select_function(selection, func, data, destroy);
        return selection;
    }

    public static IntPtr GetUserData(this GtkTreeSelectionHandle selection)
    {
        return GtkTreeSelectionExterns.gtk_tree_selection_get_user_data(selection);
    }

    public static GtkTreeViewHandle GetTreeView(this GtkTreeSelectionHandle selection)
    {
        return GtkTreeSelectionExterns.gtk_tree_selection_get_tree_view(selection);
    }

    public static GtkTreeSelectionFunc GetSelectFunction(this GtkTreeSelectionHandle selection)
    {
        return GtkTreeSelectionExterns.gtk_tree_selection_get_select_function(selection);
    }

    public static int GetSelected(this GtkTreeSelectionHandle selection, out GtkTreeModelHandle model, GtkTreeIterHandle iter)
    {
        return GtkTreeSelectionExterns.gtk_tree_selection_get_selected(selection, out model, iter);
    }

    public static GListHandle GetSelectedRows(this GtkTreeSelectionHandle selection, out GtkTreeModelHandle model)
    {
        return GtkTreeSelectionExterns.gtk_tree_selection_get_selected_rows(selection, out model);
    }

    public static int CountSelectedRows(this GtkTreeSelectionHandle selection)
    {
        return GtkTreeSelectionExterns.gtk_tree_selection_count_selected_rows(selection);
    }

    public static GtkTreeSelectionHandle SelectedForeach(this GtkTreeSelectionHandle selection, GtkTreeSelectionForeachFunc func, IntPtr data)
    {
        GtkTreeSelectionExterns.gtk_tree_selection_selected_foreach(selection, func, data);
        return selection;
    }

    public static GtkTreeSelectionHandle SelectPath(this GtkTreeSelectionHandle selection, GtkTreePathHandle path)
    {
        GtkTreeSelectionExterns.gtk_tree_selection_select_path(selection, path);
        return selection;
    }

    public static GtkTreeSelectionHandle UnselectPath(this GtkTreeSelectionHandle selection, GtkTreePathHandle path)
    {
        GtkTreeSelectionExterns.gtk_tree_selection_unselect_path(selection, path);
        return selection;
    }

    public static GtkTreeSelectionHandle SelectIter(this GtkTreeSelectionHandle selection, GtkTreeIterHandle iter)
    {
        GtkTreeSelectionExterns.gtk_tree_selection_select_iter(selection, iter);
        return selection;
    }

    public static GtkTreeSelectionHandle UnselectIter(this GtkTreeSelectionHandle selection, GtkTreeIterHandle iter)
    {
        GtkTreeSelectionExterns.gtk_tree_selection_unselect_iter(selection, iter);
        return selection;
    }

    public static int PathIsSelected(this GtkTreeSelectionHandle selection, GtkTreePathHandle path)
    {
        return GtkTreeSelectionExterns.gtk_tree_selection_path_is_selected(selection, path);
    }

    public static int IterIsSelected(this GtkTreeSelectionHandle selection, GtkTreeIterHandle iter)
    {
        return GtkTreeSelectionExterns.gtk_tree_selection_iter_is_selected(selection, iter);
    }

    public static GtkTreeSelectionHandle SelectAll(this GtkTreeSelectionHandle selection)
    {
        GtkTreeSelectionExterns.gtk_tree_selection_select_all(selection);
        return selection;
    }

    public static GtkTreeSelectionHandle UnselectAll(this GtkTreeSelectionHandle selection)
    {
        GtkTreeSelectionExterns.gtk_tree_selection_unselect_all(selection);
        return selection;
    }

    public static GtkTreeSelectionHandle SelectRange(this GtkTreeSelectionHandle selection, GtkTreePathHandle start_path, GtkTreePathHandle end_path)
    {
        GtkTreeSelectionExterns.gtk_tree_selection_select_range(selection, start_path, end_path);
        return selection;
    }

    public static GtkTreeSelectionHandle UnselectRange(this GtkTreeSelectionHandle selection, GtkTreePathHandle start_path, GtkTreePathHandle end_path)
    {
        GtkTreeSelectionExterns.gtk_tree_selection_unselect_range(selection, start_path, end_path);
        return selection;
    }
}
