using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GTreeAdaptors
{
	public static GTreeNodeHandle NodeFirst(this GTreeHandle tree)
	{
		return GTreeExterns.g_tree_node_first(tree);
	}

	public static GTreeNodeHandle NodeLast(this GTreeHandle tree)
	{
		return GTreeExterns.g_tree_node_last(tree);
	}

	public static GTreeHandle Ref(this GTreeHandle tree)
	{
		return GTreeExterns.g_tree_ref(tree);
	}

	public static GTreeHandle Unref(this GTreeHandle tree)
	{
		GTreeExterns.g_tree_unref(tree);
		return tree;
	}

	public static GTreeHandle Destroy(this GTreeHandle tree)
	{
		GTreeExterns.g_tree_destroy(tree);
		return tree;
	}

	public static GTreeNodeHandle InsertNode(this GTreeHandle tree, IntPtr key, IntPtr value)
	{
		return GTreeExterns.g_tree_insert_node(tree, key, value);
	}

	public static GTreeHandle Insert(this GTreeHandle tree, IntPtr key, IntPtr value)
	{
		GTreeExterns.g_tree_insert(tree, key, value);
		return tree;
	}

	public static GTreeNodeHandle ReplaceNode(this GTreeHandle tree, IntPtr key, IntPtr value)
	{
		return GTreeExterns.g_tree_replace_node(tree, key, value);
	}

	public static GTreeHandle Replace(this GTreeHandle tree, IntPtr key, IntPtr value)
	{
		GTreeExterns.g_tree_replace(tree, key, value);
		return tree;
	}

	public static int Remove(this GTreeHandle tree, IntPtr key)
	{
		return GTreeExterns.g_tree_remove(tree, key);
	}

	public static GTreeHandle RemoveAll(this GTreeHandle tree)
	{
		GTreeExterns.g_tree_remove_all(tree);
		return tree;
	}

	public static int Steal(this GTreeHandle tree, IntPtr key)
	{
		return GTreeExterns.g_tree_steal(tree, key);
	}

	public static GTreeNodeHandle LookupNode(this GTreeHandle tree, IntPtr key)
	{
		return GTreeExterns.g_tree_lookup_node(tree, key);
	}

	public static IntPtr Lookup(this GTreeHandle tree, IntPtr key)
	{
		return GTreeExterns.g_tree_lookup(tree, key);
	}

	public static int LookupExtended(this GTreeHandle tree, IntPtr lookup_key, out IntPtr orig_key, out IntPtr value)
	{
		return GTreeExterns.g_tree_lookup_extended(tree, lookup_key, out orig_key, out value);
	}

	public static GTreeHandle Foreach(this GTreeHandle tree, GTraverseFunc func, IntPtr user_data)
	{
		GTreeExterns.g_tree_foreach(tree, func, user_data);
		return tree;
	}

	public static GTreeHandle ForeachNode(this GTreeHandle tree, GTraverseNodeFunc func, IntPtr user_data)
	{
		GTreeExterns.g_tree_foreach_node(tree, func, user_data);
		return tree;
	}

	public static GTreeHandle Traverse(this GTreeHandle tree, GTraverseFunc traverse_func, GTraverseType traverse_type, IntPtr user_data)
	{
		GTreeExterns.g_tree_traverse(tree, traverse_func, traverse_type, user_data);
		return tree;
	}

	public static GTreeNodeHandle SearchNode(this GTreeHandle tree, GCompareFunc search_func, IntPtr user_data)
	{
		return GTreeExterns.g_tree_search_node(tree, search_func, user_data);
	}

	public static IntPtr Search(this GTreeHandle tree, GCompareFunc search_func, IntPtr user_data)
	{
		return GTreeExterns.g_tree_search(tree, search_func, user_data);
	}

	public static GTreeNodeHandle LowerBound(this GTreeHandle tree, IntPtr key)
	{
		return GTreeExterns.g_tree_lower_bound(tree, key);
	}

	public static GTreeNodeHandle UpperBound(this GTreeHandle tree, IntPtr key)
	{
		return GTreeExterns.g_tree_upper_bound(tree, key);
	}

	public static int Height(this GTreeHandle tree)
	{
		return GTreeExterns.g_tree_height(tree);
	}

	public static int Nnodes(this GTreeHandle tree)
	{
		return GTreeExterns.g_tree_nnodes(tree);
	}

	public static GTreeHandle NewWithData(GCompareDataFunc key_compare_func, IntPtr key_compare_data)
	{
		return GTreeExterns.g_tree_new_with_data(key_compare_func, key_compare_data);
	}

	public static GTreeHandle NewFull(GCompareDataFunc key_compare_func, IntPtr key_compare_data, GDestroyNotify key_destroy_func, GDestroyNotify value_destroy_func)
	{
		return GTreeExterns.g_tree_new_full(key_compare_func, key_compare_data, key_destroy_func, value_destroy_func);
	}
}
