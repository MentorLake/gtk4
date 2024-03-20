using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkStringListExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_string_list_append")]
    internal static extern void gtk_string_list_append(this GtkStringListHandle self, string @string);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_string_list_take")]
    internal static extern void gtk_string_list_take(this GtkStringListHandle self, string @string);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_string_list_remove")]
    internal static extern void gtk_string_list_remove(this GtkStringListHandle self, uint position);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_string_list_splice")]
    internal static extern void gtk_string_list_splice(this GtkStringListHandle self, uint position, uint n_removals, string additions);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_string_list_get_string")]
    internal static extern string gtk_string_list_get_string(this GtkStringListHandle self, uint position);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkStringListHandle gtk_string_list_new(string strings);
}
