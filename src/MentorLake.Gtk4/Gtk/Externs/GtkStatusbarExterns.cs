using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkStatusbarExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_statusbar_get_context_id")]
    internal static extern uint gtk_statusbar_get_context_id(this GtkStatusbarHandle statusbar, string context_description);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_statusbar_push")]
    internal static extern uint gtk_statusbar_push(this GtkStatusbarHandle statusbar, uint context_id, string text);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_statusbar_pop")]
    internal static extern void gtk_statusbar_pop(this GtkStatusbarHandle statusbar, uint context_id);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_statusbar_remove")]
    internal static extern void gtk_statusbar_remove(this GtkStatusbarHandle statusbar, uint context_id, uint message_id);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_statusbar_remove_all")]
    internal static extern void gtk_statusbar_remove_all(this GtkStatusbarHandle statusbar, uint context_id);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkStatusbarHandle gtk_statusbar_new();
}
