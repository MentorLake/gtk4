using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTreeModelSortAdaptors
{
    public static GtkTreeModelHandle GetModel(this GtkTreeModelSortHandle tree_model)
    {
        return GtkTreeModelSortExterns.gtk_tree_model_sort_get_model(tree_model);
    }

    public static GtkTreePathHandle ConvertChildPathToPath(this GtkTreeModelSortHandle tree_model_sort, GtkTreePathHandle child_path)
    {
        return GtkTreeModelSortExterns.gtk_tree_model_sort_convert_child_path_to_path(tree_model_sort, child_path);
    }

    public static int ConvertChildIterToIter(this GtkTreeModelSortHandle tree_model_sort, GtkTreeIterHandle sort_iter, GtkTreeIterHandle child_iter)
    {
        return GtkTreeModelSortExterns.gtk_tree_model_sort_convert_child_iter_to_iter(tree_model_sort, sort_iter, child_iter);
    }

    public static GtkTreePathHandle ConvertPathToChildPath(this GtkTreeModelSortHandle tree_model_sort, GtkTreePathHandle sorted_path)
    {
        return GtkTreeModelSortExterns.gtk_tree_model_sort_convert_path_to_child_path(tree_model_sort, sorted_path);
    }

    public static GtkTreeModelSortHandle ConvertIterToChildIter(this GtkTreeModelSortHandle tree_model_sort, GtkTreeIterHandle child_iter, GtkTreeIterHandle sorted_iter)
    {
        GtkTreeModelSortExterns.gtk_tree_model_sort_convert_iter_to_child_iter(tree_model_sort, child_iter, sorted_iter);
        return tree_model_sort;
    }

    public static GtkTreeModelSortHandle ResetDefaultSortFunc(this GtkTreeModelSortHandle tree_model_sort)
    {
        GtkTreeModelSortExterns.gtk_tree_model_sort_reset_default_sort_func(tree_model_sort);
        return tree_model_sort;
    }

    public static GtkTreeModelSortHandle ClearCache(this GtkTreeModelSortHandle tree_model_sort)
    {
        GtkTreeModelSortExterns.gtk_tree_model_sort_clear_cache(tree_model_sort);
        return tree_model_sort;
    }

    public static int IterIsValid(this GtkTreeModelSortHandle tree_model_sort, GtkTreeIterHandle iter)
    {
        return GtkTreeModelSortExterns.gtk_tree_model_sort_iter_is_valid(tree_model_sort, iter);
    }
}
