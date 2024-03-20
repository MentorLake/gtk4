using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkEditableLabelExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_editable_label_get_editing")]
    internal static extern int gtk_editable_label_get_editing(this GtkEditableLabelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_editable_label_start_editing")]
    internal static extern void gtk_editable_label_start_editing(this GtkEditableLabelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_editable_label_stop_editing")]
    internal static extern void gtk_editable_label_stop_editing(this GtkEditableLabelHandle self, int commit);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkEditableLabelHandle gtk_editable_label_new(string str);
}
