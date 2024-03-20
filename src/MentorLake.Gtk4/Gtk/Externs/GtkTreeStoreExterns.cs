using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTreeStoreExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_store_set_column_types")]
    internal static extern void gtk_tree_store_set_column_types(this GtkTreeStoreHandle tree_store, int n_columns, GTypeHandle types);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_store_set_value")]
    internal static extern void gtk_tree_store_set_value(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, int column, GValueHandle value);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_store_set")]
    internal static extern void gtk_tree_store_set(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, IntPtr @__argList);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_store_set_valuesv")]
    internal static extern void gtk_tree_store_set_valuesv(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, int[] columns, GValueHandle values, int n_values);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_store_set_valist")]
    internal static extern void gtk_tree_store_set_valist(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, IntPtr @__argList);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_store_remove")]
    internal static extern int gtk_tree_store_remove(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_store_insert")]
    internal static extern void gtk_tree_store_insert(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, GtkTreeIterHandle parent, int position);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_store_insert_before")]
    internal static extern void gtk_tree_store_insert_before(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, GtkTreeIterHandle parent, GtkTreeIterHandle sibling);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_store_insert_after")]
    internal static extern void gtk_tree_store_insert_after(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, GtkTreeIterHandle parent, GtkTreeIterHandle sibling);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_store_insert_with_values")]
    internal static extern void gtk_tree_store_insert_with_values(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, GtkTreeIterHandle parent, int position, IntPtr @__argList);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_store_insert_with_valuesv")]
    internal static extern void gtk_tree_store_insert_with_valuesv(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, GtkTreeIterHandle parent, int position, int[] columns, GValueHandle values, int n_values);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_store_prepend")]
    internal static extern void gtk_tree_store_prepend(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, GtkTreeIterHandle parent);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_store_append")]
    internal static extern void gtk_tree_store_append(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, GtkTreeIterHandle parent);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_store_is_ancestor")]
    internal static extern int gtk_tree_store_is_ancestor(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, GtkTreeIterHandle descendant);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_store_iter_depth")]
    internal static extern int gtk_tree_store_iter_depth(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_store_clear")]
    internal static extern void gtk_tree_store_clear(this GtkTreeStoreHandle tree_store);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_store_iter_is_valid")]
    internal static extern int gtk_tree_store_iter_is_valid(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_store_reorder")]
    internal static extern void gtk_tree_store_reorder(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle parent, int[] new_order);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_store_swap")]
    internal static extern void gtk_tree_store_swap(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle a, GtkTreeIterHandle b);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_store_move_before")]
    internal static extern void gtk_tree_store_move_before(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, GtkTreeIterHandle position);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_store_move_after")]
    internal static extern void gtk_tree_store_move_after(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, GtkTreeIterHandle position);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkTreeStoreHandle gtk_tree_store_new(int n_columns, IntPtr @__arglist);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkTreeStoreHandle gtk_tree_store_newv(int n_columns, GTypeHandle types);
}
