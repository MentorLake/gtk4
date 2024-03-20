using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkSwitchExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_switch_set_active")]
    internal static extern void gtk_switch_set_active(this GtkSwitchHandle self, int is_active);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_switch_get_active")]
    internal static extern int gtk_switch_get_active(this GtkSwitchHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_switch_set_state")]
    internal static extern void gtk_switch_set_state(this GtkSwitchHandle self, int state);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_switch_get_state")]
    internal static extern int gtk_switch_get_state(this GtkSwitchHandle self);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkSwitchHandle gtk_switch_new();
}
