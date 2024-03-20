using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkAdjustmentExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_adjustment_clamp_page")]
    internal static extern void gtk_adjustment_clamp_page(this GtkAdjustmentHandle adjustment, double lower, double upper);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_adjustment_get_value")]
    internal static extern double gtk_adjustment_get_value(this GtkAdjustmentHandle adjustment);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_adjustment_set_value")]
    internal static extern void gtk_adjustment_set_value(this GtkAdjustmentHandle adjustment, double value);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_adjustment_get_lower")]
    internal static extern double gtk_adjustment_get_lower(this GtkAdjustmentHandle adjustment);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_adjustment_set_lower")]
    internal static extern void gtk_adjustment_set_lower(this GtkAdjustmentHandle adjustment, double lower);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_adjustment_get_upper")]
    internal static extern double gtk_adjustment_get_upper(this GtkAdjustmentHandle adjustment);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_adjustment_set_upper")]
    internal static extern void gtk_adjustment_set_upper(this GtkAdjustmentHandle adjustment, double upper);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_adjustment_get_step_increment")]
    internal static extern double gtk_adjustment_get_step_increment(this GtkAdjustmentHandle adjustment);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_adjustment_set_step_increment")]
    internal static extern void gtk_adjustment_set_step_increment(this GtkAdjustmentHandle adjustment, double step_increment);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_adjustment_get_page_increment")]
    internal static extern double gtk_adjustment_get_page_increment(this GtkAdjustmentHandle adjustment);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_adjustment_set_page_increment")]
    internal static extern void gtk_adjustment_set_page_increment(this GtkAdjustmentHandle adjustment, double page_increment);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_adjustment_get_page_size")]
    internal static extern double gtk_adjustment_get_page_size(this GtkAdjustmentHandle adjustment);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_adjustment_set_page_size")]
    internal static extern void gtk_adjustment_set_page_size(this GtkAdjustmentHandle adjustment, double page_size);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_adjustment_configure")]
    internal static extern void gtk_adjustment_configure(this GtkAdjustmentHandle adjustment, double value, double lower, double upper, double step_increment, double page_increment, double page_size);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_adjustment_get_minimum_increment")]
    internal static extern double gtk_adjustment_get_minimum_increment(this GtkAdjustmentHandle adjustment);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_spin_button_new")]
    internal static extern GtkSpinButtonHandle gtk_spin_button_new(this GtkAdjustmentHandle adjustment, double climb_rate, uint digits);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_viewport_new")]
    internal static extern GtkViewportHandle gtk_viewport_new(this GtkAdjustmentHandle hadjustment, GtkAdjustmentHandle vadjustment);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkAdjustmentHandle gtk_adjustment_new(double value, double lower, double upper, double step_increment, double page_increment, double page_size);
}
