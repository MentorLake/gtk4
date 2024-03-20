using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkSearchBarExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_search_bar_connect_entry")]
    internal static extern void gtk_search_bar_connect_entry(this GtkSearchBarHandle bar, GtkEditableHandle entry);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_search_bar_get_search_mode")]
    internal static extern int gtk_search_bar_get_search_mode(this GtkSearchBarHandle bar);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_search_bar_set_search_mode")]
    internal static extern void gtk_search_bar_set_search_mode(this GtkSearchBarHandle bar, int search_mode);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_search_bar_get_show_close_button")]
    internal static extern int gtk_search_bar_get_show_close_button(this GtkSearchBarHandle bar);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_search_bar_set_show_close_button")]
    internal static extern void gtk_search_bar_set_show_close_button(this GtkSearchBarHandle bar, int visible);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_search_bar_set_key_capture_widget")]
    internal static extern void gtk_search_bar_set_key_capture_widget(this GtkSearchBarHandle bar, GtkWidgetHandle widget);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_search_bar_get_key_capture_widget")]
    internal static extern GtkWidgetHandle gtk_search_bar_get_key_capture_widget(this GtkSearchBarHandle bar);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_search_bar_set_child")]
    internal static extern void gtk_search_bar_set_child(this GtkSearchBarHandle bar, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_search_bar_get_child")]
    internal static extern GtkWidgetHandle gtk_search_bar_get_child(this GtkSearchBarHandle bar);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkSearchBarHandle gtk_search_bar_new();
}
