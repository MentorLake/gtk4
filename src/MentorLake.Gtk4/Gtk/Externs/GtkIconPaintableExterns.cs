using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkIconPaintableExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_paintable_get_file")]
    internal static extern GFileHandle gtk_icon_paintable_get_file(this GtkIconPaintableHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_paintable_get_icon_name")]
    internal static extern string gtk_icon_paintable_get_icon_name(this GtkIconPaintableHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_paintable_is_symbolic")]
    internal static extern int gtk_icon_paintable_is_symbolic(this GtkIconPaintableHandle self);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkIconPaintableHandle gtk_icon_paintable_new_for_file(GFileHandle file, int size, int scale);
}
