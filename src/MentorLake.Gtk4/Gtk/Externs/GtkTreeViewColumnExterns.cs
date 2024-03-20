using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTreeViewColumnExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_pack_start")]
    internal static extern void gtk_tree_view_column_pack_start(this GtkTreeViewColumnHandle tree_column, GtkCellRendererHandle cell, int expand);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_pack_end")]
    internal static extern void gtk_tree_view_column_pack_end(this GtkTreeViewColumnHandle tree_column, GtkCellRendererHandle cell, int expand);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_clear")]
    internal static extern void gtk_tree_view_column_clear(this GtkTreeViewColumnHandle tree_column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_add_attribute")]
    internal static extern void gtk_tree_view_column_add_attribute(this GtkTreeViewColumnHandle tree_column, GtkCellRendererHandle cell_renderer, string attribute, int column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_set_attributes")]
    internal static extern void gtk_tree_view_column_set_attributes(this GtkTreeViewColumnHandle tree_column, GtkCellRendererHandle cell_renderer, IntPtr @__argList);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_set_cell_data_func")]
    internal static extern void gtk_tree_view_column_set_cell_data_func(this GtkTreeViewColumnHandle tree_column, GtkCellRendererHandle cell_renderer, GtkTreeCellDataFunc func, IntPtr func_data, GDestroyNotify destroy);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_clear_attributes")]
    internal static extern void gtk_tree_view_column_clear_attributes(this GtkTreeViewColumnHandle tree_column, GtkCellRendererHandle cell_renderer);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_set_spacing")]
    internal static extern void gtk_tree_view_column_set_spacing(this GtkTreeViewColumnHandle tree_column, int spacing);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_get_spacing")]
    internal static extern int gtk_tree_view_column_get_spacing(this GtkTreeViewColumnHandle tree_column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_set_visible")]
    internal static extern void gtk_tree_view_column_set_visible(this GtkTreeViewColumnHandle tree_column, int visible);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_get_visible")]
    internal static extern int gtk_tree_view_column_get_visible(this GtkTreeViewColumnHandle tree_column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_set_resizable")]
    internal static extern void gtk_tree_view_column_set_resizable(this GtkTreeViewColumnHandle tree_column, int resizable);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_get_resizable")]
    internal static extern int gtk_tree_view_column_get_resizable(this GtkTreeViewColumnHandle tree_column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_set_sizing")]
    internal static extern void gtk_tree_view_column_set_sizing(this GtkTreeViewColumnHandle tree_column, GtkTreeViewColumnSizing type);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_get_sizing")]
    internal static extern GtkTreeViewColumnSizing gtk_tree_view_column_get_sizing(this GtkTreeViewColumnHandle tree_column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_get_x_offset")]
    internal static extern int gtk_tree_view_column_get_x_offset(this GtkTreeViewColumnHandle tree_column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_get_width")]
    internal static extern int gtk_tree_view_column_get_width(this GtkTreeViewColumnHandle tree_column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_get_fixed_width")]
    internal static extern int gtk_tree_view_column_get_fixed_width(this GtkTreeViewColumnHandle tree_column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_set_fixed_width")]
    internal static extern void gtk_tree_view_column_set_fixed_width(this GtkTreeViewColumnHandle tree_column, int fixed_width);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_set_min_width")]
    internal static extern void gtk_tree_view_column_set_min_width(this GtkTreeViewColumnHandle tree_column, int min_width);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_get_min_width")]
    internal static extern int gtk_tree_view_column_get_min_width(this GtkTreeViewColumnHandle tree_column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_set_max_width")]
    internal static extern void gtk_tree_view_column_set_max_width(this GtkTreeViewColumnHandle tree_column, int max_width);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_get_max_width")]
    internal static extern int gtk_tree_view_column_get_max_width(this GtkTreeViewColumnHandle tree_column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_clicked")]
    internal static extern void gtk_tree_view_column_clicked(this GtkTreeViewColumnHandle tree_column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_set_title")]
    internal static extern void gtk_tree_view_column_set_title(this GtkTreeViewColumnHandle tree_column, string title);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_get_title")]
    internal static extern string gtk_tree_view_column_get_title(this GtkTreeViewColumnHandle tree_column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_set_expand")]
    internal static extern void gtk_tree_view_column_set_expand(this GtkTreeViewColumnHandle tree_column, int expand);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_get_expand")]
    internal static extern int gtk_tree_view_column_get_expand(this GtkTreeViewColumnHandle tree_column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_set_clickable")]
    internal static extern void gtk_tree_view_column_set_clickable(this GtkTreeViewColumnHandle tree_column, int clickable);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_get_clickable")]
    internal static extern int gtk_tree_view_column_get_clickable(this GtkTreeViewColumnHandle tree_column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_set_widget")]
    internal static extern void gtk_tree_view_column_set_widget(this GtkTreeViewColumnHandle tree_column, GtkWidgetHandle widget);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_get_widget")]
    internal static extern GtkWidgetHandle gtk_tree_view_column_get_widget(this GtkTreeViewColumnHandle tree_column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_set_alignment")]
    internal static extern void gtk_tree_view_column_set_alignment(this GtkTreeViewColumnHandle tree_column, float xalign);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_get_alignment")]
    internal static extern float gtk_tree_view_column_get_alignment(this GtkTreeViewColumnHandle tree_column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_set_reorderable")]
    internal static extern void gtk_tree_view_column_set_reorderable(this GtkTreeViewColumnHandle tree_column, int reorderable);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_get_reorderable")]
    internal static extern int gtk_tree_view_column_get_reorderable(this GtkTreeViewColumnHandle tree_column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_set_sort_column_id")]
    internal static extern void gtk_tree_view_column_set_sort_column_id(this GtkTreeViewColumnHandle tree_column, int sort_column_id);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_get_sort_column_id")]
    internal static extern int gtk_tree_view_column_get_sort_column_id(this GtkTreeViewColumnHandle tree_column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_set_sort_indicator")]
    internal static extern void gtk_tree_view_column_set_sort_indicator(this GtkTreeViewColumnHandle tree_column, int setting);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_get_sort_indicator")]
    internal static extern int gtk_tree_view_column_get_sort_indicator(this GtkTreeViewColumnHandle tree_column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_set_sort_order")]
    internal static extern void gtk_tree_view_column_set_sort_order(this GtkTreeViewColumnHandle tree_column, GtkSortType order);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_get_sort_order")]
    internal static extern GtkSortType gtk_tree_view_column_get_sort_order(this GtkTreeViewColumnHandle tree_column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_cell_set_cell_data")]
    internal static extern void gtk_tree_view_column_cell_set_cell_data(this GtkTreeViewColumnHandle tree_column, GtkTreeModelHandle tree_model, GtkTreeIterHandle iter, int is_expander, int is_expanded);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_cell_get_size")]
    internal static extern void gtk_tree_view_column_cell_get_size(this GtkTreeViewColumnHandle tree_column, out int x_offset, out int y_offset, out int width, out int height);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_cell_is_visible")]
    internal static extern int gtk_tree_view_column_cell_is_visible(this GtkTreeViewColumnHandle tree_column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_focus_cell")]
    internal static extern void gtk_tree_view_column_focus_cell(this GtkTreeViewColumnHandle tree_column, GtkCellRendererHandle cell);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_cell_get_position")]
    internal static extern int gtk_tree_view_column_cell_get_position(this GtkTreeViewColumnHandle tree_column, GtkCellRendererHandle cell_renderer, out int x_offset, out int width);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_queue_resize")]
    internal static extern void gtk_tree_view_column_queue_resize(this GtkTreeViewColumnHandle tree_column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_get_tree_view")]
    internal static extern GtkWidgetHandle gtk_tree_view_column_get_tree_view(this GtkTreeViewColumnHandle tree_column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_get_button")]
    internal static extern GtkWidgetHandle gtk_tree_view_column_get_button(this GtkTreeViewColumnHandle tree_column);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkTreeViewColumnHandle gtk_tree_view_column_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkTreeViewColumnHandle gtk_tree_view_column_new_with_attributes(string title, GtkCellRendererHandle cell, IntPtr @__arglist);
}
