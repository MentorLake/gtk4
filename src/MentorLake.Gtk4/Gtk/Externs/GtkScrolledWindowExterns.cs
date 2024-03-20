using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkScrolledWindowExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scrolled_window_set_hadjustment")]
    internal static extern void gtk_scrolled_window_set_hadjustment(this GtkScrolledWindowHandle scrolled_window, GtkAdjustmentHandle hadjustment);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scrolled_window_set_vadjustment")]
    internal static extern void gtk_scrolled_window_set_vadjustment(this GtkScrolledWindowHandle scrolled_window, GtkAdjustmentHandle vadjustment);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scrolled_window_get_hadjustment")]
    internal static extern GtkAdjustmentHandle gtk_scrolled_window_get_hadjustment(this GtkScrolledWindowHandle scrolled_window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scrolled_window_get_vadjustment")]
    internal static extern GtkAdjustmentHandle gtk_scrolled_window_get_vadjustment(this GtkScrolledWindowHandle scrolled_window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scrolled_window_get_hscrollbar")]
    internal static extern GtkWidgetHandle gtk_scrolled_window_get_hscrollbar(this GtkScrolledWindowHandle scrolled_window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scrolled_window_get_vscrollbar")]
    internal static extern GtkWidgetHandle gtk_scrolled_window_get_vscrollbar(this GtkScrolledWindowHandle scrolled_window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scrolled_window_set_policy")]
    internal static extern void gtk_scrolled_window_set_policy(this GtkScrolledWindowHandle scrolled_window, GtkPolicyType hscrollbar_policy, GtkPolicyType vscrollbar_policy);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scrolled_window_get_policy")]
    internal static extern void gtk_scrolled_window_get_policy(this GtkScrolledWindowHandle scrolled_window, out GtkPolicyType hscrollbar_policy, out GtkPolicyType vscrollbar_policy);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scrolled_window_set_placement")]
    internal static extern void gtk_scrolled_window_set_placement(this GtkScrolledWindowHandle scrolled_window, GtkCornerType window_placement);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scrolled_window_unset_placement")]
    internal static extern void gtk_scrolled_window_unset_placement(this GtkScrolledWindowHandle scrolled_window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scrolled_window_get_placement")]
    internal static extern GtkCornerType gtk_scrolled_window_get_placement(this GtkScrolledWindowHandle scrolled_window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scrolled_window_set_has_frame")]
    internal static extern void gtk_scrolled_window_set_has_frame(this GtkScrolledWindowHandle scrolled_window, int has_frame);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scrolled_window_get_has_frame")]
    internal static extern int gtk_scrolled_window_get_has_frame(this GtkScrolledWindowHandle scrolled_window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scrolled_window_get_min_content_width")]
    internal static extern int gtk_scrolled_window_get_min_content_width(this GtkScrolledWindowHandle scrolled_window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scrolled_window_set_min_content_width")]
    internal static extern void gtk_scrolled_window_set_min_content_width(this GtkScrolledWindowHandle scrolled_window, int width);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scrolled_window_get_min_content_height")]
    internal static extern int gtk_scrolled_window_get_min_content_height(this GtkScrolledWindowHandle scrolled_window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scrolled_window_set_min_content_height")]
    internal static extern void gtk_scrolled_window_set_min_content_height(this GtkScrolledWindowHandle scrolled_window, int height);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scrolled_window_set_kinetic_scrolling")]
    internal static extern void gtk_scrolled_window_set_kinetic_scrolling(this GtkScrolledWindowHandle scrolled_window, int kinetic_scrolling);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scrolled_window_get_kinetic_scrolling")]
    internal static extern int gtk_scrolled_window_get_kinetic_scrolling(this GtkScrolledWindowHandle scrolled_window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scrolled_window_set_overlay_scrolling")]
    internal static extern void gtk_scrolled_window_set_overlay_scrolling(this GtkScrolledWindowHandle scrolled_window, int overlay_scrolling);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scrolled_window_get_overlay_scrolling")]
    internal static extern int gtk_scrolled_window_get_overlay_scrolling(this GtkScrolledWindowHandle scrolled_window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scrolled_window_set_max_content_width")]
    internal static extern void gtk_scrolled_window_set_max_content_width(this GtkScrolledWindowHandle scrolled_window, int width);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scrolled_window_get_max_content_width")]
    internal static extern int gtk_scrolled_window_get_max_content_width(this GtkScrolledWindowHandle scrolled_window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scrolled_window_set_max_content_height")]
    internal static extern void gtk_scrolled_window_set_max_content_height(this GtkScrolledWindowHandle scrolled_window, int height);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scrolled_window_get_max_content_height")]
    internal static extern int gtk_scrolled_window_get_max_content_height(this GtkScrolledWindowHandle scrolled_window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scrolled_window_set_propagate_natural_width")]
    internal static extern void gtk_scrolled_window_set_propagate_natural_width(this GtkScrolledWindowHandle scrolled_window, int propagate);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scrolled_window_get_propagate_natural_width")]
    internal static extern int gtk_scrolled_window_get_propagate_natural_width(this GtkScrolledWindowHandle scrolled_window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scrolled_window_set_propagate_natural_height")]
    internal static extern void gtk_scrolled_window_set_propagate_natural_height(this GtkScrolledWindowHandle scrolled_window, int propagate);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scrolled_window_get_propagate_natural_height")]
    internal static extern int gtk_scrolled_window_get_propagate_natural_height(this GtkScrolledWindowHandle scrolled_window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scrolled_window_set_child")]
    internal static extern void gtk_scrolled_window_set_child(this GtkScrolledWindowHandle scrolled_window, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scrolled_window_get_child")]
    internal static extern GtkWidgetHandle gtk_scrolled_window_get_child(this GtkScrolledWindowHandle scrolled_window);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkScrolledWindowHandle gtk_scrolled_window_new();
}
