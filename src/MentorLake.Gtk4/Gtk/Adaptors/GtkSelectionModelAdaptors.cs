using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkSelectionModelAdaptors
{
    public static int IsSelected(this GtkSelectionModelHandle model, uint position)
    {
        return GtkSelectionModelExterns.gtk_selection_model_is_selected(model, position);
    }

    public static GtkBitsetHandle GetSelection(this GtkSelectionModelHandle model)
    {
        return GtkSelectionModelExterns.gtk_selection_model_get_selection(model);
    }

    public static GtkBitsetHandle GetSelectionInRange(this GtkSelectionModelHandle model, uint position, uint n_items)
    {
        return GtkSelectionModelExterns.gtk_selection_model_get_selection_in_range(model, position, n_items);
    }

    public static int SelectItem(this GtkSelectionModelHandle model, uint position, int unselect_rest)
    {
        return GtkSelectionModelExterns.gtk_selection_model_select_item(model, position, unselect_rest);
    }

    public static int UnselectItem(this GtkSelectionModelHandle model, uint position)
    {
        return GtkSelectionModelExterns.gtk_selection_model_unselect_item(model, position);
    }

    public static int SelectRange(this GtkSelectionModelHandle model, uint position, uint n_items, int unselect_rest)
    {
        return GtkSelectionModelExterns.gtk_selection_model_select_range(model, position, n_items, unselect_rest);
    }

    public static int UnselectRange(this GtkSelectionModelHandle model, uint position, uint n_items)
    {
        return GtkSelectionModelExterns.gtk_selection_model_unselect_range(model, position, n_items);
    }

    public static int SelectAll(this GtkSelectionModelHandle model)
    {
        return GtkSelectionModelExterns.gtk_selection_model_select_all(model);
    }

    public static int UnselectAll(this GtkSelectionModelHandle model)
    {
        return GtkSelectionModelExterns.gtk_selection_model_unselect_all(model);
    }

    public static int SetSelection(this GtkSelectionModelHandle model, GtkBitsetHandle selected, GtkBitsetHandle mask)
    {
        return GtkSelectionModelExterns.gtk_selection_model_set_selection(model, selected, mask);
    }

    public static GtkSelectionModelHandle SelectionChanged(this GtkSelectionModelHandle model, uint position, uint n_items)
    {
        GtkSelectionModelExterns.gtk_selection_model_selection_changed(model, position, n_items);
        return model;
    }

    public static GtkColumnViewHandle GtkColumnViewNew(this GtkSelectionModelHandle model)
    {
        return GtkSelectionModelExterns.gtk_column_view_new(model);
    }

    public static GtkGridViewHandle GtkGridViewNew(this GtkSelectionModelHandle model, GtkListItemFactoryHandle factory)
    {
        return GtkSelectionModelExterns.gtk_grid_view_new(model, factory);
    }

    public static GtkListViewHandle GtkListViewNew(this GtkSelectionModelHandle model, GtkListItemFactoryHandle factory)
    {
        return GtkSelectionModelExterns.gtk_list_view_new(model, factory);
    }

    public static GtkSelectionFilterModelHandle GtkSelectionFilterModelNew(this GtkSelectionModelHandle model)
    {
        return GtkSelectionModelExterns.gtk_selection_filter_model_new(model);
    }
}
