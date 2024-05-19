namespace MentorLake.Gtk4.Gsk4;

public class GskClipNodeHandle : GskRenderNodeHandle
{
	public static GskClipNodeHandle New(GskRenderNodeHandle child, graphene_rect_tHandle clip)
	{
		return GskClipNodeExterns.gsk_clip_node_new(child, clip);
	}

}

public static class GskClipNodeHandleExtensions
{
	public static GskRenderNodeHandle GetChild(this GskClipNodeHandle node)
	{
		return GskClipNodeExterns.gsk_clip_node_get_child(node);
	}

	public static graphene_rect_tHandle GetClip(this GskClipNodeHandle node)
	{
		return GskClipNodeExterns.gsk_clip_node_get_clip(node);
	}

}

internal class GskClipNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskClipNodeHandle gsk_clip_node_new(GskRenderNodeHandle child, graphene_rect_tHandle clip);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskRenderNodeHandle gsk_clip_node_get_child(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern graphene_rect_tHandle gsk_clip_node_get_clip(GskRenderNodeHandle node);

}
