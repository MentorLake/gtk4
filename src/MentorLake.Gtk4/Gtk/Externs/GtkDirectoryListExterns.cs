using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkDirectoryListExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_directory_list_set_file")]
    internal static extern void gtk_directory_list_set_file(this GtkDirectoryListHandle self, GFileHandle file);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_directory_list_get_file")]
    internal static extern GFileHandle gtk_directory_list_get_file(this GtkDirectoryListHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_directory_list_set_attributes")]
    internal static extern void gtk_directory_list_set_attributes(this GtkDirectoryListHandle self, string attributes);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_directory_list_get_attributes")]
    internal static extern string gtk_directory_list_get_attributes(this GtkDirectoryListHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_directory_list_set_io_priority")]
    internal static extern void gtk_directory_list_set_io_priority(this GtkDirectoryListHandle self, int io_priority);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_directory_list_get_io_priority")]
    internal static extern int gtk_directory_list_get_io_priority(this GtkDirectoryListHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_directory_list_is_loading")]
    internal static extern int gtk_directory_list_is_loading(this GtkDirectoryListHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_directory_list_get_error")]
    internal static extern GErrorHandle gtk_directory_list_get_error(this GtkDirectoryListHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_directory_list_set_monitored")]
    internal static extern void gtk_directory_list_set_monitored(this GtkDirectoryListHandle self, int monitored);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_directory_list_get_monitored")]
    internal static extern int gtk_directory_list_get_monitored(this GtkDirectoryListHandle self);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkDirectoryListHandle gtk_directory_list_new(string attributes, GFileHandle file);
}
