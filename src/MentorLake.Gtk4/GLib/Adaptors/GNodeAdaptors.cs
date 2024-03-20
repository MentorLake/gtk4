using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GNodeAdaptors
{
	public static GNodeHandle Destroy(this GNodeHandle root)
	{
		GNodeExterns.g_node_destroy(root);
		return root;
	}

	public static GNodeHandle Unlink(this GNodeHandle node)
	{
		GNodeExterns.g_node_unlink(node);
		return node;
	}

	public static GNodeHandle CopyDeep(this GNodeHandle node, GCopyFunc copy_func, IntPtr data)
	{
		return GNodeExterns.g_node_copy_deep(node, copy_func, data);
	}

	public static GNodeHandle Copy(this GNodeHandle node)
	{
		return GNodeExterns.g_node_copy(node);
	}

	public static GNodeHandle Insert(this GNodeHandle parent, int position, GNodeHandle node)
	{
		return GNodeExterns.g_node_insert(parent, position, node);
	}

	public static GNodeHandle InsertBefore(this GNodeHandle parent, GNodeHandle sibling, GNodeHandle node)
	{
		return GNodeExterns.g_node_insert_before(parent, sibling, node);
	}

	public static GNodeHandle InsertAfter(this GNodeHandle parent, GNodeHandle sibling, GNodeHandle node)
	{
		return GNodeExterns.g_node_insert_after(parent, sibling, node);
	}

	public static GNodeHandle Prepend(this GNodeHandle parent, GNodeHandle node)
	{
		return GNodeExterns.g_node_prepend(parent, node);
	}

	public static uint NNodes(this GNodeHandle root, GTraverseFlags flags)
	{
		return GNodeExterns.g_node_n_nodes(root, flags);
	}

	public static GNodeHandle GetRoot(this GNodeHandle node)
	{
		return GNodeExterns.g_node_get_root(node);
	}

	public static int IsAncestor(this GNodeHandle node, GNodeHandle descendant)
	{
		return GNodeExterns.g_node_is_ancestor(node, descendant);
	}

	public static uint Depth(this GNodeHandle node)
	{
		return GNodeExterns.g_node_depth(node);
	}

	public static GNodeHandle Find(this GNodeHandle root, GTraverseType order, GTraverseFlags flags, IntPtr data)
	{
		return GNodeExterns.g_node_find(root, order, flags, data);
	}

	public static GNodeHandle Traverse(this GNodeHandle root, GTraverseType order, GTraverseFlags flags, int max_depth, GNodeTraverseFunc func, IntPtr data)
	{
		GNodeExterns.g_node_traverse(root, order, flags, max_depth, func, data);
		return root;
	}

	public static uint MaxHeight(this GNodeHandle root)
	{
		return GNodeExterns.g_node_max_height(root);
	}

	public static GNodeHandle ChildrenForeach(this GNodeHandle node, GTraverseFlags flags, GNodeForeachFunc func, IntPtr data)
	{
		GNodeExterns.g_node_children_foreach(node, flags, func, data);
		return node;
	}

	public static GNodeHandle ReverseChildren(this GNodeHandle node)
	{
		GNodeExterns.g_node_reverse_children(node);
		return node;
	}

	public static uint NChildren(this GNodeHandle node)
	{
		return GNodeExterns.g_node_n_children(node);
	}

	public static GNodeHandle NthChild(this GNodeHandle node, uint n)
	{
		return GNodeExterns.g_node_nth_child(node, n);
	}

	public static GNodeHandle LastChild(this GNodeHandle node)
	{
		return GNodeExterns.g_node_last_child(node);
	}

	public static GNodeHandle FindChild(this GNodeHandle node, GTraverseFlags flags, IntPtr data)
	{
		return GNodeExterns.g_node_find_child(node, flags, data);
	}

	public static int ChildPosition(this GNodeHandle node, GNodeHandle child)
	{
		return GNodeExterns.g_node_child_position(node, child);
	}

	public static int ChildIndex(this GNodeHandle node, IntPtr data)
	{
		return GNodeExterns.g_node_child_index(node, data);
	}

	public static GNodeHandle FirstSibling(this GNodeHandle node)
	{
		return GNodeExterns.g_node_first_sibling(node);
	}

	public static GNodeHandle LastSibling(this GNodeHandle node)
	{
		return GNodeExterns.g_node_last_sibling(node);
	}
}
