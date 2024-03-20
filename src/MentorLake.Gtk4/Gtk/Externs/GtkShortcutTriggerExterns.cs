using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkShortcutTriggerExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_shortcut_trigger_to_string")]
    internal static extern string gtk_shortcut_trigger_to_string(this GtkShortcutTriggerHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_shortcut_trigger_print")]
    internal static extern void gtk_shortcut_trigger_print(this GtkShortcutTriggerHandle self, GStringHandle @string);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_shortcut_trigger_to_label")]
    internal static extern string gtk_shortcut_trigger_to_label(this GtkShortcutTriggerHandle self, GdkDisplayHandle display);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_shortcut_trigger_print_label")]
    internal static extern int gtk_shortcut_trigger_print_label(this GtkShortcutTriggerHandle self, GdkDisplayHandle display, GStringHandle @string);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_shortcut_trigger_trigger")]
    internal static extern GdkKeyMatch gtk_shortcut_trigger_trigger(this GtkShortcutTriggerHandle self, GdkEventHandle @event, int enable_mnemonics);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_alternative_trigger_new")]
    internal static extern GtkShortcutTriggerHandle gtk_alternative_trigger_new(this GtkShortcutTriggerHandle first, GtkShortcutTriggerHandle second);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkShortcutTriggerHandle gtk_keyval_trigger_new(uint keyval, GdkModifierType modifiers);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkShortcutTriggerHandle gtk_mnemonic_trigger_new(uint keyval);
}
