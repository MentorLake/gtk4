using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkSingleSelectionExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_single_selection_get_model")]
    internal static extern GListModelHandle gtk_single_selection_get_model(this GtkSingleSelectionHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_single_selection_set_model")]
    internal static extern void gtk_single_selection_set_model(this GtkSingleSelectionHandle self, GListModelHandle model);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_single_selection_get_selected")]
    internal static extern uint gtk_single_selection_get_selected(this GtkSingleSelectionHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_single_selection_set_selected")]
    internal static extern void gtk_single_selection_set_selected(this GtkSingleSelectionHandle self, uint position);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_single_selection_get_selected_item")]
    internal static extern IntPtr gtk_single_selection_get_selected_item(this GtkSingleSelectionHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_single_selection_get_autoselect")]
    internal static extern int gtk_single_selection_get_autoselect(this GtkSingleSelectionHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_single_selection_set_autoselect")]
    internal static extern void gtk_single_selection_set_autoselect(this GtkSingleSelectionHandle self, int autoselect);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_single_selection_get_can_unselect")]
    internal static extern int gtk_single_selection_get_can_unselect(this GtkSingleSelectionHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_single_selection_set_can_unselect")]
    internal static extern void gtk_single_selection_set_can_unselect(this GtkSingleSelectionHandle self, int can_unselect);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkSingleSelectionHandle gtk_single_selection_new(GListModelHandle model);
}
