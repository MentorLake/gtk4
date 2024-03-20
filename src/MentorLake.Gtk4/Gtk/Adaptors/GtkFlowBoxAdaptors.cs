using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkFlowBoxAdaptors
{
	public static GtkFlowBoxHandle BindModel(this GtkFlowBoxHandle box, GListModelHandle model, GtkFlowBoxCreateWidgetFunc create_widget_func, IntPtr user_data, GDestroyNotify user_data_free_func)
	{
		GtkFlowBoxExterns.gtk_flow_box_bind_model(box, model, create_widget_func, user_data, user_data_free_func);
		return box;
	}

	public static GtkFlowBoxHandle SetHomogeneous(this GtkFlowBoxHandle box, int homogeneous)
	{
		GtkFlowBoxExterns.gtk_flow_box_set_homogeneous(box, homogeneous);
		return box;
	}

	public static int GetHomogeneous(this GtkFlowBoxHandle box)
	{
		return GtkFlowBoxExterns.gtk_flow_box_get_homogeneous(box);
	}

	public static GtkFlowBoxHandle SetRowSpacing(this GtkFlowBoxHandle box, uint spacing)
	{
		GtkFlowBoxExterns.gtk_flow_box_set_row_spacing(box, spacing);
		return box;
	}

	public static uint GetRowSpacing(this GtkFlowBoxHandle box)
	{
		return GtkFlowBoxExterns.gtk_flow_box_get_row_spacing(box);
	}

	public static GtkFlowBoxHandle SetColumnSpacing(this GtkFlowBoxHandle box, uint spacing)
	{
		GtkFlowBoxExterns.gtk_flow_box_set_column_spacing(box, spacing);
		return box;
	}

	public static uint GetColumnSpacing(this GtkFlowBoxHandle box)
	{
		return GtkFlowBoxExterns.gtk_flow_box_get_column_spacing(box);
	}

	public static GtkFlowBoxHandle SetMinChildrenPerLine(this GtkFlowBoxHandle box, uint n_children)
	{
		GtkFlowBoxExterns.gtk_flow_box_set_min_children_per_line(box, n_children);
		return box;
	}

	public static uint GetMinChildrenPerLine(this GtkFlowBoxHandle box)
	{
		return GtkFlowBoxExterns.gtk_flow_box_get_min_children_per_line(box);
	}

	public static GtkFlowBoxHandle SetMaxChildrenPerLine(this GtkFlowBoxHandle box, uint n_children)
	{
		GtkFlowBoxExterns.gtk_flow_box_set_max_children_per_line(box, n_children);
		return box;
	}

	public static uint GetMaxChildrenPerLine(this GtkFlowBoxHandle box)
	{
		return GtkFlowBoxExterns.gtk_flow_box_get_max_children_per_line(box);
	}

	public static GtkFlowBoxHandle SetActivateOnSingleClick(this GtkFlowBoxHandle box, int single)
	{
		GtkFlowBoxExterns.gtk_flow_box_set_activate_on_single_click(box, single);
		return box;
	}

	public static int GetActivateOnSingleClick(this GtkFlowBoxHandle box)
	{
		return GtkFlowBoxExterns.gtk_flow_box_get_activate_on_single_click(box);
	}

	public static GtkFlowBoxHandle Prepend(this GtkFlowBoxHandle self, GtkWidgetHandle child)
	{
		GtkFlowBoxExterns.gtk_flow_box_prepend(self, child);
		return self;
	}

	public static GtkFlowBoxHandle Append(this GtkFlowBoxHandle self, GtkWidgetHandle child)
	{
		GtkFlowBoxExterns.gtk_flow_box_append(self, child);
		return self;
	}

	public static GtkFlowBoxHandle Insert(this GtkFlowBoxHandle box, GtkWidgetHandle widget, int position)
	{
		GtkFlowBoxExterns.gtk_flow_box_insert(box, widget, position);
		return box;
	}

	public static GtkFlowBoxHandle Remove(this GtkFlowBoxHandle box, GtkWidgetHandle widget)
	{
		GtkFlowBoxExterns.gtk_flow_box_remove(box, widget);
		return box;
	}

	public static GtkFlowBoxChildHandle GetChildAtIndex(this GtkFlowBoxHandle box, int idx)
	{
		return GtkFlowBoxExterns.gtk_flow_box_get_child_at_index(box, idx);
	}

	public static GtkFlowBoxChildHandle GetChildAtPos(this GtkFlowBoxHandle box, int x, int y)
	{
		return GtkFlowBoxExterns.gtk_flow_box_get_child_at_pos(box, x, y);
	}

	public static GtkFlowBoxHandle SelectedForeach(this GtkFlowBoxHandle box, GtkFlowBoxForeachFunc func, IntPtr data)
	{
		GtkFlowBoxExterns.gtk_flow_box_selected_foreach(box, func, data);
		return box;
	}

	public static GListHandle GetSelectedChildren(this GtkFlowBoxHandle box)
	{
		return GtkFlowBoxExterns.gtk_flow_box_get_selected_children(box);
	}

	public static GtkFlowBoxHandle SelectChild(this GtkFlowBoxHandle box, GtkFlowBoxChildHandle child)
	{
		GtkFlowBoxExterns.gtk_flow_box_select_child(box, child);
		return box;
	}

	public static GtkFlowBoxHandle UnselectChild(this GtkFlowBoxHandle box, GtkFlowBoxChildHandle child)
	{
		GtkFlowBoxExterns.gtk_flow_box_unselect_child(box, child);
		return box;
	}

	public static GtkFlowBoxHandle SelectAll(this GtkFlowBoxHandle box)
	{
		GtkFlowBoxExterns.gtk_flow_box_select_all(box);
		return box;
	}

	public static GtkFlowBoxHandle UnselectAll(this GtkFlowBoxHandle box)
	{
		GtkFlowBoxExterns.gtk_flow_box_unselect_all(box);
		return box;
	}

	public static GtkFlowBoxHandle SetSelectionMode(this GtkFlowBoxHandle box, GtkSelectionMode mode)
	{
		GtkFlowBoxExterns.gtk_flow_box_set_selection_mode(box, mode);
		return box;
	}

	public static GtkSelectionMode GetSelectionMode(this GtkFlowBoxHandle box)
	{
		return GtkFlowBoxExterns.gtk_flow_box_get_selection_mode(box);
	}

	public static GtkFlowBoxHandle SetHadjustment(this GtkFlowBoxHandle box, GtkAdjustmentHandle adjustment)
	{
		GtkFlowBoxExterns.gtk_flow_box_set_hadjustment(box, adjustment);
		return box;
	}

	public static GtkFlowBoxHandle SetVadjustment(this GtkFlowBoxHandle box, GtkAdjustmentHandle adjustment)
	{
		GtkFlowBoxExterns.gtk_flow_box_set_vadjustment(box, adjustment);
		return box;
	}

	public static GtkFlowBoxHandle SetFilterFunc(this GtkFlowBoxHandle box, GtkFlowBoxFilterFunc filter_func, IntPtr user_data, GDestroyNotify destroy)
	{
		GtkFlowBoxExterns.gtk_flow_box_set_filter_func(box, filter_func, user_data, destroy);
		return box;
	}

	public static GtkFlowBoxHandle InvalidateFilter(this GtkFlowBoxHandle box)
	{
		GtkFlowBoxExterns.gtk_flow_box_invalidate_filter(box);
		return box;
	}

	public static GtkFlowBoxHandle SetSortFunc(this GtkFlowBoxHandle box, GtkFlowBoxSortFunc sort_func, IntPtr user_data, GDestroyNotify destroy)
	{
		GtkFlowBoxExterns.gtk_flow_box_set_sort_func(box, sort_func, user_data, destroy);
		return box;
	}

	public static GtkFlowBoxHandle InvalidateSort(this GtkFlowBoxHandle box)
	{
		GtkFlowBoxExterns.gtk_flow_box_invalidate_sort(box);
		return box;
	}
}
