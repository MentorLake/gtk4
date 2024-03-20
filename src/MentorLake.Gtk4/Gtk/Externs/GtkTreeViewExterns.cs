using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTreeViewExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_get_model")]
    internal static extern GtkTreeModelHandle gtk_tree_view_get_model(this GtkTreeViewHandle tree_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_set_model")]
    internal static extern void gtk_tree_view_set_model(this GtkTreeViewHandle tree_view, GtkTreeModelHandle model);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_get_selection")]
    internal static extern GtkTreeSelectionHandle gtk_tree_view_get_selection(this GtkTreeViewHandle tree_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_get_headers_visible")]
    internal static extern int gtk_tree_view_get_headers_visible(this GtkTreeViewHandle tree_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_set_headers_visible")]
    internal static extern void gtk_tree_view_set_headers_visible(this GtkTreeViewHandle tree_view, int headers_visible);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_columns_autosize")]
    internal static extern void gtk_tree_view_columns_autosize(this GtkTreeViewHandle tree_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_get_headers_clickable")]
    internal static extern int gtk_tree_view_get_headers_clickable(this GtkTreeViewHandle tree_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_set_headers_clickable")]
    internal static extern void gtk_tree_view_set_headers_clickable(this GtkTreeViewHandle tree_view, int setting);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_get_activate_on_single_click")]
    internal static extern int gtk_tree_view_get_activate_on_single_click(this GtkTreeViewHandle tree_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_set_activate_on_single_click")]
    internal static extern void gtk_tree_view_set_activate_on_single_click(this GtkTreeViewHandle tree_view, int single);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_append_column")]
    internal static extern int gtk_tree_view_append_column(this GtkTreeViewHandle tree_view, GtkTreeViewColumnHandle column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_remove_column")]
    internal static extern int gtk_tree_view_remove_column(this GtkTreeViewHandle tree_view, GtkTreeViewColumnHandle column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_insert_column")]
    internal static extern int gtk_tree_view_insert_column(this GtkTreeViewHandle tree_view, GtkTreeViewColumnHandle column, int position);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_insert_column_with_attributes")]
    internal static extern int gtk_tree_view_insert_column_with_attributes(this GtkTreeViewHandle tree_view, int position, string title, GtkCellRendererHandle cell, IntPtr @__argList);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_insert_column_with_data_func")]
    internal static extern int gtk_tree_view_insert_column_with_data_func(this GtkTreeViewHandle tree_view, int position, string title, GtkCellRendererHandle cell, GtkTreeCellDataFunc func, IntPtr data, GDestroyNotify dnotify);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_get_n_columns")]
    internal static extern uint gtk_tree_view_get_n_columns(this GtkTreeViewHandle tree_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_get_column")]
    internal static extern GtkTreeViewColumnHandle gtk_tree_view_get_column(this GtkTreeViewHandle tree_view, int n);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_get_columns")]
    internal static extern GListHandle gtk_tree_view_get_columns(this GtkTreeViewHandle tree_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_move_column_after")]
    internal static extern void gtk_tree_view_move_column_after(this GtkTreeViewHandle tree_view, GtkTreeViewColumnHandle column, GtkTreeViewColumnHandle base_column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_set_expander_column")]
    internal static extern void gtk_tree_view_set_expander_column(this GtkTreeViewHandle tree_view, GtkTreeViewColumnHandle column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_get_expander_column")]
    internal static extern GtkTreeViewColumnHandle gtk_tree_view_get_expander_column(this GtkTreeViewHandle tree_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_set_column_drag_function")]
    internal static extern void gtk_tree_view_set_column_drag_function(this GtkTreeViewHandle tree_view, GtkTreeViewColumnDropFunc func, IntPtr user_data, GDestroyNotify destroy);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_scroll_to_point")]
    internal static extern void gtk_tree_view_scroll_to_point(this GtkTreeViewHandle tree_view, int tree_x, int tree_y);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_scroll_to_cell")]
    internal static extern void gtk_tree_view_scroll_to_cell(this GtkTreeViewHandle tree_view, GtkTreePathHandle path, GtkTreeViewColumnHandle column, int use_align, float row_align, float col_align);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_row_activated")]
    internal static extern void gtk_tree_view_row_activated(this GtkTreeViewHandle tree_view, GtkTreePathHandle path, GtkTreeViewColumnHandle column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_expand_all")]
    internal static extern void gtk_tree_view_expand_all(this GtkTreeViewHandle tree_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_collapse_all")]
    internal static extern void gtk_tree_view_collapse_all(this GtkTreeViewHandle tree_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_expand_to_path")]
    internal static extern void gtk_tree_view_expand_to_path(this GtkTreeViewHandle tree_view, GtkTreePathHandle path);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_expand_row")]
    internal static extern int gtk_tree_view_expand_row(this GtkTreeViewHandle tree_view, GtkTreePathHandle path, int open_all);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_collapse_row")]
    internal static extern int gtk_tree_view_collapse_row(this GtkTreeViewHandle tree_view, GtkTreePathHandle path);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_map_expanded_rows")]
    internal static extern void gtk_tree_view_map_expanded_rows(this GtkTreeViewHandle tree_view, GtkTreeViewMappingFunc func, IntPtr data);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_row_expanded")]
    internal static extern int gtk_tree_view_row_expanded(this GtkTreeViewHandle tree_view, GtkTreePathHandle path);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_set_reorderable")]
    internal static extern void gtk_tree_view_set_reorderable(this GtkTreeViewHandle tree_view, int reorderable);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_get_reorderable")]
    internal static extern int gtk_tree_view_get_reorderable(this GtkTreeViewHandle tree_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_set_cursor")]
    internal static extern void gtk_tree_view_set_cursor(this GtkTreeViewHandle tree_view, GtkTreePathHandle path, GtkTreeViewColumnHandle focus_column, int start_editing);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_set_cursor_on_cell")]
    internal static extern void gtk_tree_view_set_cursor_on_cell(this GtkTreeViewHandle tree_view, GtkTreePathHandle path, GtkTreeViewColumnHandle focus_column, GtkCellRendererHandle focus_cell, int start_editing);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_get_cursor")]
    internal static extern void gtk_tree_view_get_cursor(this GtkTreeViewHandle tree_view, out GtkTreePathHandle path, out GtkTreeViewColumnHandle focus_column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_get_path_at_pos")]
    internal static extern int gtk_tree_view_get_path_at_pos(this GtkTreeViewHandle tree_view, int x, int y, out GtkTreePathHandle path, out GtkTreeViewColumnHandle column, out int cell_x, out int cell_y);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_get_cell_area")]
    internal static extern void gtk_tree_view_get_cell_area(this GtkTreeViewHandle tree_view, GtkTreePathHandle path, GtkTreeViewColumnHandle column, GdkRectangleHandle rect);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_get_background_area")]
    internal static extern void gtk_tree_view_get_background_area(this GtkTreeViewHandle tree_view, GtkTreePathHandle path, GtkTreeViewColumnHandle column, GdkRectangleHandle rect);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_get_visible_rect")]
    internal static extern void gtk_tree_view_get_visible_rect(this GtkTreeViewHandle tree_view, GdkRectangleHandle visible_rect);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_get_visible_range")]
    internal static extern int gtk_tree_view_get_visible_range(this GtkTreeViewHandle tree_view, out GtkTreePathHandle start_path, out GtkTreePathHandle end_path);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_is_blank_at_pos")]
    internal static extern int gtk_tree_view_is_blank_at_pos(this GtkTreeViewHandle tree_view, int x, int y, out GtkTreePathHandle path, out GtkTreeViewColumnHandle column, out int cell_x, out int cell_y);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_enable_model_drag_source")]
    internal static extern void gtk_tree_view_enable_model_drag_source(this GtkTreeViewHandle tree_view, GdkModifierType start_button_mask, GdkContentFormatsHandle formats, GdkDragAction actions);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_enable_model_drag_dest")]
    internal static extern void gtk_tree_view_enable_model_drag_dest(this GtkTreeViewHandle tree_view, GdkContentFormatsHandle formats, GdkDragAction actions);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_unset_rows_drag_source")]
    internal static extern void gtk_tree_view_unset_rows_drag_source(this GtkTreeViewHandle tree_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_unset_rows_drag_dest")]
    internal static extern void gtk_tree_view_unset_rows_drag_dest(this GtkTreeViewHandle tree_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_set_drag_dest_row")]
    internal static extern void gtk_tree_view_set_drag_dest_row(this GtkTreeViewHandle tree_view, GtkTreePathHandle path, GtkTreeViewDropPosition pos);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_get_drag_dest_row")]
    internal static extern void gtk_tree_view_get_drag_dest_row(this GtkTreeViewHandle tree_view, out GtkTreePathHandle path, out GtkTreeViewDropPosition pos);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_get_dest_row_at_pos")]
    internal static extern int gtk_tree_view_get_dest_row_at_pos(this GtkTreeViewHandle tree_view, int drag_x, int drag_y, out GtkTreePathHandle path, out GtkTreeViewDropPosition pos);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_create_row_drag_icon")]
    internal static extern GdkPaintableHandle gtk_tree_view_create_row_drag_icon(this GtkTreeViewHandle tree_view, GtkTreePathHandle path);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_set_enable_search")]
    internal static extern void gtk_tree_view_set_enable_search(this GtkTreeViewHandle tree_view, int enable_search);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_get_enable_search")]
    internal static extern int gtk_tree_view_get_enable_search(this GtkTreeViewHandle tree_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_get_search_column")]
    internal static extern int gtk_tree_view_get_search_column(this GtkTreeViewHandle tree_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_set_search_column")]
    internal static extern void gtk_tree_view_set_search_column(this GtkTreeViewHandle tree_view, int column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_get_search_equal_func")]
    internal static extern GtkTreeViewSearchEqualFunc gtk_tree_view_get_search_equal_func(this GtkTreeViewHandle tree_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_set_search_equal_func")]
    internal static extern void gtk_tree_view_set_search_equal_func(this GtkTreeViewHandle tree_view, GtkTreeViewSearchEqualFunc search_equal_func, IntPtr search_user_data, GDestroyNotify search_destroy);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_get_search_entry")]
    internal static extern GtkEditableHandle gtk_tree_view_get_search_entry(this GtkTreeViewHandle tree_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_set_search_entry")]
    internal static extern void gtk_tree_view_set_search_entry(this GtkTreeViewHandle tree_view, GtkEditableHandle entry);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_convert_widget_to_tree_coords")]
    internal static extern void gtk_tree_view_convert_widget_to_tree_coords(this GtkTreeViewHandle tree_view, int wx, int wy, out int tx, out int ty);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_convert_tree_to_widget_coords")]
    internal static extern void gtk_tree_view_convert_tree_to_widget_coords(this GtkTreeViewHandle tree_view, int tx, int ty, out int wx, out int wy);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_convert_widget_to_bin_window_coords")]
    internal static extern void gtk_tree_view_convert_widget_to_bin_window_coords(this GtkTreeViewHandle tree_view, int wx, int wy, out int bx, out int by);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_convert_bin_window_to_widget_coords")]
    internal static extern void gtk_tree_view_convert_bin_window_to_widget_coords(this GtkTreeViewHandle tree_view, int bx, int by, out int wx, out int wy);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_convert_tree_to_bin_window_coords")]
    internal static extern void gtk_tree_view_convert_tree_to_bin_window_coords(this GtkTreeViewHandle tree_view, int tx, int ty, out int bx, out int by);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_convert_bin_window_to_tree_coords")]
    internal static extern void gtk_tree_view_convert_bin_window_to_tree_coords(this GtkTreeViewHandle tree_view, int bx, int by, out int tx, out int ty);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_set_fixed_height_mode")]
    internal static extern void gtk_tree_view_set_fixed_height_mode(this GtkTreeViewHandle tree_view, int enable);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_get_fixed_height_mode")]
    internal static extern int gtk_tree_view_get_fixed_height_mode(this GtkTreeViewHandle tree_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_set_hover_selection")]
    internal static extern void gtk_tree_view_set_hover_selection(this GtkTreeViewHandle tree_view, int hover);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_get_hover_selection")]
    internal static extern int gtk_tree_view_get_hover_selection(this GtkTreeViewHandle tree_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_set_hover_expand")]
    internal static extern void gtk_tree_view_set_hover_expand(this GtkTreeViewHandle tree_view, int expand);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_get_hover_expand")]
    internal static extern int gtk_tree_view_get_hover_expand(this GtkTreeViewHandle tree_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_set_rubber_banding")]
    internal static extern void gtk_tree_view_set_rubber_banding(this GtkTreeViewHandle tree_view, int enable);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_get_rubber_banding")]
    internal static extern int gtk_tree_view_get_rubber_banding(this GtkTreeViewHandle tree_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_is_rubber_banding_active")]
    internal static extern int gtk_tree_view_is_rubber_banding_active(this GtkTreeViewHandle tree_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_get_row_separator_func")]
    internal static extern GtkTreeViewRowSeparatorFunc gtk_tree_view_get_row_separator_func(this GtkTreeViewHandle tree_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_set_row_separator_func")]
    internal static extern void gtk_tree_view_set_row_separator_func(this GtkTreeViewHandle tree_view, GtkTreeViewRowSeparatorFunc func, IntPtr data, GDestroyNotify destroy);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_get_grid_lines")]
    internal static extern GtkTreeViewGridLines gtk_tree_view_get_grid_lines(this GtkTreeViewHandle tree_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_set_grid_lines")]
    internal static extern void gtk_tree_view_set_grid_lines(this GtkTreeViewHandle tree_view, GtkTreeViewGridLines grid_lines);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_get_enable_tree_lines")]
    internal static extern int gtk_tree_view_get_enable_tree_lines(this GtkTreeViewHandle tree_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_set_enable_tree_lines")]
    internal static extern void gtk_tree_view_set_enable_tree_lines(this GtkTreeViewHandle tree_view, int enabled);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_set_show_expanders")]
    internal static extern void gtk_tree_view_set_show_expanders(this GtkTreeViewHandle tree_view, int enabled);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_get_show_expanders")]
    internal static extern int gtk_tree_view_get_show_expanders(this GtkTreeViewHandle tree_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_set_level_indentation")]
    internal static extern void gtk_tree_view_set_level_indentation(this GtkTreeViewHandle tree_view, int indentation);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_get_level_indentation")]
    internal static extern int gtk_tree_view_get_level_indentation(this GtkTreeViewHandle tree_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_set_tooltip_row")]
    internal static extern void gtk_tree_view_set_tooltip_row(this GtkTreeViewHandle tree_view, GtkTooltipHandle tooltip, GtkTreePathHandle path);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_set_tooltip_cell")]
    internal static extern void gtk_tree_view_set_tooltip_cell(this GtkTreeViewHandle tree_view, GtkTooltipHandle tooltip, GtkTreePathHandle path, GtkTreeViewColumnHandle column, GtkCellRendererHandle cell);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_get_tooltip_context")]
    internal static extern int gtk_tree_view_get_tooltip_context(this GtkTreeViewHandle tree_view, int x, int y, int keyboard_tip, out GtkTreeModelHandle model, out GtkTreePathHandle path, GtkTreeIterHandle iter);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_set_tooltip_column")]
    internal static extern void gtk_tree_view_set_tooltip_column(this GtkTreeViewHandle tree_view, int column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_get_tooltip_column")]
    internal static extern int gtk_tree_view_get_tooltip_column(this GtkTreeViewHandle tree_view);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkTreeViewHandle gtk_tree_view_new();
}
