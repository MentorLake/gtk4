using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;
public static class GtkCellRendererExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_renderer_get_request_mode")]
    internal static extern GtkSizeRequestMode gtk_cell_renderer_get_request_mode(this GtkCellRendererHandle cell);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_renderer_get_preferred_width")]
    internal static extern void gtk_cell_renderer_get_preferred_width(this GtkCellRendererHandle cell, GtkWidgetHandle widget, out int minimum_size, out int natural_size);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_renderer_get_preferred_height_for_width")]
    internal static extern void gtk_cell_renderer_get_preferred_height_for_width(this GtkCellRendererHandle cell, GtkWidgetHandle widget, int width, out int minimum_height, out int natural_height);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_renderer_get_preferred_height")]
    internal static extern void gtk_cell_renderer_get_preferred_height(this GtkCellRendererHandle cell, GtkWidgetHandle widget, out int minimum_size, out int natural_size);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_renderer_get_preferred_width_for_height")]
    internal static extern void gtk_cell_renderer_get_preferred_width_for_height(this GtkCellRendererHandle cell, GtkWidgetHandle widget, int height, out int minimum_width, out int natural_width);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_renderer_get_preferred_size")]
    internal static extern void gtk_cell_renderer_get_preferred_size(this GtkCellRendererHandle cell, GtkWidgetHandle widget, GtkRequisitionHandle minimum_size, GtkRequisitionHandle natural_size);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_renderer_get_aligned_area")]
    internal static extern void gtk_cell_renderer_get_aligned_area(this GtkCellRendererHandle cell, GtkWidgetHandle widget, GtkCellRendererState flags, GdkRectangleHandle cell_area, GdkRectangleHandle aligned_area);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_renderer_snapshot")]
    internal static extern void gtk_cell_renderer_snapshot(this GtkCellRendererHandle cell, GtkSnapshotHandle snapshot, GtkWidgetHandle widget, GdkRectangleHandle background_area, GdkRectangleHandle cell_area, GtkCellRendererState flags);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_renderer_activate")]
    internal static extern int gtk_cell_renderer_activate(this GtkCellRendererHandle cell, GdkEventHandle @event, GtkWidgetHandle widget, string path, GdkRectangleHandle background_area, GdkRectangleHandle cell_area, GtkCellRendererState flags);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_renderer_start_editing")]
    internal static extern GtkCellEditableHandle gtk_cell_renderer_start_editing(this GtkCellRendererHandle cell, GdkEventHandle @event, GtkWidgetHandle widget, string path, GdkRectangleHandle background_area, GdkRectangleHandle cell_area, GtkCellRendererState flags);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_renderer_set_fixed_size")]
    internal static extern void gtk_cell_renderer_set_fixed_size(this GtkCellRendererHandle cell, int width, int height);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_renderer_get_fixed_size")]
    internal static extern void gtk_cell_renderer_get_fixed_size(this GtkCellRendererHandle cell, out int width, out int height);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_renderer_set_alignment")]
    internal static extern void gtk_cell_renderer_set_alignment(this GtkCellRendererHandle cell, float xalign, float yalign);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_renderer_get_alignment")]
    internal static extern void gtk_cell_renderer_get_alignment(this GtkCellRendererHandle cell, out float xalign, out float yalign);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_renderer_set_padding")]
    internal static extern void gtk_cell_renderer_set_padding(this GtkCellRendererHandle cell, int xpad, int ypad);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_renderer_get_padding")]
    internal static extern void gtk_cell_renderer_get_padding(this GtkCellRendererHandle cell, out int xpad, out int ypad);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_renderer_set_visible")]
    internal static extern void gtk_cell_renderer_set_visible(this GtkCellRendererHandle cell, int visible);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_renderer_get_visible")]
    internal static extern int gtk_cell_renderer_get_visible(this GtkCellRendererHandle cell);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_renderer_set_sensitive")]
    internal static extern void gtk_cell_renderer_set_sensitive(this GtkCellRendererHandle cell, int sensitive);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_renderer_get_sensitive")]
    internal static extern int gtk_cell_renderer_get_sensitive(this GtkCellRendererHandle cell);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_renderer_is_activatable")]
    internal static extern int gtk_cell_renderer_is_activatable(this GtkCellRendererHandle cell);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_renderer_set_is_expander")]
    internal static extern void gtk_cell_renderer_set_is_expander(this GtkCellRendererHandle cell, int is_expander);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_renderer_get_is_expander")]
    internal static extern int gtk_cell_renderer_get_is_expander(this GtkCellRendererHandle cell);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_renderer_set_is_expanded")]
    internal static extern void gtk_cell_renderer_set_is_expanded(this GtkCellRendererHandle cell, int is_expanded);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_renderer_get_is_expanded")]
    internal static extern int gtk_cell_renderer_get_is_expanded(this GtkCellRendererHandle cell);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_renderer_stop_editing")]
    internal static extern void gtk_cell_renderer_stop_editing(this GtkCellRendererHandle cell, int canceled);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_renderer_get_state")]
    internal static extern GtkStateFlags gtk_cell_renderer_get_state(this GtkCellRendererHandle cell, GtkWidgetHandle widget, GtkCellRendererState cell_state);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkCellRendererHandle gtk_cell_renderer_text_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkCellRendererHandle gtk_cell_renderer_accel_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkCellRendererHandle gtk_cell_renderer_combo_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkCellRendererHandle gtk_cell_renderer_pixbuf_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkCellRendererHandle gtk_cell_renderer_progress_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkCellRendererHandle gtk_cell_renderer_spin_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkCellRendererHandle gtk_cell_renderer_spinner_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkCellRendererHandle gtk_cell_renderer_toggle_new();
}
