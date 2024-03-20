using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkWindowControlsExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_controls_get_side")]
    internal static extern GtkPackType gtk_window_controls_get_side(this GtkWindowControlsHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_controls_set_side")]
    internal static extern void gtk_window_controls_set_side(this GtkWindowControlsHandle self, GtkPackType side);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_controls_get_decoration_layout")]
    internal static extern string gtk_window_controls_get_decoration_layout(this GtkWindowControlsHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_controls_set_decoration_layout")]
    internal static extern void gtk_window_controls_set_decoration_layout(this GtkWindowControlsHandle self, string layout);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_controls_get_empty")]
    internal static extern int gtk_window_controls_get_empty(this GtkWindowControlsHandle self);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkWindowControlsHandle gtk_window_controls_new(GtkPackType side);
}
