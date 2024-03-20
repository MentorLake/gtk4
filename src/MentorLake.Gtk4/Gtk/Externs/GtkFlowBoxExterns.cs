using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkFlowBoxExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_bind_model")]
    internal static extern void gtk_flow_box_bind_model(this GtkFlowBoxHandle box, GListModelHandle model, GtkFlowBoxCreateWidgetFunc create_widget_func, IntPtr user_data, GDestroyNotify user_data_free_func);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_set_homogeneous")]
    internal static extern void gtk_flow_box_set_homogeneous(this GtkFlowBoxHandle box, int homogeneous);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_get_homogeneous")]
    internal static extern int gtk_flow_box_get_homogeneous(this GtkFlowBoxHandle box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_set_row_spacing")]
    internal static extern void gtk_flow_box_set_row_spacing(this GtkFlowBoxHandle box, uint spacing);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_get_row_spacing")]
    internal static extern uint gtk_flow_box_get_row_spacing(this GtkFlowBoxHandle box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_set_column_spacing")]
    internal static extern void gtk_flow_box_set_column_spacing(this GtkFlowBoxHandle box, uint spacing);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_get_column_spacing")]
    internal static extern uint gtk_flow_box_get_column_spacing(this GtkFlowBoxHandle box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_set_min_children_per_line")]
    internal static extern void gtk_flow_box_set_min_children_per_line(this GtkFlowBoxHandle box, uint n_children);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_get_min_children_per_line")]
    internal static extern uint gtk_flow_box_get_min_children_per_line(this GtkFlowBoxHandle box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_set_max_children_per_line")]
    internal static extern void gtk_flow_box_set_max_children_per_line(this GtkFlowBoxHandle box, uint n_children);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_get_max_children_per_line")]
    internal static extern uint gtk_flow_box_get_max_children_per_line(this GtkFlowBoxHandle box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_set_activate_on_single_click")]
    internal static extern void gtk_flow_box_set_activate_on_single_click(this GtkFlowBoxHandle box, int single);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_get_activate_on_single_click")]
    internal static extern int gtk_flow_box_get_activate_on_single_click(this GtkFlowBoxHandle box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_prepend")]
    internal static extern void gtk_flow_box_prepend(this GtkFlowBoxHandle self, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_append")]
    internal static extern void gtk_flow_box_append(this GtkFlowBoxHandle self, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_insert")]
    internal static extern void gtk_flow_box_insert(this GtkFlowBoxHandle box, GtkWidgetHandle widget, int position);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_remove")]
    internal static extern void gtk_flow_box_remove(this GtkFlowBoxHandle box, GtkWidgetHandle widget);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_get_child_at_index")]
    internal static extern GtkFlowBoxChildHandle gtk_flow_box_get_child_at_index(this GtkFlowBoxHandle box, int idx);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_get_child_at_pos")]
    internal static extern GtkFlowBoxChildHandle gtk_flow_box_get_child_at_pos(this GtkFlowBoxHandle box, int x, int y);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_selected_foreach")]
    internal static extern void gtk_flow_box_selected_foreach(this GtkFlowBoxHandle box, GtkFlowBoxForeachFunc func, IntPtr data);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_get_selected_children")]
    internal static extern GListHandle gtk_flow_box_get_selected_children(this GtkFlowBoxHandle box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_select_child")]
    internal static extern void gtk_flow_box_select_child(this GtkFlowBoxHandle box, GtkFlowBoxChildHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_unselect_child")]
    internal static extern void gtk_flow_box_unselect_child(this GtkFlowBoxHandle box, GtkFlowBoxChildHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_select_all")]
    internal static extern void gtk_flow_box_select_all(this GtkFlowBoxHandle box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_unselect_all")]
    internal static extern void gtk_flow_box_unselect_all(this GtkFlowBoxHandle box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_set_selection_mode")]
    internal static extern void gtk_flow_box_set_selection_mode(this GtkFlowBoxHandle box, GtkSelectionMode mode);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_get_selection_mode")]
    internal static extern GtkSelectionMode gtk_flow_box_get_selection_mode(this GtkFlowBoxHandle box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_set_hadjustment")]
    internal static extern void gtk_flow_box_set_hadjustment(this GtkFlowBoxHandle box, GtkAdjustmentHandle adjustment);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_set_vadjustment")]
    internal static extern void gtk_flow_box_set_vadjustment(this GtkFlowBoxHandle box, GtkAdjustmentHandle adjustment);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_set_filter_func")]
    internal static extern void gtk_flow_box_set_filter_func(this GtkFlowBoxHandle box, GtkFlowBoxFilterFunc filter_func, IntPtr user_data, GDestroyNotify destroy);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_invalidate_filter")]
    internal static extern void gtk_flow_box_invalidate_filter(this GtkFlowBoxHandle box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_set_sort_func")]
    internal static extern void gtk_flow_box_set_sort_func(this GtkFlowBoxHandle box, GtkFlowBoxSortFunc sort_func, IntPtr user_data, GDestroyNotify destroy);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_flow_box_invalidate_sort")]
    internal static extern void gtk_flow_box_invalidate_sort(this GtkFlowBoxHandle box);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkFlowBoxHandle gtk_flow_box_new();
}
