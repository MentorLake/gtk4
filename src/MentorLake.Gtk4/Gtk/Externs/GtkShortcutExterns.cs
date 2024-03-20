using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkShortcutExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_shortcut_get_trigger")]
    internal static extern GtkShortcutTriggerHandle gtk_shortcut_get_trigger(this GtkShortcutHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_shortcut_set_trigger")]
    internal static extern void gtk_shortcut_set_trigger(this GtkShortcutHandle self, GtkShortcutTriggerHandle trigger);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_shortcut_get_action")]
    internal static extern GtkShortcutActionHandle gtk_shortcut_get_action(this GtkShortcutHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_shortcut_set_action")]
    internal static extern void gtk_shortcut_set_action(this GtkShortcutHandle self, GtkShortcutActionHandle action);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_shortcut_get_arguments")]
    internal static extern GVariantHandle gtk_shortcut_get_arguments(this GtkShortcutHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_shortcut_set_arguments")]
    internal static extern void gtk_shortcut_set_arguments(this GtkShortcutHandle self, GVariantHandle args);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkShortcutHandle gtk_shortcut_new(GtkShortcutTriggerHandle trigger, GtkShortcutActionHandle action);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkShortcutHandle gtk_shortcut_new_with_arguments(GtkShortcutTriggerHandle trigger, GtkShortcutActionHandle action, string format_string, IntPtr @__arglist);
}
