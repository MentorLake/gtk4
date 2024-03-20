using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkBitsetExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_bitset_ref")]
    internal static extern GtkBitsetHandle gtk_bitset_ref(this GtkBitsetHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_bitset_unref")]
    internal static extern void gtk_bitset_unref(this GtkBitsetHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_bitset_contains")]
    internal static extern int gtk_bitset_contains(this GtkBitsetHandle self, uint value);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_bitset_is_empty")]
    internal static extern int gtk_bitset_is_empty(this GtkBitsetHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_bitset_equals")]
    internal static extern int gtk_bitset_equals(this GtkBitsetHandle self, GtkBitsetHandle other);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_bitset_get_size")]
    internal static extern nuint gtk_bitset_get_size(this GtkBitsetHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_bitset_get_size_in_range")]
    internal static extern nuint gtk_bitset_get_size_in_range(this GtkBitsetHandle self, uint first, uint last);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_bitset_get_nth")]
    internal static extern uint gtk_bitset_get_nth(this GtkBitsetHandle self, uint nth);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_bitset_get_minimum")]
    internal static extern uint gtk_bitset_get_minimum(this GtkBitsetHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_bitset_get_maximum")]
    internal static extern uint gtk_bitset_get_maximum(this GtkBitsetHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_bitset_copy")]
    internal static extern GtkBitsetHandle gtk_bitset_copy(this GtkBitsetHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_bitset_remove_all")]
    internal static extern void gtk_bitset_remove_all(this GtkBitsetHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_bitset_add")]
    internal static extern int gtk_bitset_add(this GtkBitsetHandle self, uint value);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_bitset_remove")]
    internal static extern int gtk_bitset_remove(this GtkBitsetHandle self, uint value);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_bitset_add_range")]
    internal static extern void gtk_bitset_add_range(this GtkBitsetHandle self, uint start, uint n_items);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_bitset_remove_range")]
    internal static extern void gtk_bitset_remove_range(this GtkBitsetHandle self, uint start, uint n_items);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_bitset_add_range_closed")]
    internal static extern void gtk_bitset_add_range_closed(this GtkBitsetHandle self, uint first, uint last);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_bitset_remove_range_closed")]
    internal static extern void gtk_bitset_remove_range_closed(this GtkBitsetHandle self, uint first, uint last);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_bitset_add_rectangle")]
    internal static extern void gtk_bitset_add_rectangle(this GtkBitsetHandle self, uint start, uint width, uint height, uint stride);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_bitset_remove_rectangle")]
    internal static extern void gtk_bitset_remove_rectangle(this GtkBitsetHandle self, uint start, uint width, uint height, uint stride);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_bitset_union")]
    internal static extern void gtk_bitset_union(this GtkBitsetHandle self, GtkBitsetHandle other);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_bitset_intersect")]
    internal static extern void gtk_bitset_intersect(this GtkBitsetHandle self, GtkBitsetHandle other);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_bitset_subtract")]
    internal static extern void gtk_bitset_subtract(this GtkBitsetHandle self, GtkBitsetHandle other);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_bitset_difference")]
    internal static extern void gtk_bitset_difference(this GtkBitsetHandle self, GtkBitsetHandle other);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_bitset_shift_left")]
    internal static extern void gtk_bitset_shift_left(this GtkBitsetHandle self, uint amount);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_bitset_shift_right")]
    internal static extern void gtk_bitset_shift_right(this GtkBitsetHandle self, uint amount);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_bitset_splice")]
    internal static extern void gtk_bitset_splice(this GtkBitsetHandle self, uint position, uint removed, uint added);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkBitsetHandle gtk_bitset_new_empty();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkBitsetHandle gtk_bitset_new_range(uint start, uint n_items);
}
