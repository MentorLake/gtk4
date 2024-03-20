using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GCacheExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_cache_destroy")]
    [Obsolete]
    internal static extern void g_cache_destroy(this GCacheHandle cache);
    [DllImport(Libraries.GLib, EntryPoint = "g_cache_insert")]
    internal static extern IntPtr g_cache_insert(this GCacheHandle cache, IntPtr key);
    [DllImport(Libraries.GLib, EntryPoint = "g_cache_remove")]
    [Obsolete]
    internal static extern void g_cache_remove(this GCacheHandle cache, IntPtr value);
    [DllImport(Libraries.GLib, EntryPoint = "g_cache_key_foreach")]
    [Obsolete]
    internal static extern void g_cache_key_foreach(this GCacheHandle cache, GHFunc func, IntPtr user_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_cache_value_foreach")]
    [Obsolete]
    internal static extern void g_cache_value_foreach(this GCacheHandle cache, GHFunc func, IntPtr user_data);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GCacheHandle g_cache_new(GCacheNewFunc value_new_func, GCacheDestroyFunc value_destroy_func, GCacheDupFunc key_dup_func, GCacheDestroyFunc key_destroy_func, GHashFunc hash_key_func, GHashFunc hash_value_func, GEqualFunc key_equal_func);
}
