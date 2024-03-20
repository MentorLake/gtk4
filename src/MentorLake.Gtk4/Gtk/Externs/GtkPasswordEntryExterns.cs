using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkPasswordEntryExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_password_entry_set_show_peek_icon")]
    internal static extern void gtk_password_entry_set_show_peek_icon(this GtkPasswordEntryHandle entry, int show_peek_icon);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_password_entry_get_show_peek_icon")]
    internal static extern int gtk_password_entry_get_show_peek_icon(this GtkPasswordEntryHandle entry);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_password_entry_set_extra_menu")]
    internal static extern void gtk_password_entry_set_extra_menu(this GtkPasswordEntryHandle entry, GMenuModelHandle model);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_password_entry_get_extra_menu")]
    internal static extern GMenuModelHandle gtk_password_entry_get_extra_menu(this GtkPasswordEntryHandle entry);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkPasswordEntryHandle gtk_password_entry_new();
}
