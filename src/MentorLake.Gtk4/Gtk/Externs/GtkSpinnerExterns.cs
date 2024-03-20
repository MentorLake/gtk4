using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkSpinnerExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_spinner_start")]
    internal static extern void gtk_spinner_start(this GtkSpinnerHandle spinner);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_spinner_stop")]
    internal static extern void gtk_spinner_stop(this GtkSpinnerHandle spinner);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_spinner_set_spinning")]
    internal static extern void gtk_spinner_set_spinning(this GtkSpinnerHandle spinner, int spinning);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_spinner_get_spinning")]
    internal static extern int gtk_spinner_get_spinning(this GtkSpinnerHandle spinner);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkSpinnerHandle gtk_spinner_new();
}
