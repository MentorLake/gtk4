using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkFileChooserNativeExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_file_chooser_native_get_accept_label")]
    internal static extern string gtk_file_chooser_native_get_accept_label(this GtkFileChooserNativeHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_file_chooser_native_set_accept_label")]
    internal static extern void gtk_file_chooser_native_set_accept_label(this GtkFileChooserNativeHandle self, string accept_label);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_file_chooser_native_get_cancel_label")]
    internal static extern string gtk_file_chooser_native_get_cancel_label(this GtkFileChooserNativeHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_file_chooser_native_set_cancel_label")]
    internal static extern void gtk_file_chooser_native_set_cancel_label(this GtkFileChooserNativeHandle self, string cancel_label);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkFileChooserNativeHandle gtk_file_chooser_native_new(string title, GtkWindowHandle parent, GtkFileChooserAction action, string accept_label, string cancel_label);
}
