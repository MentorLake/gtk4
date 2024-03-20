using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;

public static class GTreeNodeExterns
{
	[DllImport(Libraries.GLib, EntryPoint = "g_tree_node_previous")]
	internal static extern GTreeNodeHandle g_tree_node_previous(this GTreeNodeHandle node);

	[DllImport(Libraries.GLib, EntryPoint = "g_tree_node_next")]
	internal static extern GTreeNodeHandle g_tree_node_next(this GTreeNodeHandle node);

	[DllImport(Libraries.GLib, EntryPoint = "g_tree_node_key")]
	internal static extern IntPtr g_tree_node_key(this GTreeNodeHandle node);

	[DllImport(Libraries.GLib, EntryPoint = "g_tree_node_value")]
	internal static extern IntPtr g_tree_node_value(this GTreeNodeHandle node);
}
