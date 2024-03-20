using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkButtonExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_button_set_has_frame")]
    internal static extern void gtk_button_set_has_frame(this GtkButtonHandle button, int has_frame);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_button_get_has_frame")]
    internal static extern int gtk_button_get_has_frame(this GtkButtonHandle button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_button_set_label")]
    internal static extern void gtk_button_set_label(this GtkButtonHandle button, string label);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_button_get_label")]
    internal static extern string gtk_button_get_label(this GtkButtonHandle button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_button_set_use_underline")]
    internal static extern void gtk_button_set_use_underline(this GtkButtonHandle button, int use_underline);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_button_get_use_underline")]
    internal static extern int gtk_button_get_use_underline(this GtkButtonHandle button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_button_set_icon_name")]
    internal static extern void gtk_button_set_icon_name(this GtkButtonHandle button, string icon_name);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_button_get_icon_name")]
    internal static extern string gtk_button_get_icon_name(this GtkButtonHandle button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_button_set_child")]
    internal static extern void gtk_button_set_child(this GtkButtonHandle button, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_button_get_child")]
    internal static extern GtkWidgetHandle gtk_button_get_child(this GtkButtonHandle button);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkButtonHandle gtk_button_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkButtonHandle gtk_button_new_with_label(string label);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkButtonHandle gtk_button_new_from_icon_name(string icon_name);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkButtonHandle gtk_button_new_with_mnemonic(string label);
}
