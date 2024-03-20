using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkIconViewAdaptors
{
	public static GtkIconViewHandle SetModel(this GtkIconViewHandle icon_view, GtkTreeModelHandle model)
	{
		GtkIconViewExterns.gtk_icon_view_set_model(icon_view, model);
		return icon_view;
	}

	public static GtkTreeModelHandle GetModel(this GtkIconViewHandle icon_view)
	{
		return GtkIconViewExterns.gtk_icon_view_get_model(icon_view);
	}

	public static GtkIconViewHandle SetTextColumn(this GtkIconViewHandle icon_view, int column)
	{
		GtkIconViewExterns.gtk_icon_view_set_text_column(icon_view, column);
		return icon_view;
	}

	public static int GetTextColumn(this GtkIconViewHandle icon_view)
	{
		return GtkIconViewExterns.gtk_icon_view_get_text_column(icon_view);
	}

	public static GtkIconViewHandle SetMarkupColumn(this GtkIconViewHandle icon_view, int column)
	{
		GtkIconViewExterns.gtk_icon_view_set_markup_column(icon_view, column);
		return icon_view;
	}

	public static int GetMarkupColumn(this GtkIconViewHandle icon_view)
	{
		return GtkIconViewExterns.gtk_icon_view_get_markup_column(icon_view);
	}

	public static GtkIconViewHandle SetPixbufColumn(this GtkIconViewHandle icon_view, int column)
	{
		GtkIconViewExterns.gtk_icon_view_set_pixbuf_column(icon_view, column);
		return icon_view;
	}

	public static int GetPixbufColumn(this GtkIconViewHandle icon_view)
	{
		return GtkIconViewExterns.gtk_icon_view_get_pixbuf_column(icon_view);
	}

	public static GtkIconViewHandle SetItemOrientation(this GtkIconViewHandle icon_view, GtkOrientation orientation)
	{
		GtkIconViewExterns.gtk_icon_view_set_item_orientation(icon_view, orientation);
		return icon_view;
	}

	public static GtkOrientation GetItemOrientation(this GtkIconViewHandle icon_view)
	{
		return GtkIconViewExterns.gtk_icon_view_get_item_orientation(icon_view);
	}

	public static GtkIconViewHandle SetColumns(this GtkIconViewHandle icon_view, int columns)
	{
		GtkIconViewExterns.gtk_icon_view_set_columns(icon_view, columns);
		return icon_view;
	}

	public static int GetColumns(this GtkIconViewHandle icon_view)
	{
		return GtkIconViewExterns.gtk_icon_view_get_columns(icon_view);
	}

	public static GtkIconViewHandle SetItemWidth(this GtkIconViewHandle icon_view, int item_width)
	{
		GtkIconViewExterns.gtk_icon_view_set_item_width(icon_view, item_width);
		return icon_view;
	}

	public static int GetItemWidth(this GtkIconViewHandle icon_view)
	{
		return GtkIconViewExterns.gtk_icon_view_get_item_width(icon_view);
	}

	public static GtkIconViewHandle SetSpacing(this GtkIconViewHandle icon_view, int spacing)
	{
		GtkIconViewExterns.gtk_icon_view_set_spacing(icon_view, spacing);
		return icon_view;
	}

	public static int GetSpacing(this GtkIconViewHandle icon_view)
	{
		return GtkIconViewExterns.gtk_icon_view_get_spacing(icon_view);
	}

	public static GtkIconViewHandle SetRowSpacing(this GtkIconViewHandle icon_view, int row_spacing)
	{
		GtkIconViewExterns.gtk_icon_view_set_row_spacing(icon_view, row_spacing);
		return icon_view;
	}

	public static int GetRowSpacing(this GtkIconViewHandle icon_view)
	{
		return GtkIconViewExterns.gtk_icon_view_get_row_spacing(icon_view);
	}

	public static GtkIconViewHandle SetColumnSpacing(this GtkIconViewHandle icon_view, int column_spacing)
	{
		GtkIconViewExterns.gtk_icon_view_set_column_spacing(icon_view, column_spacing);
		return icon_view;
	}

	public static int GetColumnSpacing(this GtkIconViewHandle icon_view)
	{
		return GtkIconViewExterns.gtk_icon_view_get_column_spacing(icon_view);
	}

	public static GtkIconViewHandle SetMargin(this GtkIconViewHandle icon_view, int margin)
	{
		GtkIconViewExterns.gtk_icon_view_set_margin(icon_view, margin);
		return icon_view;
	}

	public static int GetMargin(this GtkIconViewHandle icon_view)
	{
		return GtkIconViewExterns.gtk_icon_view_get_margin(icon_view);
	}

	public static GtkIconViewHandle SetItemPadding(this GtkIconViewHandle icon_view, int item_padding)
	{
		GtkIconViewExterns.gtk_icon_view_set_item_padding(icon_view, item_padding);
		return icon_view;
	}

	public static int GetItemPadding(this GtkIconViewHandle icon_view)
	{
		return GtkIconViewExterns.gtk_icon_view_get_item_padding(icon_view);
	}

	public static GtkTreePathHandle GetPathAtPos(this GtkIconViewHandle icon_view, int x, int y)
	{
		return GtkIconViewExterns.gtk_icon_view_get_path_at_pos(icon_view, x, y);
	}

	public static int GetItemAtPos(this GtkIconViewHandle icon_view, int x, int y, out GtkTreePathHandle path, out GtkCellRendererHandle cell)
	{
		return GtkIconViewExterns.gtk_icon_view_get_item_at_pos(icon_view, x, y, out path, out cell);
	}

	public static int GetVisibleRange(this GtkIconViewHandle icon_view, out GtkTreePathHandle start_path, out GtkTreePathHandle end_path)
	{
		return GtkIconViewExterns.gtk_icon_view_get_visible_range(icon_view, out start_path, out end_path);
	}

	public static GtkIconViewHandle SetActivateOnSingleClick(this GtkIconViewHandle icon_view, int single)
	{
		GtkIconViewExterns.gtk_icon_view_set_activate_on_single_click(icon_view, single);
		return icon_view;
	}

	public static int GetActivateOnSingleClick(this GtkIconViewHandle icon_view)
	{
		return GtkIconViewExterns.gtk_icon_view_get_activate_on_single_click(icon_view);
	}

	public static GtkIconViewHandle SelectedForeach(this GtkIconViewHandle icon_view, GtkIconViewForeachFunc func, IntPtr data)
	{
		GtkIconViewExterns.gtk_icon_view_selected_foreach(icon_view, func, data);
		return icon_view;
	}

	public static GtkIconViewHandle SetSelectionMode(this GtkIconViewHandle icon_view, GtkSelectionMode mode)
	{
		GtkIconViewExterns.gtk_icon_view_set_selection_mode(icon_view, mode);
		return icon_view;
	}

	public static GtkSelectionMode GetSelectionMode(this GtkIconViewHandle icon_view)
	{
		return GtkIconViewExterns.gtk_icon_view_get_selection_mode(icon_view);
	}

	public static GtkIconViewHandle SelectPath(this GtkIconViewHandle icon_view, GtkTreePathHandle path)
	{
		GtkIconViewExterns.gtk_icon_view_select_path(icon_view, path);
		return icon_view;
	}

	public static GtkIconViewHandle UnselectPath(this GtkIconViewHandle icon_view, GtkTreePathHandle path)
	{
		GtkIconViewExterns.gtk_icon_view_unselect_path(icon_view, path);
		return icon_view;
	}

	public static int PathIsSelected(this GtkIconViewHandle icon_view, GtkTreePathHandle path)
	{
		return GtkIconViewExterns.gtk_icon_view_path_is_selected(icon_view, path);
	}

	public static int GetItemRow(this GtkIconViewHandle icon_view, GtkTreePathHandle path)
	{
		return GtkIconViewExterns.gtk_icon_view_get_item_row(icon_view, path);
	}

	public static int GetItemColumn(this GtkIconViewHandle icon_view, GtkTreePathHandle path)
	{
		return GtkIconViewExterns.gtk_icon_view_get_item_column(icon_view, path);
	}

	public static GListHandle GetSelectedItems(this GtkIconViewHandle icon_view)
	{
		return GtkIconViewExterns.gtk_icon_view_get_selected_items(icon_view);
	}

	public static GtkIconViewHandle SelectAll(this GtkIconViewHandle icon_view)
	{
		GtkIconViewExterns.gtk_icon_view_select_all(icon_view);
		return icon_view;
	}

	public static GtkIconViewHandle UnselectAll(this GtkIconViewHandle icon_view)
	{
		GtkIconViewExterns.gtk_icon_view_unselect_all(icon_view);
		return icon_view;
	}

	public static GtkIconViewHandle ItemActivated(this GtkIconViewHandle icon_view, GtkTreePathHandle path)
	{
		GtkIconViewExterns.gtk_icon_view_item_activated(icon_view, path);
		return icon_view;
	}

	public static GtkIconViewHandle SetCursor(this GtkIconViewHandle icon_view, GtkTreePathHandle path, GtkCellRendererHandle cell, int start_editing)
	{
		GtkIconViewExterns.gtk_icon_view_set_cursor(icon_view, path, cell, start_editing);
		return icon_view;
	}

	public static int GetCursor(this GtkIconViewHandle icon_view, out GtkTreePathHandle path, out GtkCellRendererHandle cell)
	{
		return GtkIconViewExterns.gtk_icon_view_get_cursor(icon_view, out path, out cell);
	}

	public static GtkIconViewHandle ScrollToPath(this GtkIconViewHandle icon_view, GtkTreePathHandle path, int use_align, float row_align, float col_align)
	{
		GtkIconViewExterns.gtk_icon_view_scroll_to_path(icon_view, path, use_align, row_align, col_align);
		return icon_view;
	}

	public static GtkIconViewHandle EnableModelDragSource(this GtkIconViewHandle icon_view, GdkModifierType start_button_mask, GdkContentFormatsHandle formats, GdkDragAction actions)
	{
		GtkIconViewExterns.gtk_icon_view_enable_model_drag_source(icon_view, start_button_mask, formats, actions);
		return icon_view;
	}

	public static GtkIconViewHandle EnableModelDragDest(this GtkIconViewHandle icon_view, GdkContentFormatsHandle formats, GdkDragAction actions)
	{
		GtkIconViewExterns.gtk_icon_view_enable_model_drag_dest(icon_view, formats, actions);
		return icon_view;
	}

	public static GtkIconViewHandle UnsetModelDragSource(this GtkIconViewHandle icon_view)
	{
		GtkIconViewExterns.gtk_icon_view_unset_model_drag_source(icon_view);
		return icon_view;
	}

	public static GtkIconViewHandle UnsetModelDragDest(this GtkIconViewHandle icon_view)
	{
		GtkIconViewExterns.gtk_icon_view_unset_model_drag_dest(icon_view);
		return icon_view;
	}

	public static GtkIconViewHandle SetReorderable(this GtkIconViewHandle icon_view, int reorderable)
	{
		GtkIconViewExterns.gtk_icon_view_set_reorderable(icon_view, reorderable);
		return icon_view;
	}

	public static int GetReorderable(this GtkIconViewHandle icon_view)
	{
		return GtkIconViewExterns.gtk_icon_view_get_reorderable(icon_view);
	}

	public static GtkIconViewHandle SetDragDestItem(this GtkIconViewHandle icon_view, GtkTreePathHandle path, GtkIconViewDropPosition pos)
	{
		GtkIconViewExterns.gtk_icon_view_set_drag_dest_item(icon_view, path, pos);
		return icon_view;
	}

	public static GtkIconViewHandle GetDragDestItem(this GtkIconViewHandle icon_view, out GtkTreePathHandle path, out GtkIconViewDropPosition pos)
	{
		GtkIconViewExterns.gtk_icon_view_get_drag_dest_item(icon_view, out path, out pos);
		return icon_view;
	}

	public static int GetDestItemAtPos(this GtkIconViewHandle icon_view, int drag_x, int drag_y, out GtkTreePathHandle path, out GtkIconViewDropPosition pos)
	{
		return GtkIconViewExterns.gtk_icon_view_get_dest_item_at_pos(icon_view, drag_x, drag_y, out path, out pos);
	}

	public static GdkPaintableHandle CreateDragIcon(this GtkIconViewHandle icon_view, GtkTreePathHandle path)
	{
		return GtkIconViewExterns.gtk_icon_view_create_drag_icon(icon_view, path);
	}

	public static int GetCellRect(this GtkIconViewHandle icon_view, GtkTreePathHandle path, GtkCellRendererHandle cell, GdkRectangleHandle rect)
	{
		return GtkIconViewExterns.gtk_icon_view_get_cell_rect(icon_view, path, cell, rect);
	}

	public static GtkIconViewHandle SetTooltipItem(this GtkIconViewHandle icon_view, GtkTooltipHandle tooltip, GtkTreePathHandle path)
	{
		GtkIconViewExterns.gtk_icon_view_set_tooltip_item(icon_view, tooltip, path);
		return icon_view;
	}

	public static GtkIconViewHandle SetTooltipCell(this GtkIconViewHandle icon_view, GtkTooltipHandle tooltip, GtkTreePathHandle path, GtkCellRendererHandle cell)
	{
		GtkIconViewExterns.gtk_icon_view_set_tooltip_cell(icon_view, tooltip, path, cell);
		return icon_view;
	}

	public static int GetTooltipContext(this GtkIconViewHandle icon_view, int x, int y, int keyboard_tip, out GtkTreeModelHandle model, out GtkTreePathHandle path, GtkTreeIterHandle iter)
	{
		return GtkIconViewExterns.gtk_icon_view_get_tooltip_context(icon_view, x, y, keyboard_tip, out model, out path, iter);
	}

	public static GtkIconViewHandle SetTooltipColumn(this GtkIconViewHandle icon_view, int column)
	{
		GtkIconViewExterns.gtk_icon_view_set_tooltip_column(icon_view, column);
		return icon_view;
	}

	public static int GetTooltipColumn(this GtkIconViewHandle icon_view)
	{
		return GtkIconViewExterns.gtk_icon_view_get_tooltip_column(icon_view);
	}
}
