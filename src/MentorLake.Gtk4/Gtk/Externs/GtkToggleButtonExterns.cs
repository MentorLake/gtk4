using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkToggleButtonExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_toggle_button_set_active")]
    internal static extern void gtk_toggle_button_set_active(this GtkToggleButtonHandle toggle_button, int is_active);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_toggle_button_get_active")]
    internal static extern int gtk_toggle_button_get_active(this GtkToggleButtonHandle toggle_button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_toggle_button_toggled")]
    internal static extern void gtk_toggle_button_toggled(this GtkToggleButtonHandle toggle_button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_toggle_button_set_group")]
    internal static extern void gtk_toggle_button_set_group(this GtkToggleButtonHandle toggle_button, GtkToggleButtonHandle group);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkToggleButtonHandle gtk_toggle_button_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkToggleButtonHandle gtk_toggle_button_new_with_label(string label);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkToggleButtonHandle gtk_toggle_button_new_with_mnemonic(string label);
}
