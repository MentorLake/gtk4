namespace MentorLake.Gtk4.Gsk4;

public class GskTransformNodeHandle : GskRenderNodeHandle
{
	public static GskTransformNodeHandle New(GskRenderNodeHandle child, GskTransformHandle transform)
	{
		return GskTransformNodeExterns.gsk_transform_node_new(child, transform);
	}

}

public static class GskTransformNodeHandleExtensions
{
	public static GskRenderNodeHandle GetChild(this GskTransformNodeHandle node)
	{
		return GskTransformNodeExterns.gsk_transform_node_get_child(node);
	}

	public static GskTransformHandle GetTransform(this GskTransformNodeHandle node)
	{
		return GskTransformNodeExterns.gsk_transform_node_get_transform(node);
	}

}

internal class GskTransformNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskTransformNodeHandle gsk_transform_node_new(GskRenderNodeHandle child, GskTransformHandle transform);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskRenderNodeHandle gsk_transform_node_get_child(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskTransformHandle gsk_transform_node_get_transform(GskRenderNodeHandle node);

}
