using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkCheckButtonExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_check_button_set_inconsistent")]
    internal static extern void gtk_check_button_set_inconsistent(this GtkCheckButtonHandle check_button, int inconsistent);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_check_button_get_inconsistent")]
    internal static extern int gtk_check_button_get_inconsistent(this GtkCheckButtonHandle check_button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_check_button_get_active")]
    internal static extern int gtk_check_button_get_active(this GtkCheckButtonHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_check_button_set_active")]
    internal static extern void gtk_check_button_set_active(this GtkCheckButtonHandle self, int setting);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_check_button_get_label")]
    internal static extern string gtk_check_button_get_label(this GtkCheckButtonHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_check_button_set_label")]
    internal static extern void gtk_check_button_set_label(this GtkCheckButtonHandle self, string label);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_check_button_set_group")]
    internal static extern void gtk_check_button_set_group(this GtkCheckButtonHandle self, GtkCheckButtonHandle group);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_check_button_get_use_underline")]
    internal static extern int gtk_check_button_get_use_underline(this GtkCheckButtonHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_check_button_set_use_underline")]
    internal static extern void gtk_check_button_set_use_underline(this GtkCheckButtonHandle self, int setting);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkCheckButtonHandle gtk_check_button_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkCheckButtonHandle gtk_check_button_new_with_label(string label);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkCheckButtonHandle gtk_check_button_new_with_mnemonic(string label);
}
