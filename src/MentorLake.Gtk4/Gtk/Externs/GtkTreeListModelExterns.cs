using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTreeListModelExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_list_model_get_model")]
    internal static extern GListModelHandle gtk_tree_list_model_get_model(this GtkTreeListModelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_list_model_get_passthrough")]
    internal static extern int gtk_tree_list_model_get_passthrough(this GtkTreeListModelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_list_model_set_autoexpand")]
    internal static extern void gtk_tree_list_model_set_autoexpand(this GtkTreeListModelHandle self, int autoexpand);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_list_model_get_autoexpand")]
    internal static extern int gtk_tree_list_model_get_autoexpand(this GtkTreeListModelHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_list_model_get_child_row")]
    internal static extern GtkTreeListRowHandle gtk_tree_list_model_get_child_row(this GtkTreeListModelHandle self, uint position);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_list_model_get_row")]
    internal static extern GtkTreeListRowHandle gtk_tree_list_model_get_row(this GtkTreeListModelHandle self, uint position);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkTreeListModelHandle gtk_tree_list_model_new(GListModelHandle root, int passthrough, int autoexpand, GtkTreeListModelCreateModelFunc create_func, IntPtr user_data, GDestroyNotify user_destroy);
}
