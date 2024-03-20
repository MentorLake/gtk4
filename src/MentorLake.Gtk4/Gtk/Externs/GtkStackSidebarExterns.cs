using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkStackSidebarExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_sidebar_set_stack")]
    internal static extern void gtk_stack_sidebar_set_stack(this GtkStackSidebarHandle self, GtkStackHandle stack);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_sidebar_get_stack")]
    internal static extern GtkStackHandle gtk_stack_sidebar_get_stack(this GtkStackSidebarHandle self);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkStackSidebarHandle gtk_stack_sidebar_new();
}
