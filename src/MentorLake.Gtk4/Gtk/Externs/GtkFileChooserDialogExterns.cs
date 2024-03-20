using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;
public static class GtkFileChooserDialogExterns
{
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkFileChooserDialogHandle gtk_file_chooser_dialog_new(string title, GtkWindowHandle parent, GtkFileChooserAction action, string first_button_text, IntPtr @__arglist);
}
