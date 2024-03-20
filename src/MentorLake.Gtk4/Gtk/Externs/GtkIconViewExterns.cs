using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkIconViewExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_set_model")]
    internal static extern void gtk_icon_view_set_model(this GtkIconViewHandle icon_view, GtkTreeModelHandle model);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_get_model")]
    internal static extern GtkTreeModelHandle gtk_icon_view_get_model(this GtkIconViewHandle icon_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_set_text_column")]
    internal static extern void gtk_icon_view_set_text_column(this GtkIconViewHandle icon_view, int column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_get_text_column")]
    internal static extern int gtk_icon_view_get_text_column(this GtkIconViewHandle icon_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_set_markup_column")]
    internal static extern void gtk_icon_view_set_markup_column(this GtkIconViewHandle icon_view, int column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_get_markup_column")]
    internal static extern int gtk_icon_view_get_markup_column(this GtkIconViewHandle icon_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_set_pixbuf_column")]
    internal static extern void gtk_icon_view_set_pixbuf_column(this GtkIconViewHandle icon_view, int column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_get_pixbuf_column")]
    internal static extern int gtk_icon_view_get_pixbuf_column(this GtkIconViewHandle icon_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_set_item_orientation")]
    internal static extern void gtk_icon_view_set_item_orientation(this GtkIconViewHandle icon_view, GtkOrientation orientation);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_get_item_orientation")]
    internal static extern GtkOrientation gtk_icon_view_get_item_orientation(this GtkIconViewHandle icon_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_set_columns")]
    internal static extern void gtk_icon_view_set_columns(this GtkIconViewHandle icon_view, int columns);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_get_columns")]
    internal static extern int gtk_icon_view_get_columns(this GtkIconViewHandle icon_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_set_item_width")]
    internal static extern void gtk_icon_view_set_item_width(this GtkIconViewHandle icon_view, int item_width);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_get_item_width")]
    internal static extern int gtk_icon_view_get_item_width(this GtkIconViewHandle icon_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_set_spacing")]
    internal static extern void gtk_icon_view_set_spacing(this GtkIconViewHandle icon_view, int spacing);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_get_spacing")]
    internal static extern int gtk_icon_view_get_spacing(this GtkIconViewHandle icon_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_set_row_spacing")]
    internal static extern void gtk_icon_view_set_row_spacing(this GtkIconViewHandle icon_view, int row_spacing);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_get_row_spacing")]
    internal static extern int gtk_icon_view_get_row_spacing(this GtkIconViewHandle icon_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_set_column_spacing")]
    internal static extern void gtk_icon_view_set_column_spacing(this GtkIconViewHandle icon_view, int column_spacing);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_get_column_spacing")]
    internal static extern int gtk_icon_view_get_column_spacing(this GtkIconViewHandle icon_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_set_margin")]
    internal static extern void gtk_icon_view_set_margin(this GtkIconViewHandle icon_view, int margin);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_get_margin")]
    internal static extern int gtk_icon_view_get_margin(this GtkIconViewHandle icon_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_set_item_padding")]
    internal static extern void gtk_icon_view_set_item_padding(this GtkIconViewHandle icon_view, int item_padding);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_get_item_padding")]
    internal static extern int gtk_icon_view_get_item_padding(this GtkIconViewHandle icon_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_get_path_at_pos")]
    internal static extern GtkTreePathHandle gtk_icon_view_get_path_at_pos(this GtkIconViewHandle icon_view, int x, int y);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_get_item_at_pos")]
    internal static extern int gtk_icon_view_get_item_at_pos(this GtkIconViewHandle icon_view, int x, int y, out GtkTreePathHandle path, out GtkCellRendererHandle cell);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_get_visible_range")]
    internal static extern int gtk_icon_view_get_visible_range(this GtkIconViewHandle icon_view, out GtkTreePathHandle start_path, out GtkTreePathHandle end_path);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_set_activate_on_single_click")]
    internal static extern void gtk_icon_view_set_activate_on_single_click(this GtkIconViewHandle icon_view, int single);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_get_activate_on_single_click")]
    internal static extern int gtk_icon_view_get_activate_on_single_click(this GtkIconViewHandle icon_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_selected_foreach")]
    internal static extern void gtk_icon_view_selected_foreach(this GtkIconViewHandle icon_view, GtkIconViewForeachFunc func, IntPtr data);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_set_selection_mode")]
    internal static extern void gtk_icon_view_set_selection_mode(this GtkIconViewHandle icon_view, GtkSelectionMode mode);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_get_selection_mode")]
    internal static extern GtkSelectionMode gtk_icon_view_get_selection_mode(this GtkIconViewHandle icon_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_select_path")]
    internal static extern void gtk_icon_view_select_path(this GtkIconViewHandle icon_view, GtkTreePathHandle path);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_unselect_path")]
    internal static extern void gtk_icon_view_unselect_path(this GtkIconViewHandle icon_view, GtkTreePathHandle path);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_path_is_selected")]
    internal static extern int gtk_icon_view_path_is_selected(this GtkIconViewHandle icon_view, GtkTreePathHandle path);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_get_item_row")]
    internal static extern int gtk_icon_view_get_item_row(this GtkIconViewHandle icon_view, GtkTreePathHandle path);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_get_item_column")]
    internal static extern int gtk_icon_view_get_item_column(this GtkIconViewHandle icon_view, GtkTreePathHandle path);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_get_selected_items")]
    internal static extern GListHandle gtk_icon_view_get_selected_items(this GtkIconViewHandle icon_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_select_all")]
    internal static extern void gtk_icon_view_select_all(this GtkIconViewHandle icon_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_unselect_all")]
    internal static extern void gtk_icon_view_unselect_all(this GtkIconViewHandle icon_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_item_activated")]
    internal static extern void gtk_icon_view_item_activated(this GtkIconViewHandle icon_view, GtkTreePathHandle path);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_set_cursor")]
    internal static extern void gtk_icon_view_set_cursor(this GtkIconViewHandle icon_view, GtkTreePathHandle path, GtkCellRendererHandle cell, int start_editing);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_get_cursor")]
    internal static extern int gtk_icon_view_get_cursor(this GtkIconViewHandle icon_view, out GtkTreePathHandle path, out GtkCellRendererHandle cell);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_scroll_to_path")]
    internal static extern void gtk_icon_view_scroll_to_path(this GtkIconViewHandle icon_view, GtkTreePathHandle path, int use_align, float row_align, float col_align);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_enable_model_drag_source")]
    internal static extern void gtk_icon_view_enable_model_drag_source(this GtkIconViewHandle icon_view, GdkModifierType start_button_mask, GdkContentFormatsHandle formats, GdkDragAction actions);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_enable_model_drag_dest")]
    internal static extern void gtk_icon_view_enable_model_drag_dest(this GtkIconViewHandle icon_view, GdkContentFormatsHandle formats, GdkDragAction actions);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_unset_model_drag_source")]
    internal static extern void gtk_icon_view_unset_model_drag_source(this GtkIconViewHandle icon_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_unset_model_drag_dest")]
    internal static extern void gtk_icon_view_unset_model_drag_dest(this GtkIconViewHandle icon_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_set_reorderable")]
    internal static extern void gtk_icon_view_set_reorderable(this GtkIconViewHandle icon_view, int reorderable);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_get_reorderable")]
    internal static extern int gtk_icon_view_get_reorderable(this GtkIconViewHandle icon_view);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_set_drag_dest_item")]
    internal static extern void gtk_icon_view_set_drag_dest_item(this GtkIconViewHandle icon_view, GtkTreePathHandle path, GtkIconViewDropPosition pos);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_get_drag_dest_item")]
    internal static extern void gtk_icon_view_get_drag_dest_item(this GtkIconViewHandle icon_view, out GtkTreePathHandle path, out GtkIconViewDropPosition pos);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_get_dest_item_at_pos")]
    internal static extern int gtk_icon_view_get_dest_item_at_pos(this GtkIconViewHandle icon_view, int drag_x, int drag_y, out GtkTreePathHandle path, out GtkIconViewDropPosition pos);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_create_drag_icon")]
    internal static extern GdkPaintableHandle gtk_icon_view_create_drag_icon(this GtkIconViewHandle icon_view, GtkTreePathHandle path);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_get_cell_rect")]
    internal static extern int gtk_icon_view_get_cell_rect(this GtkIconViewHandle icon_view, GtkTreePathHandle path, GtkCellRendererHandle cell, GdkRectangleHandle rect);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_set_tooltip_item")]
    internal static extern void gtk_icon_view_set_tooltip_item(this GtkIconViewHandle icon_view, GtkTooltipHandle tooltip, GtkTreePathHandle path);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_set_tooltip_cell")]
    internal static extern void gtk_icon_view_set_tooltip_cell(this GtkIconViewHandle icon_view, GtkTooltipHandle tooltip, GtkTreePathHandle path, GtkCellRendererHandle cell);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_get_tooltip_context")]
    internal static extern int gtk_icon_view_get_tooltip_context(this GtkIconViewHandle icon_view, int x, int y, int keyboard_tip, out GtkTreeModelHandle model, out GtkTreePathHandle path, GtkTreeIterHandle iter);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_set_tooltip_column")]
    internal static extern void gtk_icon_view_set_tooltip_column(this GtkIconViewHandle icon_view, int column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_get_tooltip_column")]
    internal static extern int gtk_icon_view_get_tooltip_column(this GtkIconViewHandle icon_view);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkIconViewHandle gtk_icon_view_new();
}
