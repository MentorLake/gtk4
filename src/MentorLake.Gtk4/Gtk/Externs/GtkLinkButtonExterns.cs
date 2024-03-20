using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkLinkButtonExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_link_button_get_uri")]
    internal static extern string gtk_link_button_get_uri(this GtkLinkButtonHandle link_button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_link_button_set_uri")]
    internal static extern void gtk_link_button_set_uri(this GtkLinkButtonHandle link_button, string uri);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_link_button_get_visited")]
    internal static extern int gtk_link_button_get_visited(this GtkLinkButtonHandle link_button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_link_button_set_visited")]
    internal static extern void gtk_link_button_set_visited(this GtkLinkButtonHandle link_button, int visited);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkLinkButtonHandle gtk_link_button_new(string uri);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkLinkButtonHandle gtk_link_button_new_with_label(string uri, string label);
}
