using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkShortcutLabelExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_shortcut_label_get_accelerator")]
    internal static extern string gtk_shortcut_label_get_accelerator(this GtkShortcutLabelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_shortcut_label_set_accelerator")]
    internal static extern void gtk_shortcut_label_set_accelerator(this GtkShortcutLabelHandle self, string accelerator);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_shortcut_label_get_disabled_text")]
    internal static extern string gtk_shortcut_label_get_disabled_text(this GtkShortcutLabelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_shortcut_label_set_disabled_text")]
    internal static extern void gtk_shortcut_label_set_disabled_text(this GtkShortcutLabelHandle self, string disabled_text);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkShortcutLabelHandle gtk_shortcut_label_new(string accelerator);
}
