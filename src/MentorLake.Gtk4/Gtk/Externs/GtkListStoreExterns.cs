using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;
public static class GtkListStoreExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_store_set_column_types")]
    internal static extern void gtk_list_store_set_column_types(this GtkListStoreHandle list_store, int n_columns, GTypeHandle types);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_store_set_value")]
    internal static extern void gtk_list_store_set_value(this GtkListStoreHandle list_store, GtkTreeIterHandle iter, int column, GValueHandle value);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_store_set")]
    internal static extern void gtk_list_store_set(this GtkListStoreHandle list_store, GtkTreeIterHandle iter, IntPtr @__argList);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_store_set_valuesv")]
    internal static extern void gtk_list_store_set_valuesv(this GtkListStoreHandle list_store, GtkTreeIterHandle iter, int[] columns, GValueHandle values, int n_values);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_store_set_valist")]
    internal static extern void gtk_list_store_set_valist(this GtkListStoreHandle list_store, GtkTreeIterHandle iter, IntPtr @__argList);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_store_remove")]
    internal static extern int gtk_list_store_remove(this GtkListStoreHandle list_store, GtkTreeIterHandle iter);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_store_insert")]
    internal static extern void gtk_list_store_insert(this GtkListStoreHandle list_store, GtkTreeIterHandle iter, int position);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_store_insert_before")]
    internal static extern void gtk_list_store_insert_before(this GtkListStoreHandle list_store, GtkTreeIterHandle iter, GtkTreeIterHandle sibling);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_store_insert_after")]
    internal static extern void gtk_list_store_insert_after(this GtkListStoreHandle list_store, GtkTreeIterHandle iter, GtkTreeIterHandle sibling);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_store_insert_with_values")]
    internal static extern void gtk_list_store_insert_with_values(this GtkListStoreHandle list_store, GtkTreeIterHandle iter, int position, IntPtr @__argList);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_store_insert_with_valuesv")]
    internal static extern void gtk_list_store_insert_with_valuesv(this GtkListStoreHandle list_store, GtkTreeIterHandle iter, int position, int[] columns, GValueHandle values, int n_values);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_store_prepend")]
    internal static extern void gtk_list_store_prepend(this GtkListStoreHandle list_store, GtkTreeIterHandle iter);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_store_append")]
    internal static extern void gtk_list_store_append(this GtkListStoreHandle list_store, GtkTreeIterHandle iter);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_store_clear")]
    internal static extern void gtk_list_store_clear(this GtkListStoreHandle list_store);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_store_iter_is_valid")]
    internal static extern int gtk_list_store_iter_is_valid(this GtkListStoreHandle list_store, GtkTreeIterHandle iter);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_store_reorder")]
    internal static extern void gtk_list_store_reorder(this GtkListStoreHandle store, int[] new_order);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_store_swap")]
    internal static extern void gtk_list_store_swap(this GtkListStoreHandle store, GtkTreeIterHandle a, GtkTreeIterHandle b);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_store_move_after")]
    internal static extern void gtk_list_store_move_after(this GtkListStoreHandle store, GtkTreeIterHandle iter, GtkTreeIterHandle position);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_list_store_move_before")]
    internal static extern void gtk_list_store_move_before(this GtkListStoreHandle store, GtkTreeIterHandle iter, GtkTreeIterHandle position);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkListStoreHandle gtk_list_store_new(int n_columns, IntPtr @__arglist);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkListStoreHandle gtk_list_store_newv(int n_columns, GTypeHandle types);
}
