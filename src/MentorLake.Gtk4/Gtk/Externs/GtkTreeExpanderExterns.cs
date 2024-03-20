using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTreeExpanderExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_expander_get_child")]
    internal static extern GtkWidgetHandle gtk_tree_expander_get_child(this GtkTreeExpanderHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_expander_set_child")]
    internal static extern void gtk_tree_expander_set_child(this GtkTreeExpanderHandle self, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_expander_get_item")]
    internal static extern IntPtr gtk_tree_expander_get_item(this GtkTreeExpanderHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_expander_get_list_row")]
    internal static extern GtkTreeListRowHandle gtk_tree_expander_get_list_row(this GtkTreeExpanderHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_expander_set_list_row")]
    internal static extern void gtk_tree_expander_set_list_row(this GtkTreeExpanderHandle self, GtkTreeListRowHandle list_row);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_expander_get_indent_for_icon")]
    internal static extern int gtk_tree_expander_get_indent_for_icon(this GtkTreeExpanderHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_expander_set_indent_for_icon")]
    internal static extern void gtk_tree_expander_set_indent_for_icon(this GtkTreeExpanderHandle self, int indent_for_icon);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkTreeExpanderHandle gtk_tree_expander_new();
}
