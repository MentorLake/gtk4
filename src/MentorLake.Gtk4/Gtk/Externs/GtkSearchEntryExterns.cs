using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkSearchEntryExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_search_entry_set_key_capture_widget")]
    internal static extern void gtk_search_entry_set_key_capture_widget(this GtkSearchEntryHandle entry, GtkWidgetHandle widget);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_search_entry_get_key_capture_widget")]
    internal static extern GtkWidgetHandle gtk_search_entry_get_key_capture_widget(this GtkSearchEntryHandle entry);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkSearchEntryHandle gtk_search_entry_new();
}
