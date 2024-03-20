using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTextTagExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_tag_get_priority")]
    internal static extern int gtk_text_tag_get_priority(this GtkTextTagHandle tag);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_tag_set_priority")]
    internal static extern void gtk_text_tag_set_priority(this GtkTextTagHandle tag, int priority);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_tag_changed")]
    internal static extern void gtk_text_tag_changed(this GtkTextTagHandle tag, int size_changed);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkTextTagHandle gtk_text_tag_new(string name);
}
