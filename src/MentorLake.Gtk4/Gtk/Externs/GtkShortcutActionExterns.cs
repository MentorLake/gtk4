using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkShortcutActionExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_shortcut_action_to_string")]
    internal static extern string gtk_shortcut_action_to_string(this GtkShortcutActionHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_shortcut_action_print")]
    internal static extern void gtk_shortcut_action_print(this GtkShortcutActionHandle self, GStringHandle @string);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_shortcut_action_activate")]
    internal static extern int gtk_shortcut_action_activate(this GtkShortcutActionHandle self, GtkShortcutActionFlags flags, GtkWidgetHandle widget, GVariantHandle args);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkShortcutActionHandle gtk_callback_action_new(GtkShortcutFunc callback, IntPtr data, GDestroyNotify destroy);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkShortcutActionHandle gtk_signal_action_new(string signal_name);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkShortcutActionHandle gtk_named_action_new(string name);
}
