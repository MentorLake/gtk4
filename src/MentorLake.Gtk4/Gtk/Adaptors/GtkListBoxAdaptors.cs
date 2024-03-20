using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkListBoxAdaptors
{
	public static GtkListBoxHandle Prepend(this GtkListBoxHandle box, GtkWidgetHandle child)
	{
		GtkListBoxExterns.gtk_list_box_prepend(box, child);
		return box;
	}

	public static GtkListBoxHandle Append(this GtkListBoxHandle box, GtkWidgetHandle child)
	{
		GtkListBoxExterns.gtk_list_box_append(box, child);
		return box;
	}

	public static GtkListBoxHandle Insert(this GtkListBoxHandle box, GtkWidgetHandle child, int position)
	{
		GtkListBoxExterns.gtk_list_box_insert(box, child, position);
		return box;
	}

	public static GtkListBoxHandle Remove(this GtkListBoxHandle box, GtkWidgetHandle child)
	{
		GtkListBoxExterns.gtk_list_box_remove(box, child);
		return box;
	}

	public static GtkListBoxRowHandle GetSelectedRow(this GtkListBoxHandle box)
	{
		return GtkListBoxExterns.gtk_list_box_get_selected_row(box);
	}

	public static GtkListBoxRowHandle GetRowAtIndex(this GtkListBoxHandle box, int index_)
	{
		return GtkListBoxExterns.gtk_list_box_get_row_at_index(box, index_);
	}

	public static GtkListBoxRowHandle GetRowAtY(this GtkListBoxHandle box, int y)
	{
		return GtkListBoxExterns.gtk_list_box_get_row_at_y(box, y);
	}

	public static GtkListBoxHandle SelectRow(this GtkListBoxHandle box, GtkListBoxRowHandle row)
	{
		GtkListBoxExterns.gtk_list_box_select_row(box, row);
		return box;
	}

	public static GtkListBoxHandle SetPlaceholder(this GtkListBoxHandle box, GtkWidgetHandle placeholder)
	{
		GtkListBoxExterns.gtk_list_box_set_placeholder(box, placeholder);
		return box;
	}

	public static GtkListBoxHandle SetAdjustment(this GtkListBoxHandle box, GtkAdjustmentHandle adjustment)
	{
		GtkListBoxExterns.gtk_list_box_set_adjustment(box, adjustment);
		return box;
	}

	public static GtkAdjustmentHandle GetAdjustment(this GtkListBoxHandle box)
	{
		return GtkListBoxExterns.gtk_list_box_get_adjustment(box);
	}

	public static GtkListBoxHandle SelectedForeach(this GtkListBoxHandle box, GtkListBoxForeachFunc func, IntPtr data)
	{
		GtkListBoxExterns.gtk_list_box_selected_foreach(box, func, data);
		return box;
	}

	public static GListHandle GetSelectedRows(this GtkListBoxHandle box)
	{
		return GtkListBoxExterns.gtk_list_box_get_selected_rows(box);
	}

	public static GtkListBoxHandle UnselectRow(this GtkListBoxHandle box, GtkListBoxRowHandle row)
	{
		GtkListBoxExterns.gtk_list_box_unselect_row(box, row);
		return box;
	}

	public static GtkListBoxHandle SelectAll(this GtkListBoxHandle box)
	{
		GtkListBoxExterns.gtk_list_box_select_all(box);
		return box;
	}

	public static GtkListBoxHandle UnselectAll(this GtkListBoxHandle box)
	{
		GtkListBoxExterns.gtk_list_box_unselect_all(box);
		return box;
	}

	public static GtkListBoxHandle SetSelectionMode(this GtkListBoxHandle box, GtkSelectionMode mode)
	{
		GtkListBoxExterns.gtk_list_box_set_selection_mode(box, mode);
		return box;
	}

	public static GtkSelectionMode GetSelectionMode(this GtkListBoxHandle box)
	{
		return GtkListBoxExterns.gtk_list_box_get_selection_mode(box);
	}

	public static GtkListBoxHandle SetFilterFunc(this GtkListBoxHandle box, GtkListBoxFilterFunc filter_func, IntPtr user_data, GDestroyNotify destroy)
	{
		GtkListBoxExterns.gtk_list_box_set_filter_func(box, filter_func, user_data, destroy);
		return box;
	}

	public static GtkListBoxHandle SetHeaderFunc(this GtkListBoxHandle box, GtkListBoxUpdateHeaderFunc update_header, IntPtr user_data, GDestroyNotify destroy)
	{
		GtkListBoxExterns.gtk_list_box_set_header_func(box, update_header, user_data, destroy);
		return box;
	}

	public static GtkListBoxHandle InvalidateFilter(this GtkListBoxHandle box)
	{
		GtkListBoxExterns.gtk_list_box_invalidate_filter(box);
		return box;
	}

	public static GtkListBoxHandle InvalidateSort(this GtkListBoxHandle box)
	{
		GtkListBoxExterns.gtk_list_box_invalidate_sort(box);
		return box;
	}

	public static GtkListBoxHandle InvalidateHeaders(this GtkListBoxHandle box)
	{
		GtkListBoxExterns.gtk_list_box_invalidate_headers(box);
		return box;
	}

	public static GtkListBoxHandle SetSortFunc(this GtkListBoxHandle box, GtkListBoxSortFunc sort_func, IntPtr user_data, GDestroyNotify destroy)
	{
		GtkListBoxExterns.gtk_list_box_set_sort_func(box, sort_func, user_data, destroy);
		return box;
	}

	public static GtkListBoxHandle SetActivateOnSingleClick(this GtkListBoxHandle box, int single)
	{
		GtkListBoxExterns.gtk_list_box_set_activate_on_single_click(box, single);
		return box;
	}

	public static int GetActivateOnSingleClick(this GtkListBoxHandle box)
	{
		return GtkListBoxExterns.gtk_list_box_get_activate_on_single_click(box);
	}

	public static GtkListBoxHandle DragUnhighlightRow(this GtkListBoxHandle box)
	{
		GtkListBoxExterns.gtk_list_box_drag_unhighlight_row(box);
		return box;
	}

	public static GtkListBoxHandle DragHighlightRow(this GtkListBoxHandle box, GtkListBoxRowHandle row)
	{
		GtkListBoxExterns.gtk_list_box_drag_highlight_row(box, row);
		return box;
	}

	public static GtkListBoxHandle BindModel(this GtkListBoxHandle box, GListModelHandle model, GtkListBoxCreateWidgetFunc create_widget_func, IntPtr user_data, GDestroyNotify user_data_free_func)
	{
		GtkListBoxExterns.gtk_list_box_bind_model(box, model, create_widget_func, user_data, user_data_free_func);
		return box;
	}

	public static GtkListBoxHandle SetShowSeparators(this GtkListBoxHandle box, int show_separators)
	{
		GtkListBoxExterns.gtk_list_box_set_show_separators(box, show_separators);
		return box;
	}

	public static int GetShowSeparators(this GtkListBoxHandle box)
	{
		return GtkListBoxExterns.gtk_list_box_get_show_separators(box);
	}
}
