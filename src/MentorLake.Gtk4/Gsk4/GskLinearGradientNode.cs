namespace MentorLake.Gtk4.Gsk4;

public class GskLinearGradientNodeHandle : GskRenderNodeHandle
{
	public static GskLinearGradientNodeHandle New(graphene_rect_tHandle bounds, graphene_point_tHandle start, graphene_point_tHandle end, GskColorStop[] color_stops, UIntPtr n_color_stops)
	{
		return GskLinearGradientNodeExterns.gsk_linear_gradient_node_new(bounds, start, end, color_stops, n_color_stops);
	}

}

public static class GskLinearGradientNodeHandleExtensions
{
	public static IntPtr GetColorStops(this GskLinearGradientNodeHandle node, out UIntPtr n_stops)
	{
		return GskLinearGradientNodeExterns.gsk_linear_gradient_node_get_color_stops(node, out n_stops);
	}

	public static graphene_point_tHandle GetEnd(this GskLinearGradientNodeHandle node)
	{
		return GskLinearGradientNodeExterns.gsk_linear_gradient_node_get_end(node);
	}

	public static UIntPtr GetNColorStops(this GskLinearGradientNodeHandle node)
	{
		return GskLinearGradientNodeExterns.gsk_linear_gradient_node_get_n_color_stops(node);
	}

	public static graphene_point_tHandle GetStart(this GskLinearGradientNodeHandle node)
	{
		return GskLinearGradientNodeExterns.gsk_linear_gradient_node_get_start(node);
	}

}

internal class GskLinearGradientNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskLinearGradientNodeHandle gsk_linear_gradient_node_new(graphene_rect_tHandle bounds, graphene_point_tHandle start, graphene_point_tHandle end, GskColorStop[] color_stops, UIntPtr n_color_stops);

	[DllImport(Libraries.Gsk4)]
	internal static extern IntPtr gsk_linear_gradient_node_get_color_stops(GskRenderNodeHandle node, out UIntPtr n_stops);

	[DllImport(Libraries.Gsk4)]
	internal static extern graphene_point_tHandle gsk_linear_gradient_node_get_end(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern UIntPtr gsk_linear_gradient_node_get_n_color_stops(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern graphene_point_tHandle gsk_linear_gradient_node_get_start(GskRenderNodeHandle node);

}
