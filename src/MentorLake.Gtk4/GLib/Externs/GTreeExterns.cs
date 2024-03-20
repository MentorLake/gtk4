using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GTreeExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_tree_node_first")]
    internal static extern GTreeNodeHandle g_tree_node_first(this GTreeHandle tree);
    [DllImport(Libraries.GLib, EntryPoint = "g_tree_node_last")]
    internal static extern GTreeNodeHandle g_tree_node_last(this GTreeHandle tree);
    [DllImport(Libraries.GLib, EntryPoint = "g_tree_ref")]
    internal static extern GTreeHandle g_tree_ref(this GTreeHandle tree);
    [DllImport(Libraries.GLib, EntryPoint = "g_tree_unref")]
    internal static extern void g_tree_unref(this GTreeHandle tree);
    [DllImport(Libraries.GLib, EntryPoint = "g_tree_destroy")]
    internal static extern void g_tree_destroy(this GTreeHandle tree);
    [DllImport(Libraries.GLib, EntryPoint = "g_tree_insert_node")]
    internal static extern GTreeNodeHandle g_tree_insert_node(this GTreeHandle tree, IntPtr key, IntPtr value);
    [DllImport(Libraries.GLib, EntryPoint = "g_tree_insert")]
    internal static extern void g_tree_insert(this GTreeHandle tree, IntPtr key, IntPtr value);
    [DllImport(Libraries.GLib, EntryPoint = "g_tree_replace_node")]
    internal static extern GTreeNodeHandle g_tree_replace_node(this GTreeHandle tree, IntPtr key, IntPtr value);
    [DllImport(Libraries.GLib, EntryPoint = "g_tree_replace")]
    internal static extern void g_tree_replace(this GTreeHandle tree, IntPtr key, IntPtr value);
    [DllImport(Libraries.GLib, EntryPoint = "g_tree_remove")]
    internal static extern int g_tree_remove(this GTreeHandle tree, IntPtr key);
    [DllImport(Libraries.GLib, EntryPoint = "g_tree_remove_all")]
    internal static extern void g_tree_remove_all(this GTreeHandle tree);
    [DllImport(Libraries.GLib, EntryPoint = "g_tree_steal")]
    internal static extern int g_tree_steal(this GTreeHandle tree, IntPtr key);
    [DllImport(Libraries.GLib, EntryPoint = "g_tree_lookup_node")]
    internal static extern GTreeNodeHandle g_tree_lookup_node(this GTreeHandle tree, IntPtr key);
    [DllImport(Libraries.GLib, EntryPoint = "g_tree_lookup")]
    internal static extern IntPtr g_tree_lookup(this GTreeHandle tree, IntPtr key);
    [DllImport(Libraries.GLib, EntryPoint = "g_tree_lookup_extended")]
    internal static extern int g_tree_lookup_extended(this GTreeHandle tree, IntPtr lookup_key, out IntPtr orig_key, out IntPtr value);
    [DllImport(Libraries.GLib, EntryPoint = "g_tree_foreach")]
    internal static extern void g_tree_foreach(this GTreeHandle tree, GTraverseFunc func, IntPtr user_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_tree_foreach_node")]
    internal static extern void g_tree_foreach_node(this GTreeHandle tree, GTraverseNodeFunc func, IntPtr user_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_tree_traverse")]
    [Obsolete]
    internal static extern void g_tree_traverse(this GTreeHandle tree, GTraverseFunc traverse_func, GTraverseType traverse_type, IntPtr user_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_tree_search_node")]
    internal static extern GTreeNodeHandle g_tree_search_node(this GTreeHandle tree, GCompareFunc search_func, IntPtr user_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_tree_search")]
    internal static extern IntPtr g_tree_search(this GTreeHandle tree, GCompareFunc search_func, IntPtr user_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_tree_lower_bound")]
    internal static extern GTreeNodeHandle g_tree_lower_bound(this GTreeHandle tree, IntPtr key);
    [DllImport(Libraries.GLib, EntryPoint = "g_tree_upper_bound")]
    internal static extern GTreeNodeHandle g_tree_upper_bound(this GTreeHandle tree, IntPtr key);
    [DllImport(Libraries.GLib, EntryPoint = "g_tree_height")]
    internal static extern int g_tree_height(this GTreeHandle tree);
    [DllImport(Libraries.GLib, EntryPoint = "g_tree_nnodes")]
    internal static extern int g_tree_nnodes(this GTreeHandle tree);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GTreeHandle g_tree_new(GCompareFunc key_compare_func);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GTreeHandle g_tree_new_with_data(GCompareDataFunc key_compare_func, IntPtr key_compare_data);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GTreeHandle g_tree_new_full(GCompareDataFunc key_compare_func, IntPtr key_compare_data, GDestroyNotify key_destroy_func, GDestroyNotify value_destroy_func);
}
