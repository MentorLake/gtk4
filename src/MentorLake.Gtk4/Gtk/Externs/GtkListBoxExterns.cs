using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkListBoxExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_prepend")]
    internal static extern void gtk_list_box_prepend(this GtkListBoxHandle box, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_append")]
    internal static extern void gtk_list_box_append(this GtkListBoxHandle box, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_insert")]
    internal static extern void gtk_list_box_insert(this GtkListBoxHandle box, GtkWidgetHandle child, int position);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_remove")]
    internal static extern void gtk_list_box_remove(this GtkListBoxHandle box, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_get_selected_row")]
    internal static extern GtkListBoxRowHandle gtk_list_box_get_selected_row(this GtkListBoxHandle box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_get_row_at_index")]
    internal static extern GtkListBoxRowHandle gtk_list_box_get_row_at_index(this GtkListBoxHandle box, int index_);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_get_row_at_y")]
    internal static extern GtkListBoxRowHandle gtk_list_box_get_row_at_y(this GtkListBoxHandle box, int y);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_select_row")]
    internal static extern void gtk_list_box_select_row(this GtkListBoxHandle box, GtkListBoxRowHandle row);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_set_placeholder")]
    internal static extern void gtk_list_box_set_placeholder(this GtkListBoxHandle box, GtkWidgetHandle placeholder);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_set_adjustment")]
    internal static extern void gtk_list_box_set_adjustment(this GtkListBoxHandle box, GtkAdjustmentHandle adjustment);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_get_adjustment")]
    internal static extern GtkAdjustmentHandle gtk_list_box_get_adjustment(this GtkListBoxHandle box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_selected_foreach")]
    internal static extern void gtk_list_box_selected_foreach(this GtkListBoxHandle box, GtkListBoxForeachFunc func, IntPtr data);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_get_selected_rows")]
    internal static extern GListHandle gtk_list_box_get_selected_rows(this GtkListBoxHandle box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_unselect_row")]
    internal static extern void gtk_list_box_unselect_row(this GtkListBoxHandle box, GtkListBoxRowHandle row);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_select_all")]
    internal static extern void gtk_list_box_select_all(this GtkListBoxHandle box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_unselect_all")]
    internal static extern void gtk_list_box_unselect_all(this GtkListBoxHandle box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_set_selection_mode")]
    internal static extern void gtk_list_box_set_selection_mode(this GtkListBoxHandle box, GtkSelectionMode mode);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_get_selection_mode")]
    internal static extern GtkSelectionMode gtk_list_box_get_selection_mode(this GtkListBoxHandle box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_set_filter_func")]
    internal static extern void gtk_list_box_set_filter_func(this GtkListBoxHandle box, GtkListBoxFilterFunc filter_func, IntPtr user_data, GDestroyNotify destroy);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_set_header_func")]
    internal static extern void gtk_list_box_set_header_func(this GtkListBoxHandle box, GtkListBoxUpdateHeaderFunc update_header, IntPtr user_data, GDestroyNotify destroy);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_invalidate_filter")]
    internal static extern void gtk_list_box_invalidate_filter(this GtkListBoxHandle box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_invalidate_sort")]
    internal static extern void gtk_list_box_invalidate_sort(this GtkListBoxHandle box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_invalidate_headers")]
    internal static extern void gtk_list_box_invalidate_headers(this GtkListBoxHandle box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_set_sort_func")]
    internal static extern void gtk_list_box_set_sort_func(this GtkListBoxHandle box, GtkListBoxSortFunc sort_func, IntPtr user_data, GDestroyNotify destroy);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_set_activate_on_single_click")]
    internal static extern void gtk_list_box_set_activate_on_single_click(this GtkListBoxHandle box, int single);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_get_activate_on_single_click")]
    internal static extern int gtk_list_box_get_activate_on_single_click(this GtkListBoxHandle box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_drag_unhighlight_row")]
    internal static extern void gtk_list_box_drag_unhighlight_row(this GtkListBoxHandle box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_drag_highlight_row")]
    internal static extern void gtk_list_box_drag_highlight_row(this GtkListBoxHandle box, GtkListBoxRowHandle row);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_bind_model")]
    internal static extern void gtk_list_box_bind_model(this GtkListBoxHandle box, GListModelHandle model, GtkListBoxCreateWidgetFunc create_widget_func, IntPtr user_data, GDestroyNotify user_data_free_func);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_set_show_separators")]
    internal static extern void gtk_list_box_set_show_separators(this GtkListBoxHandle box, int show_separators);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_get_show_separators")]
    internal static extern int gtk_list_box_get_show_separators(this GtkListBoxHandle box);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkListBoxHandle gtk_list_box_new();
}
