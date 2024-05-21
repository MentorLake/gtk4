namespace MentorLake.Gtk4.GLib;

public class GTreeNodeHandle : BaseSafeHandle
{
}


public static class GTreeNodeHandleExtensions
{
	public static IntPtr Key(this GTreeNodeHandle node)
	{
		return GTreeNodeExterns.g_tree_node_key(node);
	}

	public static GTreeNodeHandle Next(this GTreeNodeHandle node)
	{
		return GTreeNodeExterns.g_tree_node_next(node);
	}

	public static GTreeNodeHandle Previous(this GTreeNodeHandle node)
	{
		return GTreeNodeExterns.g_tree_node_previous(node);
	}

	public static IntPtr Value(this GTreeNodeHandle node)
	{
		return GTreeNodeExterns.g_tree_node_value(node);
	}

}
internal class GTreeNodeExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_tree_node_key(GTreeNodeHandle node);

	[DllImport(Libraries.GLib)]
	internal static extern GTreeNodeHandle g_tree_node_next(GTreeNodeHandle node);

	[DllImport(Libraries.GLib)]
	internal static extern GTreeNodeHandle g_tree_node_previous(GTreeNodeHandle node);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_tree_node_value(GTreeNodeHandle node);

}

public struct GTreeNode
{
}
