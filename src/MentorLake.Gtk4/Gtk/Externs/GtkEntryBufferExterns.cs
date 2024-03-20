using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkEntryBufferExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_buffer_get_bytes")]
    internal static extern nuint gtk_entry_buffer_get_bytes(this GtkEntryBufferHandle buffer);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_buffer_get_length")]
    internal static extern uint gtk_entry_buffer_get_length(this GtkEntryBufferHandle buffer);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_buffer_get_text")]
    internal static extern string gtk_entry_buffer_get_text(this GtkEntryBufferHandle buffer);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_buffer_set_text")]
    internal static extern void gtk_entry_buffer_set_text(this GtkEntryBufferHandle buffer, string chars, int n_chars);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_buffer_set_max_length")]
    internal static extern void gtk_entry_buffer_set_max_length(this GtkEntryBufferHandle buffer, int max_length);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_buffer_get_max_length")]
    internal static extern int gtk_entry_buffer_get_max_length(this GtkEntryBufferHandle buffer);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_buffer_insert_text")]
    internal static extern uint gtk_entry_buffer_insert_text(this GtkEntryBufferHandle buffer, uint position, string chars, int n_chars);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_buffer_delete_text")]
    internal static extern uint gtk_entry_buffer_delete_text(this GtkEntryBufferHandle buffer, uint position, int n_chars);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_buffer_emit_inserted_text")]
    internal static extern void gtk_entry_buffer_emit_inserted_text(this GtkEntryBufferHandle buffer, uint position, string chars, uint n_chars);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_buffer_emit_deleted_text")]
    internal static extern void gtk_entry_buffer_emit_deleted_text(this GtkEntryBufferHandle buffer, uint position, uint n_chars);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_new_with_buffer")]
    internal static extern GtkEntryHandle gtk_entry_new_with_buffer(this GtkEntryBufferHandle buffer);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_new_with_buffer")]
    internal static extern GtkTextHandle gtk_text_new_with_buffer(this GtkEntryBufferHandle buffer);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkEntryBufferHandle gtk_entry_buffer_new(string initial_chars, int n_initial_chars);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkEntryBufferHandle gtk_password_entry_buffer_new();
}
