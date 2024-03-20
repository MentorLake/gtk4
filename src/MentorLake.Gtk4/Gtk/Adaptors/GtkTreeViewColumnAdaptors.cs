using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTreeViewColumnAdaptors
{
	public static GtkTreeViewColumnHandle PackStart(this GtkTreeViewColumnHandle tree_column, GtkCellRendererHandle cell, int expand)
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_pack_start(tree_column, cell, expand);
		return tree_column;
	}

	public static GtkTreeViewColumnHandle PackEnd(this GtkTreeViewColumnHandle tree_column, GtkCellRendererHandle cell, int expand)
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_pack_end(tree_column, cell, expand);
		return tree_column;
	}

	public static GtkTreeViewColumnHandle Clear(this GtkTreeViewColumnHandle tree_column)
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_clear(tree_column);
		return tree_column;
	}

	public static GtkTreeViewColumnHandle AddAttribute(this GtkTreeViewColumnHandle tree_column, GtkCellRendererHandle cell_renderer, string attribute, int column)
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_add_attribute(tree_column, cell_renderer, attribute, column);
		return tree_column;
	}

	public static GtkTreeViewColumnHandle SetAttributes(this GtkTreeViewColumnHandle tree_column, GtkCellRendererHandle cell_renderer, IntPtr @__argList)
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_attributes(tree_column, cell_renderer, @__argList);
		return tree_column;
	}

	public static GtkTreeViewColumnHandle SetCellDataFunc(this GtkTreeViewColumnHandle tree_column, GtkCellRendererHandle cell_renderer, GtkTreeCellDataFunc func, IntPtr func_data, GDestroyNotify destroy)
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_cell_data_func(tree_column, cell_renderer, func, func_data, destroy);
		return tree_column;
	}

	public static GtkTreeViewColumnHandle ClearAttributes(this GtkTreeViewColumnHandle tree_column, GtkCellRendererHandle cell_renderer)
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_clear_attributes(tree_column, cell_renderer);
		return tree_column;
	}

	public static GtkTreeViewColumnHandle SetSpacing(this GtkTreeViewColumnHandle tree_column, int spacing)
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_spacing(tree_column, spacing);
		return tree_column;
	}

	public static int GetSpacing(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_spacing(tree_column);
	}

	public static GtkTreeViewColumnHandle SetVisible(this GtkTreeViewColumnHandle tree_column, int visible)
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_visible(tree_column, visible);
		return tree_column;
	}

	public static int GetVisible(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_visible(tree_column);
	}

	public static GtkTreeViewColumnHandle SetResizable(this GtkTreeViewColumnHandle tree_column, int resizable)
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_resizable(tree_column, resizable);
		return tree_column;
	}

	public static int GetResizable(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_resizable(tree_column);
	}

	public static GtkTreeViewColumnHandle SetSizing(this GtkTreeViewColumnHandle tree_column, GtkTreeViewColumnSizing type)
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_sizing(tree_column, type);
		return tree_column;
	}

	public static GtkTreeViewColumnSizing GetSizing(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_sizing(tree_column);
	}

	public static int GetXOffset(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_x_offset(tree_column);
	}

	public static int GetWidth(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_width(tree_column);
	}

	public static int GetFixedWidth(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_fixed_width(tree_column);
	}

	public static GtkTreeViewColumnHandle SetFixedWidth(this GtkTreeViewColumnHandle tree_column, int fixed_width)
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_fixed_width(tree_column, fixed_width);
		return tree_column;
	}

	public static GtkTreeViewColumnHandle SetMinWidth(this GtkTreeViewColumnHandle tree_column, int min_width)
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_min_width(tree_column, min_width);
		return tree_column;
	}

	public static int GetMinWidth(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_min_width(tree_column);
	}

	public static GtkTreeViewColumnHandle SetMaxWidth(this GtkTreeViewColumnHandle tree_column, int max_width)
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_max_width(tree_column, max_width);
		return tree_column;
	}

	public static int GetMaxWidth(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_max_width(tree_column);
	}

	public static GtkTreeViewColumnHandle Clicked(this GtkTreeViewColumnHandle tree_column)
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_clicked(tree_column);
		return tree_column;
	}

	public static GtkTreeViewColumnHandle SetTitle(this GtkTreeViewColumnHandle tree_column, string title)
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_title(tree_column, title);
		return tree_column;
	}

	public static string GetTitle(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_title(tree_column);
	}

	public static GtkTreeViewColumnHandle SetExpand(this GtkTreeViewColumnHandle tree_column, int expand)
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_expand(tree_column, expand);
		return tree_column;
	}

	public static int GetExpand(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_expand(tree_column);
	}

	public static GtkTreeViewColumnHandle SetClickable(this GtkTreeViewColumnHandle tree_column, int clickable)
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_clickable(tree_column, clickable);
		return tree_column;
	}

	public static int GetClickable(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_clickable(tree_column);
	}

	public static GtkTreeViewColumnHandle SetWidget(this GtkTreeViewColumnHandle tree_column, GtkWidgetHandle widget)
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_widget(tree_column, widget);
		return tree_column;
	}

	public static GtkWidgetHandle GetWidget(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_widget(tree_column);
	}

	public static GtkTreeViewColumnHandle SetAlignment(this GtkTreeViewColumnHandle tree_column, float xalign)
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_alignment(tree_column, xalign);
		return tree_column;
	}

	public static float GetAlignment(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_alignment(tree_column);
	}

	public static GtkTreeViewColumnHandle SetReorderable(this GtkTreeViewColumnHandle tree_column, int reorderable)
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_reorderable(tree_column, reorderable);
		return tree_column;
	}

	public static int GetReorderable(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_reorderable(tree_column);
	}

	public static GtkTreeViewColumnHandle SetSortColumnId(this GtkTreeViewColumnHandle tree_column, int sort_column_id)
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_sort_column_id(tree_column, sort_column_id);
		return tree_column;
	}

	public static int GetSortColumnId(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_sort_column_id(tree_column);
	}

	public static GtkTreeViewColumnHandle SetSortIndicator(this GtkTreeViewColumnHandle tree_column, int setting)
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_sort_indicator(tree_column, setting);
		return tree_column;
	}

	public static int GetSortIndicator(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_sort_indicator(tree_column);
	}

	public static GtkTreeViewColumnHandle SetSortOrder(this GtkTreeViewColumnHandle tree_column, GtkSortType order)
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_sort_order(tree_column, order);
		return tree_column;
	}

	public static GtkSortType GetSortOrder(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_sort_order(tree_column);
	}

	public static GtkTreeViewColumnHandle CellSetCellData(this GtkTreeViewColumnHandle tree_column, GtkTreeModelHandle tree_model, GtkTreeIterHandle iter, int is_expander, int is_expanded)
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_cell_set_cell_data(tree_column, tree_model, iter, is_expander, is_expanded);
		return tree_column;
	}

	public static GtkTreeViewColumnHandle CellGetSize(this GtkTreeViewColumnHandle tree_column, out int x_offset, out int y_offset, out int width, out int height)
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_cell_get_size(tree_column, out x_offset, out y_offset, out width, out height);
		return tree_column;
	}

	public static int CellIsVisible(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_cell_is_visible(tree_column);
	}

	public static GtkTreeViewColumnHandle FocusCell(this GtkTreeViewColumnHandle tree_column, GtkCellRendererHandle cell)
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_focus_cell(tree_column, cell);
		return tree_column;
	}

	public static int CellGetPosition(this GtkTreeViewColumnHandle tree_column, GtkCellRendererHandle cell_renderer, out int x_offset, out int width)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_cell_get_position(tree_column, cell_renderer, out x_offset, out width);
	}

	public static GtkTreeViewColumnHandle QueueResize(this GtkTreeViewColumnHandle tree_column)
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_queue_resize(tree_column);
		return tree_column;
	}

	public static GtkWidgetHandle GetTreeView(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_tree_view(tree_column);
	}

	public static GtkWidgetHandle GetButton(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_button(tree_column);
	}

	public static GtkTreeViewColumnHandle NewWithAttributes(string title, GtkCellRendererHandle cell, IntPtr @__arglist)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_new_with_attributes(title, cell, @__arglist);
	}
}
