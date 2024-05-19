namespace MentorLake.Gtk4.Gtk4;

public interface GtkSelectionModelHandle
{
}

internal class GtkSelectionModelHandleImpl : BaseSafeHandle, GtkSelectionModelHandle
{
}

public static class GtkSelectionModelHandleExtensions
{
	public static GtkBitsetHandle GetSelection(this GtkSelectionModelHandle model)
	{
		return GtkSelectionModelExterns.gtk_selection_model_get_selection(model);
	}

	public static GtkBitsetHandle GetSelectionInRange(this GtkSelectionModelHandle model, uint position, uint n_items)
	{
		return GtkSelectionModelExterns.gtk_selection_model_get_selection_in_range(model, position, n_items);
	}

	public static bool IsSelected(this GtkSelectionModelHandle model, uint position)
	{
		return GtkSelectionModelExterns.gtk_selection_model_is_selected(model, position);
	}

	public static bool SelectAll(this GtkSelectionModelHandle model)
	{
		return GtkSelectionModelExterns.gtk_selection_model_select_all(model);
	}

	public static bool SelectItem(this GtkSelectionModelHandle model, uint position, bool unselect_rest)
	{
		return GtkSelectionModelExterns.gtk_selection_model_select_item(model, position, unselect_rest);
	}

	public static bool SelectRange(this GtkSelectionModelHandle model, uint position, uint n_items, bool unselect_rest)
	{
		return GtkSelectionModelExterns.gtk_selection_model_select_range(model, position, n_items, unselect_rest);
	}

	public static GtkSelectionModelHandle SelectionChanged(this GtkSelectionModelHandle model, uint position, uint n_items)
	{
		GtkSelectionModelExterns.gtk_selection_model_selection_changed(model, position, n_items);
		return model;
	}

	public static bool SetSelection(this GtkSelectionModelHandle model, GtkBitsetHandle selected, GtkBitsetHandle mask)
	{
		return GtkSelectionModelExterns.gtk_selection_model_set_selection(model, selected, mask);
	}

	public static bool UnselectAll(this GtkSelectionModelHandle model)
	{
		return GtkSelectionModelExterns.gtk_selection_model_unselect_all(model);
	}

	public static bool UnselectItem(this GtkSelectionModelHandle model, uint position)
	{
		return GtkSelectionModelExterns.gtk_selection_model_unselect_item(model, position);
	}

	public static bool UnselectRange(this GtkSelectionModelHandle model, uint position, uint n_items)
	{
		return GtkSelectionModelExterns.gtk_selection_model_unselect_range(model, position, n_items);
	}

}

internal class GtkSelectionModelExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkBitsetHandle gtk_selection_model_get_selection(GtkSelectionModelHandle model);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkBitsetHandle gtk_selection_model_get_selection_in_range(GtkSelectionModelHandle model, uint position, uint n_items);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_selection_model_is_selected(GtkSelectionModelHandle model, uint position);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_selection_model_select_all(GtkSelectionModelHandle model);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_selection_model_select_item(GtkSelectionModelHandle model, uint position, bool unselect_rest);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_selection_model_select_range(GtkSelectionModelHandle model, uint position, uint n_items, bool unselect_rest);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_selection_model_selection_changed(GtkSelectionModelHandle model, uint position, uint n_items);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_selection_model_set_selection(GtkSelectionModelHandle model, GtkBitsetHandle selected, GtkBitsetHandle mask);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_selection_model_unselect_all(GtkSelectionModelHandle model);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_selection_model_unselect_item(GtkSelectionModelHandle model, uint position);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_selection_model_unselect_range(GtkSelectionModelHandle model, uint position, uint n_items);

}
