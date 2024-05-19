namespace MentorLake.Gtk4.Gsk4;

public class GskRoundedClipNodeHandle : GskRenderNodeHandle
{
	public static GskRoundedClipNodeHandle New(GskRenderNodeHandle child, GskRoundedRectHandle clip)
	{
		return GskRoundedClipNodeExterns.gsk_rounded_clip_node_new(child, clip);
	}

}

public static class GskRoundedClipNodeHandleExtensions
{
	public static GskRenderNodeHandle GetChild(this GskRoundedClipNodeHandle node)
	{
		return GskRoundedClipNodeExterns.gsk_rounded_clip_node_get_child(node);
	}

	public static GskRoundedRectHandle GetClip(this GskRoundedClipNodeHandle node)
	{
		return GskRoundedClipNodeExterns.gsk_rounded_clip_node_get_clip(node);
	}

}

internal class GskRoundedClipNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskRoundedClipNodeHandle gsk_rounded_clip_node_new(GskRenderNodeHandle child, GskRoundedRectHandle clip);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskRenderNodeHandle gsk_rounded_clip_node_get_child(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskRoundedRectHandle gsk_rounded_clip_node_get_clip(GskRenderNodeHandle node);

}
