namespace MentorLake.Gtk4.GLib;

public class GNodeHandle : BaseSafeHandle
{
}


public static class GNodeHandleExtensions
{
	public static int ChildIndex(this GNodeHandle node, IntPtr data)
	{
		return GNodeExterns.g_node_child_index(node, data);
	}

	public static int ChildPosition(this GNodeHandle node, GNodeHandle child)
	{
		return GNodeExterns.g_node_child_position(node, child);
	}

	public static GNodeHandle ChildrenForeach(this GNodeHandle node, GTraverseFlags flags, GNodeForeachFunc func, IntPtr data)
	{
		GNodeExterns.g_node_children_foreach(node, flags, func, data);
		return node;
	}

	public static GNodeHandle Copy(this GNodeHandle node)
	{
		return GNodeExterns.g_node_copy(node);
	}

	public static GNodeHandle CopyDeep(this GNodeHandle node, GCopyFunc copy_func, IntPtr data)
	{
		return GNodeExterns.g_node_copy_deep(node, copy_func, data);
	}

	public static uint Depth(this GNodeHandle node)
	{
		return GNodeExterns.g_node_depth(node);
	}

	public static GNodeHandle Destroy(this GNodeHandle root)
	{
		GNodeExterns.g_node_destroy(root);
		return root;
	}

	public static GNodeHandle Find(this GNodeHandle root, GTraverseType order, GTraverseFlags flags, IntPtr data)
	{
		return GNodeExterns.g_node_find(root, order, flags, data);
	}

	public static GNodeHandle FindChild(this GNodeHandle node, GTraverseFlags flags, IntPtr data)
	{
		return GNodeExterns.g_node_find_child(node, flags, data);
	}

	public static GNodeHandle FirstSibling(this GNodeHandle node)
	{
		return GNodeExterns.g_node_first_sibling(node);
	}

	public static GNodeHandle GetRoot(this GNodeHandle node)
	{
		return GNodeExterns.g_node_get_root(node);
	}

	public static GNodeHandle Insert(this GNodeHandle parent, int position, GNodeHandle node)
	{
		return GNodeExterns.g_node_insert(parent, position, node);
	}

	public static GNodeHandle InsertAfter(this GNodeHandle parent, GNodeHandle sibling, GNodeHandle node)
	{
		return GNodeExterns.g_node_insert_after(parent, sibling, node);
	}

	public static GNodeHandle InsertBefore(this GNodeHandle parent, GNodeHandle sibling, GNodeHandle node)
	{
		return GNodeExterns.g_node_insert_before(parent, sibling, node);
	}

	public static bool IsAncestor(this GNodeHandle node, GNodeHandle descendant)
	{
		return GNodeExterns.g_node_is_ancestor(node, descendant);
	}

	public static GNodeHandle LastChild(this GNodeHandle node)
	{
		return GNodeExterns.g_node_last_child(node);
	}

	public static GNodeHandle LastSibling(this GNodeHandle node)
	{
		return GNodeExterns.g_node_last_sibling(node);
	}

	public static uint MaxHeight(this GNodeHandle root)
	{
		return GNodeExterns.g_node_max_height(root);
	}

	public static uint NChildren(this GNodeHandle node)
	{
		return GNodeExterns.g_node_n_children(node);
	}

	public static uint NNodes(this GNodeHandle root, GTraverseFlags flags)
	{
		return GNodeExterns.g_node_n_nodes(root, flags);
	}

	public static GNodeHandle NthChild(this GNodeHandle node, uint n)
	{
		return GNodeExterns.g_node_nth_child(node, n);
	}

	public static GNodeHandle Prepend(this GNodeHandle parent, GNodeHandle node)
	{
		return GNodeExterns.g_node_prepend(parent, node);
	}

	public static GNodeHandle ReverseChildren(this GNodeHandle node)
	{
		GNodeExterns.g_node_reverse_children(node);
		return node;
	}

	public static GNodeHandle Traverse(this GNodeHandle root, GTraverseType order, GTraverseFlags flags, int max_depth, GNodeTraverseFunc func, IntPtr data)
	{
		GNodeExterns.g_node_traverse(root, order, flags, max_depth, func, data);
		return root;
	}

	public static GNodeHandle Unlink(this GNodeHandle node)
	{
		GNodeExterns.g_node_unlink(node);
		return node;
	}

}
internal class GNodeExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern int g_node_child_index(GNodeHandle node, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern int g_node_child_position(GNodeHandle node, GNodeHandle child);

	[DllImport(Libraries.GLib)]
	internal static extern void g_node_children_foreach(GNodeHandle node, GTraverseFlags flags, GNodeForeachFunc func, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern GNodeHandle g_node_copy(GNodeHandle node);

	[DllImport(Libraries.GLib)]
	internal static extern GNodeHandle g_node_copy_deep(GNodeHandle node, GCopyFunc copy_func, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_node_depth(GNodeHandle node);

	[DllImport(Libraries.GLib)]
	internal static extern void g_node_destroy(GNodeHandle root);

	[DllImport(Libraries.GLib)]
	internal static extern GNodeHandle g_node_find(GNodeHandle root, GTraverseType order, GTraverseFlags flags, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern GNodeHandle g_node_find_child(GNodeHandle node, GTraverseFlags flags, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern GNodeHandle g_node_first_sibling(GNodeHandle node);

	[DllImport(Libraries.GLib)]
	internal static extern GNodeHandle g_node_get_root(GNodeHandle node);

	[DllImport(Libraries.GLib)]
	internal static extern GNodeHandle g_node_insert(GNodeHandle parent, int position, GNodeHandle node);

	[DllImport(Libraries.GLib)]
	internal static extern GNodeHandle g_node_insert_after(GNodeHandle parent, GNodeHandle sibling, GNodeHandle node);

	[DllImport(Libraries.GLib)]
	internal static extern GNodeHandle g_node_insert_before(GNodeHandle parent, GNodeHandle sibling, GNodeHandle node);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_node_is_ancestor(GNodeHandle node, GNodeHandle descendant);

	[DllImport(Libraries.GLib)]
	internal static extern GNodeHandle g_node_last_child(GNodeHandle node);

	[DllImport(Libraries.GLib)]
	internal static extern GNodeHandle g_node_last_sibling(GNodeHandle node);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_node_max_height(GNodeHandle root);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_node_n_children(GNodeHandle node);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_node_n_nodes(GNodeHandle root, GTraverseFlags flags);

	[DllImport(Libraries.GLib)]
	internal static extern GNodeHandle g_node_nth_child(GNodeHandle node, uint n);

	[DllImport(Libraries.GLib)]
	internal static extern GNodeHandle g_node_prepend(GNodeHandle parent, GNodeHandle node);

	[DllImport(Libraries.GLib)]
	internal static extern void g_node_reverse_children(GNodeHandle node);

	[DllImport(Libraries.GLib)]
	internal static extern void g_node_traverse(GNodeHandle root, GTraverseType order, GTraverseFlags flags, int max_depth, GNodeTraverseFunc func, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_node_unlink(GNodeHandle node);

}

public struct GNode
{
	public IntPtr data;
	public GNodeHandle next;
	public GNodeHandle prev;
	public GNodeHandle parent;
	public GNodeHandle children;
}
