namespace MentorLake.Gtk4.Gsk4;

public class GskMaskNodeHandle : GskRenderNodeHandle
{
	public static GskMaskNodeHandle New(GskRenderNodeHandle source, GskRenderNodeHandle mask, GskMaskMode mask_mode)
	{
		return GskMaskNodeExterns.gsk_mask_node_new(source, mask, mask_mode);
	}

}

public static class GskMaskNodeHandleExtensions
{
	public static GskRenderNodeHandle GetMask(this GskMaskNodeHandle node)
	{
		return GskMaskNodeExterns.gsk_mask_node_get_mask(node);
	}

	public static GskMaskMode GetMaskMode(this GskMaskNodeHandle node)
	{
		return GskMaskNodeExterns.gsk_mask_node_get_mask_mode(node);
	}

	public static GskRenderNodeHandle GetSource(this GskMaskNodeHandle node)
	{
		return GskMaskNodeExterns.gsk_mask_node_get_source(node);
	}

}

internal class GskMaskNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskMaskNodeHandle gsk_mask_node_new(GskRenderNodeHandle source, GskRenderNodeHandle mask, GskMaskMode mask_mode);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskRenderNodeHandle gsk_mask_node_get_mask(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskMaskMode gsk_mask_node_get_mask_mode(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskRenderNodeHandle gsk_mask_node_get_source(GskRenderNodeHandle node);

}
