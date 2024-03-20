using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkLayoutManagerExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_layout_manager_measure")]
    internal static extern void gtk_layout_manager_measure(this GtkLayoutManagerHandle manager, GtkWidgetHandle widget, GtkOrientation orientation, int for_size, out int minimum, out int natural, out int minimum_baseline, out int natural_baseline);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_layout_manager_allocate")]
    internal static extern void gtk_layout_manager_allocate(this GtkLayoutManagerHandle manager, GtkWidgetHandle widget, int width, int height, int baseline);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_layout_manager_get_request_mode")]
    internal static extern GtkSizeRequestMode gtk_layout_manager_get_request_mode(this GtkLayoutManagerHandle manager);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_layout_manager_get_widget")]
    internal static extern GtkWidgetHandle gtk_layout_manager_get_widget(this GtkLayoutManagerHandle manager);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_layout_manager_layout_changed")]
    internal static extern void gtk_layout_manager_layout_changed(this GtkLayoutManagerHandle manager);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_layout_manager_get_layout_child")]
    internal static extern GtkLayoutChildHandle gtk_layout_manager_get_layout_child(this GtkLayoutManagerHandle manager, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkLayoutManagerHandle gtk_bin_layout_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkLayoutManagerHandle gtk_box_layout_new(GtkOrientation orientation);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkLayoutManagerHandle gtk_center_layout_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkLayoutManagerHandle gtk_constraint_layout_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkLayoutManagerHandle gtk_custom_layout_new(GtkCustomRequestModeFunc request_mode, GtkCustomMeasureFunc measure, GtkCustomAllocateFunc allocate);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkLayoutManagerHandle gtk_fixed_layout_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkLayoutManagerHandle gtk_grid_layout_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkLayoutManagerHandle gtk_overlay_layout_new();
}
