using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;
public static class GtkColorButtonExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_color_button_set_title")]
    internal static extern void gtk_color_button_set_title(this GtkColorButtonHandle button, string title);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_color_button_get_title")]
    internal static extern string gtk_color_button_get_title(this GtkColorButtonHandle button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_color_button_get_modal")]
    internal static extern int gtk_color_button_get_modal(this GtkColorButtonHandle button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_color_button_set_modal")]
    internal static extern void gtk_color_button_set_modal(this GtkColorButtonHandle button, int modal);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkColorButtonHandle gtk_color_button_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkColorButtonHandle gtk_color_button_new_with_rgba(GdkRGBAHandle rgba);
}
