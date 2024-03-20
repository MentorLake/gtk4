using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkStringObjectExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_string_object_get_string")]
    internal static extern string gtk_string_object_get_string(this GtkStringObjectHandle self);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkStringObjectHandle gtk_string_object_new(string @string);
}
