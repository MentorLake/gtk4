namespace MentorLake.Gtk4.Gsk4;

public class GskConicGradientNodeHandle : GskRenderNodeHandle
{
	public static GskConicGradientNodeHandle New(graphene_rect_tHandle bounds, graphene_point_tHandle center, float rotation, GskColorStop[] color_stops, UIntPtr n_color_stops)
	{
		return GskConicGradientNodeExterns.gsk_conic_gradient_node_new(bounds, center, rotation, color_stops, n_color_stops);
	}

}

public static class GskConicGradientNodeHandleExtensions
{
	public static float GetAngle(this GskConicGradientNodeHandle node)
	{
		return GskConicGradientNodeExterns.gsk_conic_gradient_node_get_angle(node);
	}

	public static graphene_point_tHandle GetCenter(this GskConicGradientNodeHandle node)
	{
		return GskConicGradientNodeExterns.gsk_conic_gradient_node_get_center(node);
	}

	public static IntPtr GetColorStops(this GskConicGradientNodeHandle node, out UIntPtr n_stops)
	{
		return GskConicGradientNodeExterns.gsk_conic_gradient_node_get_color_stops(node, out n_stops);
	}

	public static UIntPtr GetNColorStops(this GskConicGradientNodeHandle node)
	{
		return GskConicGradientNodeExterns.gsk_conic_gradient_node_get_n_color_stops(node);
	}

	public static float GetRotation(this GskConicGradientNodeHandle node)
	{
		return GskConicGradientNodeExterns.gsk_conic_gradient_node_get_rotation(node);
	}

}

internal class GskConicGradientNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskConicGradientNodeHandle gsk_conic_gradient_node_new(graphene_rect_tHandle bounds, graphene_point_tHandle center, float rotation, GskColorStop[] color_stops, UIntPtr n_color_stops);

	[DllImport(Libraries.Gsk4)]
	internal static extern float gsk_conic_gradient_node_get_angle(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern graphene_point_tHandle gsk_conic_gradient_node_get_center(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern IntPtr gsk_conic_gradient_node_get_color_stops(GskRenderNodeHandle node, out UIntPtr n_stops);

	[DllImport(Libraries.Gsk4)]
	internal static extern UIntPtr gsk_conic_gradient_node_get_n_color_stops(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern float gsk_conic_gradient_node_get_rotation(GskRenderNodeHandle node);

}
