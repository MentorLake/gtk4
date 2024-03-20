using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkListBoxRowExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_row_set_child")]
    internal static extern void gtk_list_box_row_set_child(this GtkListBoxRowHandle row, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_row_get_child")]
    internal static extern GtkWidgetHandle gtk_list_box_row_get_child(this GtkListBoxRowHandle row);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_row_get_header")]
    internal static extern GtkWidgetHandle gtk_list_box_row_get_header(this GtkListBoxRowHandle row);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_row_set_header")]
    internal static extern void gtk_list_box_row_set_header(this GtkListBoxRowHandle row, GtkWidgetHandle header);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_row_get_index")]
    internal static extern int gtk_list_box_row_get_index(this GtkListBoxRowHandle row);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_row_changed")]
    internal static extern void gtk_list_box_row_changed(this GtkListBoxRowHandle row);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_row_is_selected")]
    internal static extern int gtk_list_box_row_is_selected(this GtkListBoxRowHandle row);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_row_set_selectable")]
    internal static extern void gtk_list_box_row_set_selectable(this GtkListBoxRowHandle row, int selectable);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_row_get_selectable")]
    internal static extern int gtk_list_box_row_get_selectable(this GtkListBoxRowHandle row);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_row_set_activatable")]
    internal static extern void gtk_list_box_row_set_activatable(this GtkListBoxRowHandle row, int activatable);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_box_row_get_activatable")]
    internal static extern int gtk_list_box_row_get_activatable(this GtkListBoxRowHandle row);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkListBoxRowHandle gtk_list_box_row_new();
}
