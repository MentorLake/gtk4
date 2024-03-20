using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkRecentManagerExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_recent_manager_add_item")]
    internal static extern int gtk_recent_manager_add_item(this GtkRecentManagerHandle manager, string uri);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_recent_manager_add_full")]
    internal static extern int gtk_recent_manager_add_full(this GtkRecentManagerHandle manager, string uri, GtkRecentDataHandle recent_data);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_recent_manager_remove_item")]
    internal static extern int gtk_recent_manager_remove_item(this GtkRecentManagerHandle manager, string uri, out GErrorHandle error);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_recent_manager_lookup_item")]
    internal static extern GtkRecentInfoHandle gtk_recent_manager_lookup_item(this GtkRecentManagerHandle manager, string uri, out GErrorHandle error);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_recent_manager_has_item")]
    internal static extern int gtk_recent_manager_has_item(this GtkRecentManagerHandle manager, string uri);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_recent_manager_move_item")]
    internal static extern int gtk_recent_manager_move_item(this GtkRecentManagerHandle manager, string uri, string new_uri, out GErrorHandle error);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_recent_manager_get_items")]
    internal static extern GListHandle gtk_recent_manager_get_items(this GtkRecentManagerHandle manager);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_recent_manager_purge_items")]
    internal static extern int gtk_recent_manager_purge_items(this GtkRecentManagerHandle manager, out GErrorHandle error);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkRecentManagerHandle gtk_recent_manager_new();
}
