using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkStackSwitcherExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_switcher_set_stack")]
    internal static extern void gtk_stack_switcher_set_stack(this GtkStackSwitcherHandle switcher, GtkStackHandle stack);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_stack_switcher_get_stack")]
    internal static extern GtkStackHandle gtk_stack_switcher_get_stack(this GtkStackSwitcherHandle switcher);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkStackSwitcherHandle gtk_stack_switcher_new();
}
