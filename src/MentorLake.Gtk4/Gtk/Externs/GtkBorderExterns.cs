using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkBorderExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_border_copy")]
    internal static extern GtkBorderHandle gtk_border_copy(this GtkBorderHandle border_);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_border_free")]
    internal static extern void gtk_border_free(this GtkBorderHandle border_);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkBorderHandle gtk_border_new();
}
