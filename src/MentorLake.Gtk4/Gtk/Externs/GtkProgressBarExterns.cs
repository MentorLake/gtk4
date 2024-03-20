using System.Runtime.InteropServices;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gtk;
public static class GtkProgressBarExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_progress_bar_pulse")]
    internal static extern void gtk_progress_bar_pulse(this GtkProgressBarHandle pbar);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_progress_bar_set_text")]
    internal static extern void gtk_progress_bar_set_text(this GtkProgressBarHandle pbar, string text);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_progress_bar_set_fraction")]
    internal static extern void gtk_progress_bar_set_fraction(this GtkProgressBarHandle pbar, double fraction);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_progress_bar_set_pulse_step")]
    internal static extern void gtk_progress_bar_set_pulse_step(this GtkProgressBarHandle pbar, double fraction);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_progress_bar_set_inverted")]
    internal static extern void gtk_progress_bar_set_inverted(this GtkProgressBarHandle pbar, int inverted);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_progress_bar_get_text")]
    internal static extern string gtk_progress_bar_get_text(this GtkProgressBarHandle pbar);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_progress_bar_get_fraction")]
    internal static extern double gtk_progress_bar_get_fraction(this GtkProgressBarHandle pbar);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_progress_bar_get_pulse_step")]
    internal static extern double gtk_progress_bar_get_pulse_step(this GtkProgressBarHandle pbar);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_progress_bar_get_inverted")]
    internal static extern int gtk_progress_bar_get_inverted(this GtkProgressBarHandle pbar);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_progress_bar_set_ellipsize")]
    internal static extern void gtk_progress_bar_set_ellipsize(this GtkProgressBarHandle pbar, PangoEllipsizeMode mode);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_progress_bar_get_ellipsize")]
    internal static extern PangoEllipsizeMode gtk_progress_bar_get_ellipsize(this GtkProgressBarHandle pbar);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_progress_bar_set_show_text")]
    internal static extern void gtk_progress_bar_set_show_text(this GtkProgressBarHandle pbar, int show_text);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_progress_bar_get_show_text")]
    internal static extern int gtk_progress_bar_get_show_text(this GtkProgressBarHandle pbar);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkProgressBarHandle gtk_progress_bar_new();
}
