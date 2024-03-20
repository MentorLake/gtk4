using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkSpinButtonExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_spin_button_configure")]
    internal static extern void gtk_spin_button_configure(this GtkSpinButtonHandle spin_button, GtkAdjustmentHandle adjustment, double climb_rate, uint digits);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_spin_button_set_adjustment")]
    internal static extern void gtk_spin_button_set_adjustment(this GtkSpinButtonHandle spin_button, GtkAdjustmentHandle adjustment);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_spin_button_get_adjustment")]
    internal static extern GtkAdjustmentHandle gtk_spin_button_get_adjustment(this GtkSpinButtonHandle spin_button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_spin_button_set_digits")]
    internal static extern void gtk_spin_button_set_digits(this GtkSpinButtonHandle spin_button, uint digits);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_spin_button_get_digits")]
    internal static extern uint gtk_spin_button_get_digits(this GtkSpinButtonHandle spin_button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_spin_button_set_increments")]
    internal static extern void gtk_spin_button_set_increments(this GtkSpinButtonHandle spin_button, double step, double page);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_spin_button_get_increments")]
    internal static extern void gtk_spin_button_get_increments(this GtkSpinButtonHandle spin_button, out double step, out double page);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_spin_button_set_range")]
    internal static extern void gtk_spin_button_set_range(this GtkSpinButtonHandle spin_button, double min, double max);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_spin_button_get_range")]
    internal static extern void gtk_spin_button_get_range(this GtkSpinButtonHandle spin_button, out double min, out double max);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_spin_button_get_value")]
    internal static extern double gtk_spin_button_get_value(this GtkSpinButtonHandle spin_button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_spin_button_get_value_as_int")]
    internal static extern int gtk_spin_button_get_value_as_int(this GtkSpinButtonHandle spin_button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_spin_button_set_value")]
    internal static extern void gtk_spin_button_set_value(this GtkSpinButtonHandle spin_button, double value);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_spin_button_set_update_policy")]
    internal static extern void gtk_spin_button_set_update_policy(this GtkSpinButtonHandle spin_button, GtkSpinButtonUpdatePolicy policy);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_spin_button_get_update_policy")]
    internal static extern GtkSpinButtonUpdatePolicy gtk_spin_button_get_update_policy(this GtkSpinButtonHandle spin_button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_spin_button_set_numeric")]
    internal static extern void gtk_spin_button_set_numeric(this GtkSpinButtonHandle spin_button, int numeric);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_spin_button_get_numeric")]
    internal static extern int gtk_spin_button_get_numeric(this GtkSpinButtonHandle spin_button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_spin_button_spin")]
    internal static extern void gtk_spin_button_spin(this GtkSpinButtonHandle spin_button, GtkSpinType direction, double increment);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_spin_button_set_wrap")]
    internal static extern void gtk_spin_button_set_wrap(this GtkSpinButtonHandle spin_button, int wrap);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_spin_button_get_wrap")]
    internal static extern int gtk_spin_button_get_wrap(this GtkSpinButtonHandle spin_button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_spin_button_set_snap_to_ticks")]
    internal static extern void gtk_spin_button_set_snap_to_ticks(this GtkSpinButtonHandle spin_button, int snap_to_ticks);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_spin_button_get_snap_to_ticks")]
    internal static extern int gtk_spin_button_get_snap_to_ticks(this GtkSpinButtonHandle spin_button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_spin_button_set_climb_rate")]
    internal static extern void gtk_spin_button_set_climb_rate(this GtkSpinButtonHandle spin_button, double climb_rate);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_spin_button_get_climb_rate")]
    internal static extern double gtk_spin_button_get_climb_rate(this GtkSpinButtonHandle spin_button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_spin_button_update")]
    internal static extern void gtk_spin_button_update(this GtkSpinButtonHandle spin_button);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkSpinButtonHandle gtk_spin_button_new_with_range(double min, double max, double step);
}
