using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GTreeNodeAdaptors
{
    public static GTreeNodeHandle Previous(this GTreeNodeHandle node)
    {
        return GTreeNodeExterns.g_tree_node_previous(node);
    }

    public static GTreeNodeHandle Next(this GTreeNodeHandle node)
    {
        return GTreeNodeExterns.g_tree_node_next(node);
    }

    public static IntPtr Key(this GTreeNodeHandle node)
    {
        return GTreeNodeExterns.g_tree_node_key(node);
    }

    public static IntPtr Value(this GTreeNodeHandle node)
    {
        return GTreeNodeExterns.g_tree_node_value(node);
    }
}
