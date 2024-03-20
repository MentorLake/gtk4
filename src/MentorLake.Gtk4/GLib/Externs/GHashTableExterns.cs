using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GHashTableExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_hash_table_new_similar")]
    internal static extern GHashTableHandle g_hash_table_new_similar(this GHashTableHandle other_hash_table);
    [DllImport(Libraries.GLib, EntryPoint = "g_hash_table_destroy")]
    internal static extern void g_hash_table_destroy(this GHashTableHandle hash_table);
    [DllImport(Libraries.GLib, EntryPoint = "g_hash_table_insert")]
    internal static extern int g_hash_table_insert(this GHashTableHandle hash_table, IntPtr key, IntPtr value);
    [DllImport(Libraries.GLib, EntryPoint = "g_hash_table_replace")]
    internal static extern int g_hash_table_replace(this GHashTableHandle hash_table, IntPtr key, IntPtr value);
    [DllImport(Libraries.GLib, EntryPoint = "g_hash_table_add")]
    internal static extern int g_hash_table_add(this GHashTableHandle hash_table, IntPtr key);
    [DllImport(Libraries.GLib, EntryPoint = "g_hash_table_remove")]
    internal static extern int g_hash_table_remove(this GHashTableHandle hash_table, IntPtr key);
    [DllImport(Libraries.GLib, EntryPoint = "g_hash_table_remove_all")]
    internal static extern void g_hash_table_remove_all(this GHashTableHandle hash_table);
    [DllImport(Libraries.GLib, EntryPoint = "g_hash_table_steal")]
    internal static extern int g_hash_table_steal(this GHashTableHandle hash_table, IntPtr key);
    [DllImport(Libraries.GLib, EntryPoint = "g_hash_table_steal_extended")]
    internal static extern int g_hash_table_steal_extended(this GHashTableHandle hash_table, IntPtr lookup_key, out IntPtr stolen_key, out IntPtr stolen_value);
    [DllImport(Libraries.GLib, EntryPoint = "g_hash_table_steal_all")]
    internal static extern void g_hash_table_steal_all(this GHashTableHandle hash_table);
    [DllImport(Libraries.GLib, EntryPoint = "g_hash_table_lookup")]
    internal static extern IntPtr g_hash_table_lookup(this GHashTableHandle hash_table, IntPtr key);
    [DllImport(Libraries.GLib, EntryPoint = "g_hash_table_contains")]
    internal static extern int g_hash_table_contains(this GHashTableHandle hash_table, IntPtr key);
    [DllImport(Libraries.GLib, EntryPoint = "g_hash_table_lookup_extended")]
    internal static extern int g_hash_table_lookup_extended(this GHashTableHandle hash_table, IntPtr lookup_key, out IntPtr orig_key, out IntPtr value);
    [DllImport(Libraries.GLib, EntryPoint = "g_hash_table_foreach")]
    internal static extern void g_hash_table_foreach(this GHashTableHandle hash_table, GHFunc func, IntPtr user_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_hash_table_find")]
    internal static extern IntPtr g_hash_table_find(this GHashTableHandle hash_table, GHRFunc predicate, IntPtr user_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_hash_table_foreach_remove")]
    internal static extern uint g_hash_table_foreach_remove(this GHashTableHandle hash_table, GHRFunc func, IntPtr user_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_hash_table_foreach_steal")]
    internal static extern uint g_hash_table_foreach_steal(this GHashTableHandle hash_table, GHRFunc func, IntPtr user_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_hash_table_size")]
    internal static extern uint g_hash_table_size(this GHashTableHandle hash_table);
    [DllImport(Libraries.GLib, EntryPoint = "g_hash_table_get_keys")]
    internal static extern GListHandle g_hash_table_get_keys(this GHashTableHandle hash_table);
    [DllImport(Libraries.GLib, EntryPoint = "g_hash_table_get_values")]
    internal static extern GListHandle g_hash_table_get_values(this GHashTableHandle hash_table);
    [DllImport(Libraries.GLib, EntryPoint = "g_hash_table_get_keys_as_array")]
    internal static extern IntPtr[] g_hash_table_get_keys_as_array(this GHashTableHandle hash_table, out uint length);
    [DllImport(Libraries.GLib, EntryPoint = "g_hash_table_ref")]
    internal static extern GHashTableHandle g_hash_table_ref(this GHashTableHandle hash_table);
    [DllImport(Libraries.GLib, EntryPoint = "g_hash_table_unref")]
    internal static extern void g_hash_table_unref(this GHashTableHandle hash_table);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GHashTableHandle g_hash_table_new(GHashFunc hash_func, GEqualFunc key_equal_func);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GHashTableHandle g_hash_table_new_full(GHashFunc hash_func, GEqualFunc key_equal_func, GDestroyNotify key_destroy_func, GDestroyNotify value_destroy_func);
}
