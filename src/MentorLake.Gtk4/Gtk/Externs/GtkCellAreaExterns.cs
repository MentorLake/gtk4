using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;
public static class GtkCellAreaExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_add")]
    internal static extern void gtk_cell_area_add(this GtkCellAreaHandle area, GtkCellRendererHandle renderer);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_remove")]
    internal static extern void gtk_cell_area_remove(this GtkCellAreaHandle area, GtkCellRendererHandle renderer);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_has_renderer")]
    internal static extern int gtk_cell_area_has_renderer(this GtkCellAreaHandle area, GtkCellRendererHandle renderer);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_foreach")]
    internal static extern void gtk_cell_area_foreach(this GtkCellAreaHandle area, GtkCellCallback callback, IntPtr callback_data);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_foreach_alloc")]
    internal static extern void gtk_cell_area_foreach_alloc(this GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, GdkRectangleHandle cell_area, GdkRectangleHandle background_area, GtkCellAllocCallback callback, IntPtr callback_data);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_event")]
    internal static extern int gtk_cell_area_event(this GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, GdkEventHandle @event, GdkRectangleHandle cell_area, GtkCellRendererState flags);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_snapshot")]
    internal static extern void gtk_cell_area_snapshot(this GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, GtkSnapshotHandle snapshot, GdkRectangleHandle background_area, GdkRectangleHandle cell_area, GtkCellRendererState flags, int paint_focus);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_get_cell_allocation")]
    internal static extern void gtk_cell_area_get_cell_allocation(this GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, GtkCellRendererHandle renderer, GdkRectangleHandle cell_area, GdkRectangleHandle allocation);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_get_cell_at_position")]
    internal static extern GtkCellRendererHandle gtk_cell_area_get_cell_at_position(this GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, GdkRectangleHandle cell_area, int x, int y, GdkRectangleHandle alloc_area);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_create_context")]
    internal static extern GtkCellAreaContextHandle gtk_cell_area_create_context(this GtkCellAreaHandle area);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_copy_context")]
    internal static extern GtkCellAreaContextHandle gtk_cell_area_copy_context(this GtkCellAreaHandle area, GtkCellAreaContextHandle context);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_get_request_mode")]
    internal static extern GtkSizeRequestMode gtk_cell_area_get_request_mode(this GtkCellAreaHandle area);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_get_preferred_width")]
    internal static extern void gtk_cell_area_get_preferred_width(this GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, out int minimum_width, out int natural_width);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_get_preferred_height_for_width")]
    internal static extern void gtk_cell_area_get_preferred_height_for_width(this GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, int width, out int minimum_height, out int natural_height);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_get_preferred_height")]
    internal static extern void gtk_cell_area_get_preferred_height(this GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, out int minimum_height, out int natural_height);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_get_preferred_width_for_height")]
    internal static extern void gtk_cell_area_get_preferred_width_for_height(this GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, int height, out int minimum_width, out int natural_width);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_get_current_path_string")]
    internal static extern string gtk_cell_area_get_current_path_string(this GtkCellAreaHandle area);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_apply_attributes")]
    internal static extern void gtk_cell_area_apply_attributes(this GtkCellAreaHandle area, GtkTreeModelHandle tree_model, GtkTreeIterHandle iter, int is_expander, int is_expanded);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_attribute_connect")]
    internal static extern void gtk_cell_area_attribute_connect(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, string attribute, int column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_attribute_disconnect")]
    internal static extern void gtk_cell_area_attribute_disconnect(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, string attribute);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_attribute_get_column")]
    internal static extern int gtk_cell_area_attribute_get_column(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, string attribute);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_add_with_properties")]
    internal static extern void gtk_cell_area_add_with_properties(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, string first_prop_name, IntPtr @__argList);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_cell_set")]
    internal static extern void gtk_cell_area_cell_set(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, string first_prop_name, IntPtr @__argList);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_cell_get")]
    internal static extern void gtk_cell_area_cell_get(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, string first_prop_name, IntPtr @__argList);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_cell_set_valist")]
    internal static extern void gtk_cell_area_cell_set_valist(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, string first_property_name, IntPtr @__argList);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_cell_get_valist")]
    internal static extern void gtk_cell_area_cell_get_valist(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, string first_property_name, IntPtr @__argList);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_cell_set_property")]
    internal static extern void gtk_cell_area_cell_set_property(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, string property_name, GValueHandle value);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_cell_get_property")]
    internal static extern void gtk_cell_area_cell_get_property(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, string property_name, GValueHandle value);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_is_activatable")]
    internal static extern int gtk_cell_area_is_activatable(this GtkCellAreaHandle area);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_activate")]
    internal static extern int gtk_cell_area_activate(this GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, GdkRectangleHandle cell_area, GtkCellRendererState flags, int edit_only);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_focus")]
    internal static extern int gtk_cell_area_focus(this GtkCellAreaHandle area, GtkDirectionType direction);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_set_focus_cell")]
    internal static extern void gtk_cell_area_set_focus_cell(this GtkCellAreaHandle area, GtkCellRendererHandle renderer);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_get_focus_cell")]
    internal static extern GtkCellRendererHandle gtk_cell_area_get_focus_cell(this GtkCellAreaHandle area);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_add_focus_sibling")]
    internal static extern void gtk_cell_area_add_focus_sibling(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, GtkCellRendererHandle sibling);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_remove_focus_sibling")]
    internal static extern void gtk_cell_area_remove_focus_sibling(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, GtkCellRendererHandle sibling);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_is_focus_sibling")]
    internal static extern int gtk_cell_area_is_focus_sibling(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, GtkCellRendererHandle sibling);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_get_focus_siblings")]
    internal static extern GListHandle gtk_cell_area_get_focus_siblings(this GtkCellAreaHandle area, GtkCellRendererHandle renderer);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_get_focus_from_sibling")]
    internal static extern GtkCellRendererHandle gtk_cell_area_get_focus_from_sibling(this GtkCellAreaHandle area, GtkCellRendererHandle renderer);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_get_edited_cell")]
    internal static extern GtkCellRendererHandle gtk_cell_area_get_edited_cell(this GtkCellAreaHandle area);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_get_edit_widget")]
    internal static extern GtkCellEditableHandle gtk_cell_area_get_edit_widget(this GtkCellAreaHandle area);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_activate_cell")]
    internal static extern int gtk_cell_area_activate_cell(this GtkCellAreaHandle area, GtkWidgetHandle widget, GtkCellRendererHandle renderer, GdkEventHandle @event, GdkRectangleHandle cell_area, GtkCellRendererState flags);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_stop_editing")]
    internal static extern void gtk_cell_area_stop_editing(this GtkCellAreaHandle area, int canceled);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_inner_cell_area")]
    internal static extern void gtk_cell_area_inner_cell_area(this GtkCellAreaHandle area, GtkWidgetHandle widget, GdkRectangleHandle cell_area, GdkRectangleHandle inner_area);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_request_renderer")]
    internal static extern void gtk_cell_area_request_renderer(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, GtkOrientation orientation, GtkWidgetHandle widget, int for_size, out int minimum_size, out int natural_size);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_view_new_with_context")]
    internal static extern GtkCellViewHandle gtk_cell_view_new_with_context(this GtkCellAreaHandle area, GtkCellAreaContextHandle context);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_view_column_new_with_area")]
    internal static extern GtkTreeViewColumnHandle gtk_tree_view_column_new_with_area(this GtkCellAreaHandle area);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_completion_new_with_area")]
    internal static extern GtkEntryCompletionHandle gtk_entry_completion_new_with_area(this GtkCellAreaHandle area);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_view_new_with_area")]
    internal static extern GtkIconViewHandle gtk_icon_view_new_with_area(this GtkCellAreaHandle area);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkCellAreaHandle gtk_cell_area_box_new();
}
