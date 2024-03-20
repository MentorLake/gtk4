using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkFontButtonExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_font_button_get_title")]
    internal static extern string gtk_font_button_get_title(this GtkFontButtonHandle font_button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_font_button_set_title")]
    internal static extern void gtk_font_button_set_title(this GtkFontButtonHandle font_button, string title);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_font_button_get_modal")]
    internal static extern int gtk_font_button_get_modal(this GtkFontButtonHandle font_button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_font_button_set_modal")]
    internal static extern void gtk_font_button_set_modal(this GtkFontButtonHandle font_button, int modal);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_font_button_get_use_font")]
    internal static extern int gtk_font_button_get_use_font(this GtkFontButtonHandle font_button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_font_button_set_use_font")]
    internal static extern void gtk_font_button_set_use_font(this GtkFontButtonHandle font_button, int use_font);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_font_button_get_use_size")]
    internal static extern int gtk_font_button_get_use_size(this GtkFontButtonHandle font_button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_font_button_set_use_size")]
    internal static extern void gtk_font_button_set_use_size(this GtkFontButtonHandle font_button, int use_size);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkFontButtonHandle gtk_font_button_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkFontButtonHandle gtk_font_button_new_with_font(string fontname);
}
