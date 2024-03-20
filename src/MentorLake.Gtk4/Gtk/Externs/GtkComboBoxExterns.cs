using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkComboBoxExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_combo_box_get_active")]
    internal static extern int gtk_combo_box_get_active(this GtkComboBoxHandle combo_box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_combo_box_set_active")]
    internal static extern void gtk_combo_box_set_active(this GtkComboBoxHandle combo_box, int index_);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_combo_box_get_active_iter")]
    internal static extern int gtk_combo_box_get_active_iter(this GtkComboBoxHandle combo_box, GtkTreeIterHandle iter);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_combo_box_set_active_iter")]
    internal static extern void gtk_combo_box_set_active_iter(this GtkComboBoxHandle combo_box, GtkTreeIterHandle iter);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_combo_box_set_model")]
    internal static extern void gtk_combo_box_set_model(this GtkComboBoxHandle combo_box, GtkTreeModelHandle model);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_combo_box_get_model")]
    internal static extern GtkTreeModelHandle gtk_combo_box_get_model(this GtkComboBoxHandle combo_box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_combo_box_get_row_separator_func")]
    internal static extern GtkTreeViewRowSeparatorFunc gtk_combo_box_get_row_separator_func(this GtkComboBoxHandle combo_box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_combo_box_set_row_separator_func")]
    internal static extern void gtk_combo_box_set_row_separator_func(this GtkComboBoxHandle combo_box, GtkTreeViewRowSeparatorFunc func, IntPtr data, GDestroyNotify destroy);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_combo_box_set_button_sensitivity")]
    internal static extern void gtk_combo_box_set_button_sensitivity(this GtkComboBoxHandle combo_box, GtkSensitivityType sensitivity);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_combo_box_get_button_sensitivity")]
    internal static extern GtkSensitivityType gtk_combo_box_get_button_sensitivity(this GtkComboBoxHandle combo_box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_combo_box_get_has_entry")]
    internal static extern int gtk_combo_box_get_has_entry(this GtkComboBoxHandle combo_box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_combo_box_set_entry_text_column")]
    internal static extern void gtk_combo_box_set_entry_text_column(this GtkComboBoxHandle combo_box, int text_column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_combo_box_get_entry_text_column")]
    internal static extern int gtk_combo_box_get_entry_text_column(this GtkComboBoxHandle combo_box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_combo_box_set_popup_fixed_width")]
    internal static extern void gtk_combo_box_set_popup_fixed_width(this GtkComboBoxHandle combo_box, int @fixed);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_combo_box_get_popup_fixed_width")]
    internal static extern int gtk_combo_box_get_popup_fixed_width(this GtkComboBoxHandle combo_box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_combo_box_popup")]
    internal static extern void gtk_combo_box_popup(this GtkComboBoxHandle combo_box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_combo_box_popup_for_device")]
    internal static extern void gtk_combo_box_popup_for_device(this GtkComboBoxHandle combo_box, GdkDeviceHandle device);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_combo_box_popdown")]
    internal static extern void gtk_combo_box_popdown(this GtkComboBoxHandle combo_box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_combo_box_get_id_column")]
    internal static extern int gtk_combo_box_get_id_column(this GtkComboBoxHandle combo_box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_combo_box_set_id_column")]
    internal static extern void gtk_combo_box_set_id_column(this GtkComboBoxHandle combo_box, int id_column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_combo_box_get_active_id")]
    internal static extern string gtk_combo_box_get_active_id(this GtkComboBoxHandle combo_box);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_combo_box_set_active_id")]
    internal static extern int gtk_combo_box_set_active_id(this GtkComboBoxHandle combo_box, string active_id);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_combo_box_set_child")]
    internal static extern void gtk_combo_box_set_child(this GtkComboBoxHandle combo_box, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_combo_box_get_child")]
    internal static extern GtkWidgetHandle gtk_combo_box_get_child(this GtkComboBoxHandle combo_box);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkComboBoxHandle gtk_combo_box_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkComboBoxHandle gtk_combo_box_new_with_entry();
}
