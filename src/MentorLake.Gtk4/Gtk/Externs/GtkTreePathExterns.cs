using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTreePathExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_path_to_string")]
    internal static extern string gtk_tree_path_to_string(this GtkTreePathHandle path);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_path_append_index")]
    internal static extern void gtk_tree_path_append_index(this GtkTreePathHandle path, int index_);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_path_prepend_index")]
    internal static extern void gtk_tree_path_prepend_index(this GtkTreePathHandle path, int index_);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_path_get_depth")]
    internal static extern int gtk_tree_path_get_depth(this GtkTreePathHandle path);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_path_get_indices")]
    internal static extern int[] gtk_tree_path_get_indices(this GtkTreePathHandle path);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_path_get_indices_with_depth")]
    internal static extern int[] gtk_tree_path_get_indices_with_depth(this GtkTreePathHandle path, out int depth);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_path_free")]
    internal static extern void gtk_tree_path_free(this GtkTreePathHandle path);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_path_copy")]
    internal static extern GtkTreePathHandle gtk_tree_path_copy(this GtkTreePathHandle path);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_path_compare")]
    internal static extern int gtk_tree_path_compare(this GtkTreePathHandle a, GtkTreePathHandle b);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_path_next")]
    internal static extern void gtk_tree_path_next(this GtkTreePathHandle path);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_path_prev")]
    internal static extern int gtk_tree_path_prev(this GtkTreePathHandle path);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_path_up")]
    internal static extern int gtk_tree_path_up(this GtkTreePathHandle path);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_path_down")]
    internal static extern void gtk_tree_path_down(this GtkTreePathHandle path);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_path_is_ancestor")]
    internal static extern int gtk_tree_path_is_ancestor(this GtkTreePathHandle path, GtkTreePathHandle descendant);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_path_is_descendant")]
    internal static extern int gtk_tree_path_is_descendant(this GtkTreePathHandle path, GtkTreePathHandle ancestor);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkTreePathHandle gtk_tree_path_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkTreePathHandle gtk_tree_path_new_from_string(string path);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkTreePathHandle gtk_tree_path_new_from_indices(int first_index, IntPtr @__arglist);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkTreePathHandle gtk_tree_path_new_from_indicesv(int[] indices, nuint length);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkTreePathHandle gtk_tree_path_new_first();
}
