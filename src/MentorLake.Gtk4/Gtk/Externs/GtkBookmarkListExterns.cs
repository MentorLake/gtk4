using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkBookmarkListExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_bookmark_list_get_filename")]
    internal static extern string gtk_bookmark_list_get_filename(this GtkBookmarkListHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_bookmark_list_set_attributes")]
    internal static extern void gtk_bookmark_list_set_attributes(this GtkBookmarkListHandle self, string attributes);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_bookmark_list_get_attributes")]
    internal static extern string gtk_bookmark_list_get_attributes(this GtkBookmarkListHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_bookmark_list_set_io_priority")]
    internal static extern void gtk_bookmark_list_set_io_priority(this GtkBookmarkListHandle self, int io_priority);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_bookmark_list_get_io_priority")]
    internal static extern int gtk_bookmark_list_get_io_priority(this GtkBookmarkListHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_bookmark_list_is_loading")]
    internal static extern int gtk_bookmark_list_is_loading(this GtkBookmarkListHandle self);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkBookmarkListHandle gtk_bookmark_list_new(string filename, string attributes);
}
