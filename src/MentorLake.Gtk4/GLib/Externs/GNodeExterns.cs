using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GNodeExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_node_destroy")]
    internal static extern void g_node_destroy(this GNodeHandle root);
    [DllImport(Libraries.GLib, EntryPoint = "g_node_unlink")]
    internal static extern void g_node_unlink(this GNodeHandle node);
    [DllImport(Libraries.GLib, EntryPoint = "g_node_copy_deep")]
    internal static extern GNodeHandle g_node_copy_deep(this GNodeHandle node, GCopyFunc copy_func, IntPtr data);
    [DllImport(Libraries.GLib, EntryPoint = "g_node_copy")]
    internal static extern GNodeHandle g_node_copy(this GNodeHandle node);
    [DllImport(Libraries.GLib, EntryPoint = "g_node_insert")]
    internal static extern GNodeHandle g_node_insert(this GNodeHandle parent, int position, GNodeHandle node);
    [DllImport(Libraries.GLib, EntryPoint = "g_node_insert_before")]
    internal static extern GNodeHandle g_node_insert_before(this GNodeHandle parent, GNodeHandle sibling, GNodeHandle node);
    [DllImport(Libraries.GLib, EntryPoint = "g_node_insert_after")]
    internal static extern GNodeHandle g_node_insert_after(this GNodeHandle parent, GNodeHandle sibling, GNodeHandle node);
    [DllImport(Libraries.GLib, EntryPoint = "g_node_prepend")]
    internal static extern GNodeHandle g_node_prepend(this GNodeHandle parent, GNodeHandle node);
    [DllImport(Libraries.GLib, EntryPoint = "g_node_n_nodes")]
    internal static extern uint g_node_n_nodes(this GNodeHandle root, GTraverseFlags flags);
    [DllImport(Libraries.GLib, EntryPoint = "g_node_get_root")]
    internal static extern GNodeHandle g_node_get_root(this GNodeHandle node);
    [DllImport(Libraries.GLib, EntryPoint = "g_node_is_ancestor")]
    internal static extern int g_node_is_ancestor(this GNodeHandle node, GNodeHandle descendant);
    [DllImport(Libraries.GLib, EntryPoint = "g_node_depth")]
    internal static extern uint g_node_depth(this GNodeHandle node);
    [DllImport(Libraries.GLib, EntryPoint = "g_node_find")]
    internal static extern GNodeHandle g_node_find(this GNodeHandle root, GTraverseType order, GTraverseFlags flags, IntPtr data);
    [DllImport(Libraries.GLib, EntryPoint = "g_node_traverse")]
    internal static extern void g_node_traverse(this GNodeHandle root, GTraverseType order, GTraverseFlags flags, int max_depth, GNodeTraverseFunc func, IntPtr data);
    [DllImport(Libraries.GLib, EntryPoint = "g_node_max_height")]
    internal static extern uint g_node_max_height(this GNodeHandle root);
    [DllImport(Libraries.GLib, EntryPoint = "g_node_children_foreach")]
    internal static extern void g_node_children_foreach(this GNodeHandle node, GTraverseFlags flags, GNodeForeachFunc func, IntPtr data);
    [DllImport(Libraries.GLib, EntryPoint = "g_node_reverse_children")]
    internal static extern void g_node_reverse_children(this GNodeHandle node);
    [DllImport(Libraries.GLib, EntryPoint = "g_node_n_children")]
    internal static extern uint g_node_n_children(this GNodeHandle node);
    [DllImport(Libraries.GLib, EntryPoint = "g_node_nth_child")]
    internal static extern GNodeHandle g_node_nth_child(this GNodeHandle node, uint n);
    [DllImport(Libraries.GLib, EntryPoint = "g_node_last_child")]
    internal static extern GNodeHandle g_node_last_child(this GNodeHandle node);
    [DllImport(Libraries.GLib, EntryPoint = "g_node_find_child")]
    internal static extern GNodeHandle g_node_find_child(this GNodeHandle node, GTraverseFlags flags, IntPtr data);
    [DllImport(Libraries.GLib, EntryPoint = "g_node_child_position")]
    internal static extern int g_node_child_position(this GNodeHandle node, GNodeHandle child);
    [DllImport(Libraries.GLib, EntryPoint = "g_node_child_index")]
    internal static extern int g_node_child_index(this GNodeHandle node, IntPtr data);
    [DllImport(Libraries.GLib, EntryPoint = "g_node_first_sibling")]
    internal static extern GNodeHandle g_node_first_sibling(this GNodeHandle node);
    [DllImport(Libraries.GLib, EntryPoint = "g_node_last_sibling")]
    internal static extern GNodeHandle g_node_last_sibling(this GNodeHandle node);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GNodeHandle g_node_new(IntPtr data);
}
