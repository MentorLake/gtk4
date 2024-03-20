using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTextTagTableExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_tag_table_add")]
    internal static extern int gtk_text_tag_table_add(this GtkTextTagTableHandle table, GtkTextTagHandle tag);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_tag_table_remove")]
    internal static extern void gtk_text_tag_table_remove(this GtkTextTagTableHandle table, GtkTextTagHandle tag);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_tag_table_lookup")]
    internal static extern GtkTextTagHandle gtk_text_tag_table_lookup(this GtkTextTagTableHandle table, string name);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_tag_table_foreach")]
    internal static extern void gtk_text_tag_table_foreach(this GtkTextTagTableHandle table, GtkTextTagTableForeach func, IntPtr data);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_tag_table_get_size")]
    internal static extern int gtk_text_tag_table_get_size(this GtkTextTagTableHandle table);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_buffer_new")]
    internal static extern GtkTextBufferHandle gtk_text_buffer_new(this GtkTextTagTableHandle table);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkTextTagTableHandle gtk_text_tag_table_new();
}
