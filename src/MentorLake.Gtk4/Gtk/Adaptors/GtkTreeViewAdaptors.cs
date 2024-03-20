using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTreeViewAdaptors
{
	public static GtkTreeModelHandle GetModel(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_model(tree_view);
	}

	public static GtkTreeViewHandle SetModel(this GtkTreeViewHandle tree_view, GtkTreeModelHandle model)
	{
		GtkTreeViewExterns.gtk_tree_view_set_model(tree_view, model);
		return tree_view;
	}

	public static GtkTreeSelectionHandle GetSelection(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_selection(tree_view);
	}

	public static int GetHeadersVisible(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_headers_visible(tree_view);
	}

	public static GtkTreeViewHandle SetHeadersVisible(this GtkTreeViewHandle tree_view, int headers_visible)
	{
		GtkTreeViewExterns.gtk_tree_view_set_headers_visible(tree_view, headers_visible);
		return tree_view;
	}

	public static GtkTreeViewHandle ColumnsAutosize(this GtkTreeViewHandle tree_view)
	{
		GtkTreeViewExterns.gtk_tree_view_columns_autosize(tree_view);
		return tree_view;
	}

	public static int GetHeadersClickable(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_headers_clickable(tree_view);
	}

	public static GtkTreeViewHandle SetHeadersClickable(this GtkTreeViewHandle tree_view, int setting)
	{
		GtkTreeViewExterns.gtk_tree_view_set_headers_clickable(tree_view, setting);
		return tree_view;
	}

	public static int GetActivateOnSingleClick(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_activate_on_single_click(tree_view);
	}

	public static GtkTreeViewHandle SetActivateOnSingleClick(this GtkTreeViewHandle tree_view, int single)
	{
		GtkTreeViewExterns.gtk_tree_view_set_activate_on_single_click(tree_view, single);
		return tree_view;
	}

	public static int AppendColumn(this GtkTreeViewHandle tree_view, GtkTreeViewColumnHandle column)
	{
		return GtkTreeViewExterns.gtk_tree_view_append_column(tree_view, column);
	}

	public static int RemoveColumn(this GtkTreeViewHandle tree_view, GtkTreeViewColumnHandle column)
	{
		return GtkTreeViewExterns.gtk_tree_view_remove_column(tree_view, column);
	}

	public static int InsertColumn(this GtkTreeViewHandle tree_view, GtkTreeViewColumnHandle column, int position)
	{
		return GtkTreeViewExterns.gtk_tree_view_insert_column(tree_view, column, position);
	}

	public static int InsertColumnWithAttributes(this GtkTreeViewHandle tree_view, int position, string title, GtkCellRendererHandle cell, IntPtr @__argList)
	{
		return GtkTreeViewExterns.gtk_tree_view_insert_column_with_attributes(tree_view, position, title, cell, @__argList);
	}

	public static int InsertColumnWithDataFunc(this GtkTreeViewHandle tree_view, int position, string title, GtkCellRendererHandle cell, GtkTreeCellDataFunc func, IntPtr data, GDestroyNotify dnotify)
	{
		return GtkTreeViewExterns.gtk_tree_view_insert_column_with_data_func(tree_view, position, title, cell, func, data, dnotify);
	}

	public static uint GetNColumns(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_n_columns(tree_view);
	}

	public static GtkTreeViewColumnHandle GetColumn(this GtkTreeViewHandle tree_view, int n)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_column(tree_view, n);
	}

	public static GListHandle GetColumns(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_columns(tree_view);
	}

	public static GtkTreeViewHandle MoveColumnAfter(this GtkTreeViewHandle tree_view, GtkTreeViewColumnHandle column, GtkTreeViewColumnHandle base_column)
	{
		GtkTreeViewExterns.gtk_tree_view_move_column_after(tree_view, column, base_column);
		return tree_view;
	}

	public static GtkTreeViewHandle SetExpanderColumn(this GtkTreeViewHandle tree_view, GtkTreeViewColumnHandle column)
	{
		GtkTreeViewExterns.gtk_tree_view_set_expander_column(tree_view, column);
		return tree_view;
	}

	public static GtkTreeViewColumnHandle GetExpanderColumn(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_expander_column(tree_view);
	}

	public static GtkTreeViewHandle SetColumnDragFunction(this GtkTreeViewHandle tree_view, GtkTreeViewColumnDropFunc func, IntPtr user_data, GDestroyNotify destroy)
	{
		GtkTreeViewExterns.gtk_tree_view_set_column_drag_function(tree_view, func, user_data, destroy);
		return tree_view;
	}

	public static GtkTreeViewHandle ScrollToPoint(this GtkTreeViewHandle tree_view, int tree_x, int tree_y)
	{
		GtkTreeViewExterns.gtk_tree_view_scroll_to_point(tree_view, tree_x, tree_y);
		return tree_view;
	}

	public static GtkTreeViewHandle ScrollToCell(this GtkTreeViewHandle tree_view, GtkTreePathHandle path, GtkTreeViewColumnHandle column, int use_align, float row_align, float col_align)
	{
		GtkTreeViewExterns.gtk_tree_view_scroll_to_cell(tree_view, path, column, use_align, row_align, col_align);
		return tree_view;
	}

	public static GtkTreeViewHandle RowActivated(this GtkTreeViewHandle tree_view, GtkTreePathHandle path, GtkTreeViewColumnHandle column)
	{
		GtkTreeViewExterns.gtk_tree_view_row_activated(tree_view, path, column);
		return tree_view;
	}

	public static GtkTreeViewHandle ExpandAll(this GtkTreeViewHandle tree_view)
	{
		GtkTreeViewExterns.gtk_tree_view_expand_all(tree_view);
		return tree_view;
	}

	public static GtkTreeViewHandle CollapseAll(this GtkTreeViewHandle tree_view)
	{
		GtkTreeViewExterns.gtk_tree_view_collapse_all(tree_view);
		return tree_view;
	}

	public static GtkTreeViewHandle ExpandToPath(this GtkTreeViewHandle tree_view, GtkTreePathHandle path)
	{
		GtkTreeViewExterns.gtk_tree_view_expand_to_path(tree_view, path);
		return tree_view;
	}

	public static int ExpandRow(this GtkTreeViewHandle tree_view, GtkTreePathHandle path, int open_all)
	{
		return GtkTreeViewExterns.gtk_tree_view_expand_row(tree_view, path, open_all);
	}

	public static int CollapseRow(this GtkTreeViewHandle tree_view, GtkTreePathHandle path)
	{
		return GtkTreeViewExterns.gtk_tree_view_collapse_row(tree_view, path);
	}

	public static GtkTreeViewHandle MapExpandedRows(this GtkTreeViewHandle tree_view, GtkTreeViewMappingFunc func, IntPtr data)
	{
		GtkTreeViewExterns.gtk_tree_view_map_expanded_rows(tree_view, func, data);
		return tree_view;
	}

	public static int RowExpanded(this GtkTreeViewHandle tree_view, GtkTreePathHandle path)
	{
		return GtkTreeViewExterns.gtk_tree_view_row_expanded(tree_view, path);
	}

	public static GtkTreeViewHandle SetReorderable(this GtkTreeViewHandle tree_view, int reorderable)
	{
		GtkTreeViewExterns.gtk_tree_view_set_reorderable(tree_view, reorderable);
		return tree_view;
	}

	public static int GetReorderable(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_reorderable(tree_view);
	}

	public static GtkTreeViewHandle SetCursor(this GtkTreeViewHandle tree_view, GtkTreePathHandle path, GtkTreeViewColumnHandle focus_column, int start_editing)
	{
		GtkTreeViewExterns.gtk_tree_view_set_cursor(tree_view, path, focus_column, start_editing);
		return tree_view;
	}

	public static GtkTreeViewHandle SetCursorOnCell(this GtkTreeViewHandle tree_view, GtkTreePathHandle path, GtkTreeViewColumnHandle focus_column, GtkCellRendererHandle focus_cell, int start_editing)
	{
		GtkTreeViewExterns.gtk_tree_view_set_cursor_on_cell(tree_view, path, focus_column, focus_cell, start_editing);
		return tree_view;
	}

	public static GtkTreeViewHandle GetCursor(this GtkTreeViewHandle tree_view, out GtkTreePathHandle path, out GtkTreeViewColumnHandle focus_column)
	{
		GtkTreeViewExterns.gtk_tree_view_get_cursor(tree_view, out path, out focus_column);
		return tree_view;
	}

	public static int GetPathAtPos(this GtkTreeViewHandle tree_view, int x, int y, out GtkTreePathHandle path, out GtkTreeViewColumnHandle column, out int cell_x, out int cell_y)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_path_at_pos(tree_view, x, y, out path, out column, out cell_x, out cell_y);
	}

	public static GtkTreeViewHandle GetCellArea(this GtkTreeViewHandle tree_view, GtkTreePathHandle path, GtkTreeViewColumnHandle column, GdkRectangleHandle rect)
	{
		GtkTreeViewExterns.gtk_tree_view_get_cell_area(tree_view, path, column, rect);
		return tree_view;
	}

	public static GtkTreeViewHandle GetBackgroundArea(this GtkTreeViewHandle tree_view, GtkTreePathHandle path, GtkTreeViewColumnHandle column, GdkRectangleHandle rect)
	{
		GtkTreeViewExterns.gtk_tree_view_get_background_area(tree_view, path, column, rect);
		return tree_view;
	}

	public static GtkTreeViewHandle GetVisibleRect(this GtkTreeViewHandle tree_view, GdkRectangleHandle visible_rect)
	{
		GtkTreeViewExterns.gtk_tree_view_get_visible_rect(tree_view, visible_rect);
		return tree_view;
	}

	public static int GetVisibleRange(this GtkTreeViewHandle tree_view, out GtkTreePathHandle start_path, out GtkTreePathHandle end_path)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_visible_range(tree_view, out start_path, out end_path);
	}

	public static int IsBlankAtPos(this GtkTreeViewHandle tree_view, int x, int y, out GtkTreePathHandle path, out GtkTreeViewColumnHandle column, out int cell_x, out int cell_y)
	{
		return GtkTreeViewExterns.gtk_tree_view_is_blank_at_pos(tree_view, x, y, out path, out column, out cell_x, out cell_y);
	}

	public static GtkTreeViewHandle EnableModelDragSource(this GtkTreeViewHandle tree_view, GdkModifierType start_button_mask, GdkContentFormatsHandle formats, GdkDragAction actions)
	{
		GtkTreeViewExterns.gtk_tree_view_enable_model_drag_source(tree_view, start_button_mask, formats, actions);
		return tree_view;
	}

	public static GtkTreeViewHandle EnableModelDragDest(this GtkTreeViewHandle tree_view, GdkContentFormatsHandle formats, GdkDragAction actions)
	{
		GtkTreeViewExterns.gtk_tree_view_enable_model_drag_dest(tree_view, formats, actions);
		return tree_view;
	}

	public static GtkTreeViewHandle UnsetRowsDragSource(this GtkTreeViewHandle tree_view)
	{
		GtkTreeViewExterns.gtk_tree_view_unset_rows_drag_source(tree_view);
		return tree_view;
	}

	public static GtkTreeViewHandle UnsetRowsDragDest(this GtkTreeViewHandle tree_view)
	{
		GtkTreeViewExterns.gtk_tree_view_unset_rows_drag_dest(tree_view);
		return tree_view;
	}

	public static GtkTreeViewHandle SetDragDestRow(this GtkTreeViewHandle tree_view, GtkTreePathHandle path, GtkTreeViewDropPosition pos)
	{
		GtkTreeViewExterns.gtk_tree_view_set_drag_dest_row(tree_view, path, pos);
		return tree_view;
	}

	public static GtkTreeViewHandle GetDragDestRow(this GtkTreeViewHandle tree_view, out GtkTreePathHandle path, out GtkTreeViewDropPosition pos)
	{
		GtkTreeViewExterns.gtk_tree_view_get_drag_dest_row(tree_view, out path, out pos);
		return tree_view;
	}

	public static int GetDestRowAtPos(this GtkTreeViewHandle tree_view, int drag_x, int drag_y, out GtkTreePathHandle path, out GtkTreeViewDropPosition pos)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_dest_row_at_pos(tree_view, drag_x, drag_y, out path, out pos);
	}

	public static GdkPaintableHandle CreateRowDragIcon(this GtkTreeViewHandle tree_view, GtkTreePathHandle path)
	{
		return GtkTreeViewExterns.gtk_tree_view_create_row_drag_icon(tree_view, path);
	}

	public static GtkTreeViewHandle SetEnableSearch(this GtkTreeViewHandle tree_view, int enable_search)
	{
		GtkTreeViewExterns.gtk_tree_view_set_enable_search(tree_view, enable_search);
		return tree_view;
	}

	public static int GetEnableSearch(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_enable_search(tree_view);
	}

	public static int GetSearchColumn(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_search_column(tree_view);
	}

	public static GtkTreeViewHandle SetSearchColumn(this GtkTreeViewHandle tree_view, int column)
	{
		GtkTreeViewExterns.gtk_tree_view_set_search_column(tree_view, column);
		return tree_view;
	}

	public static GtkTreeViewSearchEqualFunc GetSearchEqualFunc(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_search_equal_func(tree_view);
	}

	public static GtkTreeViewHandle SetSearchEqualFunc(this GtkTreeViewHandle tree_view, GtkTreeViewSearchEqualFunc search_equal_func, IntPtr search_user_data, GDestroyNotify search_destroy)
	{
		GtkTreeViewExterns.gtk_tree_view_set_search_equal_func(tree_view, search_equal_func, search_user_data, search_destroy);
		return tree_view;
	}

	public static GtkEditableHandle GetSearchEntry(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_search_entry(tree_view);
	}

	public static GtkTreeViewHandle SetSearchEntry(this GtkTreeViewHandle tree_view, GtkEditableHandle entry)
	{
		GtkTreeViewExterns.gtk_tree_view_set_search_entry(tree_view, entry);
		return tree_view;
	}

	public static GtkTreeViewHandle ConvertWidgetToTreeCoords(this GtkTreeViewHandle tree_view, int wx, int wy, out int tx, out int ty)
	{
		GtkTreeViewExterns.gtk_tree_view_convert_widget_to_tree_coords(tree_view, wx, wy, out tx, out ty);
		return tree_view;
	}

	public static GtkTreeViewHandle ConvertTreeToWidgetCoords(this GtkTreeViewHandle tree_view, int tx, int ty, out int wx, out int wy)
	{
		GtkTreeViewExterns.gtk_tree_view_convert_tree_to_widget_coords(tree_view, tx, ty, out wx, out wy);
		return tree_view;
	}

	public static GtkTreeViewHandle ConvertWidgetToBinWindowCoords(this GtkTreeViewHandle tree_view, int wx, int wy, out int bx, out int by)
	{
		GtkTreeViewExterns.gtk_tree_view_convert_widget_to_bin_window_coords(tree_view, wx, wy, out bx, out by);
		return tree_view;
	}

	public static GtkTreeViewHandle ConvertBinWindowToWidgetCoords(this GtkTreeViewHandle tree_view, int bx, int by, out int wx, out int wy)
	{
		GtkTreeViewExterns.gtk_tree_view_convert_bin_window_to_widget_coords(tree_view, bx, by, out wx, out wy);
		return tree_view;
	}

	public static GtkTreeViewHandle ConvertTreeToBinWindowCoords(this GtkTreeViewHandle tree_view, int tx, int ty, out int bx, out int by)
	{
		GtkTreeViewExterns.gtk_tree_view_convert_tree_to_bin_window_coords(tree_view, tx, ty, out bx, out by);
		return tree_view;
	}

	public static GtkTreeViewHandle ConvertBinWindowToTreeCoords(this GtkTreeViewHandle tree_view, int bx, int by, out int tx, out int ty)
	{
		GtkTreeViewExterns.gtk_tree_view_convert_bin_window_to_tree_coords(tree_view, bx, by, out tx, out ty);
		return tree_view;
	}

	public static GtkTreeViewHandle SetFixedHeightMode(this GtkTreeViewHandle tree_view, int enable)
	{
		GtkTreeViewExterns.gtk_tree_view_set_fixed_height_mode(tree_view, enable);
		return tree_view;
	}

	public static int GetFixedHeightMode(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_fixed_height_mode(tree_view);
	}

	public static GtkTreeViewHandle SetHoverSelection(this GtkTreeViewHandle tree_view, int hover)
	{
		GtkTreeViewExterns.gtk_tree_view_set_hover_selection(tree_view, hover);
		return tree_view;
	}

	public static int GetHoverSelection(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_hover_selection(tree_view);
	}

	public static GtkTreeViewHandle SetHoverExpand(this GtkTreeViewHandle tree_view, int expand)
	{
		GtkTreeViewExterns.gtk_tree_view_set_hover_expand(tree_view, expand);
		return tree_view;
	}

	public static int GetHoverExpand(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_hover_expand(tree_view);
	}

	public static GtkTreeViewHandle SetRubberBanding(this GtkTreeViewHandle tree_view, int enable)
	{
		GtkTreeViewExterns.gtk_tree_view_set_rubber_banding(tree_view, enable);
		return tree_view;
	}

	public static int GetRubberBanding(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_rubber_banding(tree_view);
	}

	public static int IsRubberBandingActive(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_is_rubber_banding_active(tree_view);
	}

	public static GtkTreeViewRowSeparatorFunc GetRowSeparatorFunc(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_row_separator_func(tree_view);
	}

	public static GtkTreeViewHandle SetRowSeparatorFunc(this GtkTreeViewHandle tree_view, GtkTreeViewRowSeparatorFunc func, IntPtr data, GDestroyNotify destroy)
	{
		GtkTreeViewExterns.gtk_tree_view_set_row_separator_func(tree_view, func, data, destroy);
		return tree_view;
	}

	public static GtkTreeViewGridLines GetGridLines(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_grid_lines(tree_view);
	}

	public static GtkTreeViewHandle SetGridLines(this GtkTreeViewHandle tree_view, GtkTreeViewGridLines grid_lines)
	{
		GtkTreeViewExterns.gtk_tree_view_set_grid_lines(tree_view, grid_lines);
		return tree_view;
	}

	public static int GetEnableTreeLines(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_enable_tree_lines(tree_view);
	}

	public static GtkTreeViewHandle SetEnableTreeLines(this GtkTreeViewHandle tree_view, int enabled)
	{
		GtkTreeViewExterns.gtk_tree_view_set_enable_tree_lines(tree_view, enabled);
		return tree_view;
	}

	public static GtkTreeViewHandle SetShowExpanders(this GtkTreeViewHandle tree_view, int enabled)
	{
		GtkTreeViewExterns.gtk_tree_view_set_show_expanders(tree_view, enabled);
		return tree_view;
	}

	public static int GetShowExpanders(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_show_expanders(tree_view);
	}

	public static GtkTreeViewHandle SetLevelIndentation(this GtkTreeViewHandle tree_view, int indentation)
	{
		GtkTreeViewExterns.gtk_tree_view_set_level_indentation(tree_view, indentation);
		return tree_view;
	}

	public static int GetLevelIndentation(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_level_indentation(tree_view);
	}

	public static GtkTreeViewHandle SetTooltipRow(this GtkTreeViewHandle tree_view, GtkTooltipHandle tooltip, GtkTreePathHandle path)
	{
		GtkTreeViewExterns.gtk_tree_view_set_tooltip_row(tree_view, tooltip, path);
		return tree_view;
	}

	public static GtkTreeViewHandle SetTooltipCell(this GtkTreeViewHandle tree_view, GtkTooltipHandle tooltip, GtkTreePathHandle path, GtkTreeViewColumnHandle column, GtkCellRendererHandle cell)
	{
		GtkTreeViewExterns.gtk_tree_view_set_tooltip_cell(tree_view, tooltip, path, column, cell);
		return tree_view;
	}

	public static int GetTooltipContext(this GtkTreeViewHandle tree_view, int x, int y, int keyboard_tip, out GtkTreeModelHandle model, out GtkTreePathHandle path, GtkTreeIterHandle iter)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_tooltip_context(tree_view, x, y, keyboard_tip, out model, out path, iter);
	}

	public static GtkTreeViewHandle SetTooltipColumn(this GtkTreeViewHandle tree_view, int column)
	{
		GtkTreeViewExterns.gtk_tree_view_set_tooltip_column(tree_view, column);
		return tree_view;
	}

	public static int GetTooltipColumn(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_tooltip_column(tree_view);
	}
}
