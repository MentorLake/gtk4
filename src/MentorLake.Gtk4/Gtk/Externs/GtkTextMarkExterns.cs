using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTextMarkExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_mark_set_visible")]
    internal static extern void gtk_text_mark_set_visible(this GtkTextMarkHandle mark, int setting);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_mark_get_visible")]
    internal static extern int gtk_text_mark_get_visible(this GtkTextMarkHandle mark);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_mark_get_name")]
    internal static extern string gtk_text_mark_get_name(this GtkTextMarkHandle mark);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_mark_get_deleted")]
    internal static extern int gtk_text_mark_get_deleted(this GtkTextMarkHandle mark);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_mark_get_buffer")]
    internal static extern GtkTextBufferHandle gtk_text_mark_get_buffer(this GtkTextMarkHandle mark);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_mark_get_left_gravity")]
    internal static extern int gtk_text_mark_get_left_gravity(this GtkTextMarkHandle mark);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkTextMarkHandle gtk_text_mark_new(string name, int left_gravity);
}
