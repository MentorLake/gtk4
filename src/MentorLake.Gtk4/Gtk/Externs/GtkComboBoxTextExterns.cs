using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkComboBoxTextExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_combo_box_text_append_text")]
    internal static extern void gtk_combo_box_text_append_text(this GtkComboBoxTextHandle combo_box, string text);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_combo_box_text_insert_text")]
    internal static extern void gtk_combo_box_text_insert_text(this GtkComboBoxTextHandle combo_box, int position, string text);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_combo_box_text_prepend_text")]
    internal static extern void gtk_combo_box_text_prepend_text(this GtkComboBoxTextHandle combo_box, string text);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_combo_box_text_remove")]
    internal static extern void gtk_combo_box_text_remove(this GtkComboBoxTextHandle combo_box, int position);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_combo_box_text_remove_all")]
    internal static extern void gtk_combo_box_text_remove_all(this GtkComboBoxTextHandle combo_box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_combo_box_text_get_active_text")]
    internal static extern string gtk_combo_box_text_get_active_text(this GtkComboBoxTextHandle combo_box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_combo_box_text_insert")]
    internal static extern void gtk_combo_box_text_insert(this GtkComboBoxTextHandle combo_box, int position, string id, string text);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_combo_box_text_append")]
    internal static extern void gtk_combo_box_text_append(this GtkComboBoxTextHandle combo_box, string id, string text);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_combo_box_text_prepend")]
    internal static extern void gtk_combo_box_text_prepend(this GtkComboBoxTextHandle combo_box, string id, string text);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkComboBoxTextHandle gtk_combo_box_text_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkComboBoxTextHandle gtk_combo_box_text_new_with_entry();
}
