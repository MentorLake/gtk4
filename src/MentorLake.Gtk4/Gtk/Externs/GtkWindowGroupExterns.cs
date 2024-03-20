using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkWindowGroupExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_group_add_window")]
    internal static extern void gtk_window_group_add_window(this GtkWindowGroupHandle window_group, GtkWindowHandle window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_group_remove_window")]
    internal static extern void gtk_window_group_remove_window(this GtkWindowGroupHandle window_group, GtkWindowHandle window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_group_list_windows")]
    internal static extern GListHandle gtk_window_group_list_windows(this GtkWindowGroupHandle window_group);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkWindowGroupHandle gtk_window_group_new();
}
