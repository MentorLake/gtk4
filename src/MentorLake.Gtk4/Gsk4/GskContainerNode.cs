namespace MentorLake.Gtk4.Gsk4;

public class GskContainerNodeHandle : GskRenderNodeHandle
{
	public static GskContainerNodeHandle New(GskRenderNodeHandle[] children, uint n_children)
	{
		return GskContainerNodeExterns.gsk_container_node_new(children, n_children);
	}

}

public static class GskContainerNodeHandleExtensions
{
	public static GskRenderNodeHandle GetChild(this GskContainerNodeHandle node, uint idx)
	{
		return GskContainerNodeExterns.gsk_container_node_get_child(node, idx);
	}

	public static uint GetNChildren(this GskContainerNodeHandle node)
	{
		return GskContainerNodeExterns.gsk_container_node_get_n_children(node);
	}

}

internal class GskContainerNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskContainerNodeHandle gsk_container_node_new(GskRenderNodeHandle[] children, uint n_children);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskRenderNodeHandle gsk_container_node_get_child(GskRenderNodeHandle node, uint idx);

	[DllImport(Libraries.Gsk4)]
	internal static extern uint gsk_container_node_get_n_children(GskRenderNodeHandle node);

}
