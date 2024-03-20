using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkScaleButtonExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scale_button_set_icons")]
    internal static extern void gtk_scale_button_set_icons(this GtkScaleButtonHandle button, string[] icons);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scale_button_get_value")]
    internal static extern double gtk_scale_button_get_value(this GtkScaleButtonHandle button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scale_button_set_value")]
    internal static extern void gtk_scale_button_set_value(this GtkScaleButtonHandle button, double value);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scale_button_get_adjustment")]
    internal static extern GtkAdjustmentHandle gtk_scale_button_get_adjustment(this GtkScaleButtonHandle button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scale_button_set_adjustment")]
    internal static extern void gtk_scale_button_set_adjustment(this GtkScaleButtonHandle button, GtkAdjustmentHandle adjustment);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scale_button_get_plus_button")]
    internal static extern GtkWidgetHandle gtk_scale_button_get_plus_button(this GtkScaleButtonHandle button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scale_button_get_minus_button")]
    internal static extern GtkWidgetHandle gtk_scale_button_get_minus_button(this GtkScaleButtonHandle button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scale_button_get_popup")]
    internal static extern GtkWidgetHandle gtk_scale_button_get_popup(this GtkScaleButtonHandle button);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkScaleButtonHandle gtk_scale_button_new(double min, double max, double step, string[] icons);
}
