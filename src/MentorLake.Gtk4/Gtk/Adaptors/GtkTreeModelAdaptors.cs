using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTreeModelAdaptors
{
    public static GtkTreeModelFlags GetFlags(this GtkTreeModelHandle tree_model)
    {
        return GtkTreeModelExterns.gtk_tree_model_get_flags(tree_model);
    }

    public static int GetNColumns(this GtkTreeModelHandle tree_model)
    {
        return GtkTreeModelExterns.gtk_tree_model_get_n_columns(tree_model);
    }

    public static GType GetColumnType(this GtkTreeModelHandle tree_model, int index_)
    {
        return GtkTreeModelExterns.gtk_tree_model_get_column_type(tree_model, index_);
    }

    public static int GetIter(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter, GtkTreePathHandle path)
    {
        return GtkTreeModelExterns.gtk_tree_model_get_iter(tree_model, iter, path);
    }

    public static int GetIterFromString(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter, string path_string)
    {
        return GtkTreeModelExterns.gtk_tree_model_get_iter_from_string(tree_model, iter, path_string);
    }

    public static string GetStringFromIter(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter)
    {
        return GtkTreeModelExterns.gtk_tree_model_get_string_from_iter(tree_model, iter);
    }

    public static int GetIterFirst(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter)
    {
        return GtkTreeModelExterns.gtk_tree_model_get_iter_first(tree_model, iter);
    }

    public static GtkTreePathHandle GetPath(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter)
    {
        return GtkTreeModelExterns.gtk_tree_model_get_path(tree_model, iter);
    }

    public static GtkTreeModelHandle GetValue(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter, int column, GValueHandle value)
    {
        GtkTreeModelExterns.gtk_tree_model_get_value(tree_model, iter, column, value);
        return tree_model;
    }

    public static int IterPrevious(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter)
    {
        return GtkTreeModelExterns.gtk_tree_model_iter_previous(tree_model, iter);
    }

    public static int IterNext(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter)
    {
        return GtkTreeModelExterns.gtk_tree_model_iter_next(tree_model, iter);
    }

    public static int IterChildren(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter, GtkTreeIterHandle parent)
    {
        return GtkTreeModelExterns.gtk_tree_model_iter_children(tree_model, iter, parent);
    }

    public static int IterHasChild(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter)
    {
        return GtkTreeModelExterns.gtk_tree_model_iter_has_child(tree_model, iter);
    }

    public static int IterNChildren(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter)
    {
        return GtkTreeModelExterns.gtk_tree_model_iter_n_children(tree_model, iter);
    }

    public static int IterNthChild(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter, GtkTreeIterHandle parent, int n)
    {
        return GtkTreeModelExterns.gtk_tree_model_iter_nth_child(tree_model, iter, parent, n);
    }

    public static int IterParent(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter, GtkTreeIterHandle child)
    {
        return GtkTreeModelExterns.gtk_tree_model_iter_parent(tree_model, iter, child);
    }

    public static GtkTreeModelHandle RefNode(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter)
    {
        GtkTreeModelExterns.gtk_tree_model_ref_node(tree_model, iter);
        return tree_model;
    }

    public static GtkTreeModelHandle UnrefNode(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter)
    {
        GtkTreeModelExterns.gtk_tree_model_unref_node(tree_model, iter);
        return tree_model;
    }

    public static GtkTreeModelHandle Get(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter, IntPtr @__argList)
    {
        GtkTreeModelExterns.gtk_tree_model_get(tree_model, iter, @__argList);
        return tree_model;
    }

    public static GtkTreeModelHandle GetValist(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter, IntPtr @__argList)
    {
        GtkTreeModelExterns.gtk_tree_model_get_valist(tree_model, iter, @__argList);
        return tree_model;
    }

    public static GtkTreeModelHandle Foreach(this GtkTreeModelHandle model, GtkTreeModelForeachFunc func, IntPtr user_data)
    {
        GtkTreeModelExterns.gtk_tree_model_foreach(model, func, user_data);
        return model;
    }

    public static GtkTreeModelHandle RowChanged(this GtkTreeModelHandle tree_model, GtkTreePathHandle path, GtkTreeIterHandle iter)
    {
        GtkTreeModelExterns.gtk_tree_model_row_changed(tree_model, path, iter);
        return tree_model;
    }

    public static GtkTreeModelHandle RowInserted(this GtkTreeModelHandle tree_model, GtkTreePathHandle path, GtkTreeIterHandle iter)
    {
        GtkTreeModelExterns.gtk_tree_model_row_inserted(tree_model, path, iter);
        return tree_model;
    }

    public static GtkTreeModelHandle RowHasChildToggled(this GtkTreeModelHandle tree_model, GtkTreePathHandle path, GtkTreeIterHandle iter)
    {
        GtkTreeModelExterns.gtk_tree_model_row_has_child_toggled(tree_model, path, iter);
        return tree_model;
    }

    public static GtkTreeModelHandle RowDeleted(this GtkTreeModelHandle tree_model, GtkTreePathHandle path)
    {
        GtkTreeModelExterns.gtk_tree_model_row_deleted(tree_model, path);
        return tree_model;
    }

    public static GtkTreeModelHandle RowsReordered(this GtkTreeModelHandle tree_model, GtkTreePathHandle path, GtkTreeIterHandle iter, int[] new_order)
    {
        GtkTreeModelExterns.gtk_tree_model_rows_reordered(tree_model, path, iter, new_order);
        return tree_model;
    }

    public static GtkTreeModelHandle RowsReorderedWithLength(this GtkTreeModelHandle tree_model, GtkTreePathHandle path, GtkTreeIterHandle iter, int[] new_order, int length)
    {
        GtkTreeModelExterns.gtk_tree_model_rows_reordered_with_length(tree_model, path, iter, new_order, length);
        return tree_model;
    }

    public static GtkTreeModelHandle FilterNew(this GtkTreeModelHandle child_model, GtkTreePathHandle root)
    {
        return GtkTreeModelExterns.gtk_tree_model_filter_new(child_model, root);
    }

    public static GtkTreeViewHandle GtkTreeViewNewWithModel(this GtkTreeModelHandle model)
    {
        return GtkTreeModelExterns.gtk_tree_view_new_with_model(model);
    }

    public static GtkComboBoxHandle GtkComboBoxNewWithModel(this GtkTreeModelHandle model)
    {
        return GtkTreeModelExterns.gtk_combo_box_new_with_model(model);
    }

    public static GtkComboBoxHandle GtkComboBoxNewWithModelAndEntry(this GtkTreeModelHandle model)
    {
        return GtkTreeModelExterns.gtk_combo_box_new_with_model_and_entry(model);
    }

    public static GtkIconViewHandle GtkIconViewNewWithModel(this GtkTreeModelHandle model)
    {
        return GtkTreeModelExterns.gtk_icon_view_new_with_model(model);
    }

    public static GdkContentProviderHandle GtkTreeCreateRowDragContent(this GtkTreeModelHandle tree_model, GtkTreePathHandle path)
    {
        return GtkTreeModelExterns.gtk_tree_create_row_drag_content(tree_model, path);
    }

    public static GtkTreeModelHandle SortNewWithModel(this GtkTreeModelHandle child_model)
    {
        return GtkTreeModelExterns.gtk_tree_model_sort_new_with_model(child_model);
    }
}
