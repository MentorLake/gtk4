namespace MentorLake.Gtk4.Gsk4;

public class GskOpacityNodeHandle : GskRenderNodeHandle
{
	public static GskOpacityNodeHandle New(GskRenderNodeHandle child, float opacity)
	{
		return GskOpacityNodeExterns.gsk_opacity_node_new(child, opacity);
	}

}

public static class GskOpacityNodeHandleExtensions
{
	public static GskRenderNodeHandle GetChild(this GskOpacityNodeHandle node)
	{
		return GskOpacityNodeExterns.gsk_opacity_node_get_child(node);
	}

	public static float GetOpacity(this GskOpacityNodeHandle node)
	{
		return GskOpacityNodeExterns.gsk_opacity_node_get_opacity(node);
	}

}

internal class GskOpacityNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskOpacityNodeHandle gsk_opacity_node_new(GskRenderNodeHandle child, float opacity);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskRenderNodeHandle gsk_opacity_node_get_child(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern float gsk_opacity_node_get_opacity(GskRenderNodeHandle node);

}
