using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gtk4;

public class GtkListBoxHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkListBoxHandle New()
	{
		return GtkListBoxExterns.gtk_list_box_new();
	}

}

public class GtkListBoxSignal
{
	public string Value { get; set; }
	public GtkListBoxSignal(string value) => Value = value;
}

public static class GtkListBoxSignals
{
	public static GtkListBoxSignal ActivateCursorRow = new("activate-cursor-row");
	public static GtkListBoxSignal MoveCursor = new("move-cursor");
	public static GtkListBoxSignal RowActivated = new("row-activated");
	public static GtkListBoxSignal RowSelected = new("row-selected");
	public static GtkListBoxSignal SelectAll = new("select-all");
	public static GtkListBoxSignal SelectedRowsChanged = new("selected-rows-changed");
	public static GtkListBoxSignal ToggleCursorRow = new("toggle-cursor-row");
	public static GtkListBoxSignal UnselectAll = new("unselect-all");
}

public static class GtkListBoxHandleExtensions
{
	public static GtkListBoxHandle Append(this GtkListBoxHandle box, GtkWidgetHandle child)
	{
		GtkListBoxExterns.gtk_list_box_append(box, child);
		return box;
	}

	public static GtkListBoxHandle BindModel(this GtkListBoxHandle box, GListModelHandle model, GtkListBoxCreateWidgetFunc create_widget_func, IntPtr user_data, GDestroyNotify user_data_free_func)
	{
		GtkListBoxExterns.gtk_list_box_bind_model(box, model, create_widget_func, user_data, user_data_free_func);
		return box;
	}

	public static GtkListBoxHandle DragHighlightRow(this GtkListBoxHandle box, GtkListBoxRowHandle row)
	{
		GtkListBoxExterns.gtk_list_box_drag_highlight_row(box, row);
		return box;
	}

	public static GtkListBoxHandle DragUnhighlightRow(this GtkListBoxHandle box)
	{
		GtkListBoxExterns.gtk_list_box_drag_unhighlight_row(box);
		return box;
	}

	public static bool GetActivateOnSingleClick(this GtkListBoxHandle box)
	{
		return GtkListBoxExterns.gtk_list_box_get_activate_on_single_click(box);
	}

	public static GtkAdjustmentHandle GetAdjustment(this GtkListBoxHandle box)
	{
		return GtkListBoxExterns.gtk_list_box_get_adjustment(box);
	}

	public static GtkListBoxRowHandle GetRowAtIndex(this GtkListBoxHandle box, int index_)
	{
		return GtkListBoxExterns.gtk_list_box_get_row_at_index(box, index_);
	}

	public static GtkListBoxRowHandle GetRowAtY(this GtkListBoxHandle box, int y)
	{
		return GtkListBoxExterns.gtk_list_box_get_row_at_y(box, y);
	}

	public static GtkListBoxRowHandle GetSelectedRow(this GtkListBoxHandle box)
	{
		return GtkListBoxExterns.gtk_list_box_get_selected_row(box);
	}

	public static GListHandle GetSelectedRows(this GtkListBoxHandle box)
	{
		return GtkListBoxExterns.gtk_list_box_get_selected_rows(box);
	}

	public static GtkSelectionMode GetSelectionMode(this GtkListBoxHandle box)
	{
		return GtkListBoxExterns.gtk_list_box_get_selection_mode(box);
	}

	public static bool GetShowSeparators(this GtkListBoxHandle box)
	{
		return GtkListBoxExterns.gtk_list_box_get_show_separators(box);
	}

	public static GtkListBoxHandle Insert(this GtkListBoxHandle box, GtkWidgetHandle child, int position)
	{
		GtkListBoxExterns.gtk_list_box_insert(box, child, position);
		return box;
	}

	public static GtkListBoxHandle InvalidateFilter(this GtkListBoxHandle box)
	{
		GtkListBoxExterns.gtk_list_box_invalidate_filter(box);
		return box;
	}

	public static GtkListBoxHandle InvalidateHeaders(this GtkListBoxHandle box)
	{
		GtkListBoxExterns.gtk_list_box_invalidate_headers(box);
		return box;
	}

	public static GtkListBoxHandle InvalidateSort(this GtkListBoxHandle box)
	{
		GtkListBoxExterns.gtk_list_box_invalidate_sort(box);
		return box;
	}

	public static GtkListBoxHandle Prepend(this GtkListBoxHandle box, GtkWidgetHandle child)
	{
		GtkListBoxExterns.gtk_list_box_prepend(box, child);
		return box;
	}

	public static GtkListBoxHandle Remove(this GtkListBoxHandle box, GtkWidgetHandle child)
	{
		GtkListBoxExterns.gtk_list_box_remove(box, child);
		return box;
	}

	public static GtkListBoxHandle RemoveAll(this GtkListBoxHandle box)
	{
		GtkListBoxExterns.gtk_list_box_remove_all(box);
		return box;
	}

	public static GtkListBoxHandle SelectAll(this GtkListBoxHandle box)
	{
		GtkListBoxExterns.gtk_list_box_select_all(box);
		return box;
	}

	public static GtkListBoxHandle SelectRow(this GtkListBoxHandle box, GtkListBoxRowHandle row)
	{
		GtkListBoxExterns.gtk_list_box_select_row(box, row);
		return box;
	}

	public static GtkListBoxHandle SelectedForeach(this GtkListBoxHandle box, GtkListBoxForeachFunc func, IntPtr data)
	{
		GtkListBoxExterns.gtk_list_box_selected_foreach(box, func, data);
		return box;
	}

	public static GtkListBoxHandle SetActivateOnSingleClick(this GtkListBoxHandle box, bool single)
	{
		GtkListBoxExterns.gtk_list_box_set_activate_on_single_click(box, single);
		return box;
	}

	public static GtkListBoxHandle SetAdjustment(this GtkListBoxHandle box, GtkAdjustmentHandle adjustment)
	{
		GtkListBoxExterns.gtk_list_box_set_adjustment(box, adjustment);
		return box;
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

	public static GtkListBoxHandle SetPlaceholder(this GtkListBoxHandle box, GtkWidgetHandle placeholder)
	{
		GtkListBoxExterns.gtk_list_box_set_placeholder(box, placeholder);
		return box;
	}

	public static GtkListBoxHandle SetSelectionMode(this GtkListBoxHandle box, GtkSelectionMode mode)
	{
		GtkListBoxExterns.gtk_list_box_set_selection_mode(box, mode);
		return box;
	}

	public static GtkListBoxHandle SetShowSeparators(this GtkListBoxHandle box, bool show_separators)
	{
		GtkListBoxExterns.gtk_list_box_set_show_separators(box, show_separators);
		return box;
	}

	public static GtkListBoxHandle SetSortFunc(this GtkListBoxHandle box, GtkListBoxSortFunc sort_func, IntPtr user_data, GDestroyNotify destroy)
	{
		GtkListBoxExterns.gtk_list_box_set_sort_func(box, sort_func, user_data, destroy);
		return box;
	}

	public static GtkListBoxHandle UnselectAll(this GtkListBoxHandle box)
	{
		GtkListBoxExterns.gtk_list_box_unselect_all(box);
		return box;
	}

	public static GtkListBoxHandle UnselectRow(this GtkListBoxHandle box, GtkListBoxRowHandle row)
	{
		GtkListBoxExterns.gtk_list_box_unselect_row(box, row);
		return box;
	}

	public static GtkListBoxHandle Connect(this GtkListBoxHandle instance, GtkListBoxSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkListBoxExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkListBoxHandle gtk_list_box_new();
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_append(GtkListBoxHandle box, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_bind_model(GtkListBoxHandle box, GListModelHandle model, GtkListBoxCreateWidgetFunc create_widget_func, IntPtr user_data, GDestroyNotify user_data_free_func);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_drag_highlight_row(GtkListBoxHandle box, GtkListBoxRowHandle row);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_drag_unhighlight_row(GtkListBoxHandle box);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_list_box_get_activate_on_single_click(GtkListBoxHandle box);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAdjustmentHandle gtk_list_box_get_adjustment(GtkListBoxHandle box);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkListBoxRowHandle gtk_list_box_get_row_at_index(GtkListBoxHandle box, int index_);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkListBoxRowHandle gtk_list_box_get_row_at_y(GtkListBoxHandle box, int y);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkListBoxRowHandle gtk_list_box_get_selected_row(GtkListBoxHandle box);
	[DllImport(Libraries.Gtk4)]
	internal static extern GListHandle gtk_list_box_get_selected_rows(GtkListBoxHandle box);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSelectionMode gtk_list_box_get_selection_mode(GtkListBoxHandle box);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_list_box_get_show_separators(GtkListBoxHandle box);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_insert(GtkListBoxHandle box, GtkWidgetHandle child, int position);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_invalidate_filter(GtkListBoxHandle box);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_invalidate_headers(GtkListBoxHandle box);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_invalidate_sort(GtkListBoxHandle box);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_prepend(GtkListBoxHandle box, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_remove(GtkListBoxHandle box, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_remove_all(GtkListBoxHandle box);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_select_all(GtkListBoxHandle box);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_select_row(GtkListBoxHandle box, GtkListBoxRowHandle row);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_selected_foreach(GtkListBoxHandle box, GtkListBoxForeachFunc func, IntPtr data);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_set_activate_on_single_click(GtkListBoxHandle box, bool single);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_set_adjustment(GtkListBoxHandle box, GtkAdjustmentHandle adjustment);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_set_filter_func(GtkListBoxHandle box, GtkListBoxFilterFunc filter_func, IntPtr user_data, GDestroyNotify destroy);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_set_header_func(GtkListBoxHandle box, GtkListBoxUpdateHeaderFunc update_header, IntPtr user_data, GDestroyNotify destroy);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_set_placeholder(GtkListBoxHandle box, GtkWidgetHandle placeholder);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_set_selection_mode(GtkListBoxHandle box, GtkSelectionMode mode);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_set_show_separators(GtkListBoxHandle box, bool show_separators);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_set_sort_func(GtkListBoxHandle box, GtkListBoxSortFunc sort_func, IntPtr user_data, GDestroyNotify destroy);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_unselect_all(GtkListBoxHandle box);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_unselect_row(GtkListBoxHandle box, GtkListBoxRowHandle row);
}
