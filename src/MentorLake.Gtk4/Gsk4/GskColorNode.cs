namespace MentorLake.Gtk4.Gsk4;

public class GskColorNodeHandle : GskRenderNodeHandle
{
	public static GskColorNodeHandle New(GdkRGBAHandle rgba, graphene_rect_tHandle bounds)
	{
		return GskColorNodeExterns.gsk_color_node_new(rgba, bounds);
	}

}

public static class GskColorNodeHandleExtensions
{
	public static GdkRGBAHandle GetColor(this GskColorNodeHandle node)
	{
		return GskColorNodeExterns.gsk_color_node_get_color(node);
	}

}

internal class GskColorNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskColorNodeHandle gsk_color_node_new(GdkRGBAHandle rgba, graphene_rect_tHandle bounds);

	[DllImport(Libraries.Gsk4)]
	internal static extern GdkRGBAHandle gsk_color_node_get_color(GskRenderNodeHandle node);

}
