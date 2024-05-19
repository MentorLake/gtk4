namespace MentorLake.Gtk4.Gsk4;

public class GskTextureNodeHandle : GskRenderNodeHandle
{
	public static GskTextureNodeHandle New(GdkTextureHandle texture, graphene_rect_tHandle bounds)
	{
		return GskTextureNodeExterns.gsk_texture_node_new(texture, bounds);
	}

}

public static class GskTextureNodeHandleExtensions
{
	public static GdkTextureHandle GetTexture(this GskTextureNodeHandle node)
	{
		return GskTextureNodeExterns.gsk_texture_node_get_texture(node);
	}

}

internal class GskTextureNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskTextureNodeHandle gsk_texture_node_new(GdkTextureHandle texture, graphene_rect_tHandle bounds);

	[DllImport(Libraries.Gsk4)]
	internal static extern GdkTextureHandle gsk_texture_node_get_texture(GskRenderNodeHandle node);

}
