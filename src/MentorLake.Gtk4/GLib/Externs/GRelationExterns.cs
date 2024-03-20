using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GRelationExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_relation_destroy")]
    [Obsolete]
    internal static extern void g_relation_destroy(this GRelationHandle relation);
    [DllImport(Libraries.GLib, EntryPoint = "g_relation_index")]
    [Obsolete]
    internal static extern void g_relation_index(this GRelationHandle relation, int field, GHashFunc hash_func, GEqualFunc key_equal_func);
    [DllImport(Libraries.GLib, EntryPoint = "g_relation_insert")]
    [Obsolete]
    internal static extern void g_relation_insert(this GRelationHandle relation, IntPtr @__argList);
    [DllImport(Libraries.GLib, EntryPoint = "g_relation_delete")]
    [Obsolete]
    internal static extern int g_relation_delete(this GRelationHandle relation, IntPtr key, int field);
    [DllImport(Libraries.GLib, EntryPoint = "g_relation_select")]
    internal static extern GTuplesHandle g_relation_select(this GRelationHandle relation, IntPtr key, int field);
    [DllImport(Libraries.GLib, EntryPoint = "g_relation_count")]
    [Obsolete]
    internal static extern int g_relation_count(this GRelationHandle relation, IntPtr key, int field);
    [DllImport(Libraries.GLib, EntryPoint = "g_relation_exists")]
    [Obsolete]
    internal static extern int g_relation_exists(this GRelationHandle relation, IntPtr @__argList);
    [DllImport(Libraries.GLib, EntryPoint = "g_relation_print")]
    [Obsolete]
    internal static extern void g_relation_print(this GRelationHandle relation);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GRelationHandle g_relation_new(int fields);
}
