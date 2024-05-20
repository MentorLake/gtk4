namespace MentorLake.Gtk4.Gsk4;

public class GskRadialGradientNodeHandle : GskRenderNodeHandle
{
	public static GskRadialGradientNodeHandle New(graphene_rect_tHandle bounds, graphene_point_tHandle center, float hradius, float vradius, float start, float end, GskColorStop[] color_stops, UIntPtr n_color_stops)
	{
		return GskRadialGradientNodeExterns.gsk_radial_gradient_node_new(bounds, center, hradius, vradius, start, end, color_stops, n_color_stops);
	}

}

public static class GskRadialGradientNodeHandleExtensions
{
	public static graphene_point_tHandle GetCenter(this GskRadialGradientNodeHandle node)
	{
		return GskRadialGradientNodeExterns.gsk_radial_gradient_node_get_center(node);
	}

	public static IntPtr GetColorStops(this GskRadialGradientNodeHandle node, out UIntPtr n_stops)
	{
		return GskRadialGradientNodeExterns.gsk_radial_gradient_node_get_color_stops(node, out n_stops);
	}

	public static float GetEnd(this GskRadialGradientNodeHandle node)
	{
		return GskRadialGradientNodeExterns.gsk_radial_gradient_node_get_end(node);
	}

	public static float GetHradius(this GskRadialGradientNodeHandle node)
	{
		return GskRadialGradientNodeExterns.gsk_radial_gradient_node_get_hradius(node);
	}

	public static UIntPtr GetNColorStops(this GskRadialGradientNodeHandle node)
	{
		return GskRadialGradientNodeExterns.gsk_radial_gradient_node_get_n_color_stops(node);
	}

	public static float GetStart(this GskRadialGradientNodeHandle node)
	{
		return GskRadialGradientNodeExterns.gsk_radial_gradient_node_get_start(node);
	}

	public static float GetVradius(this GskRadialGradientNodeHandle node)
	{
		return GskRadialGradientNodeExterns.gsk_radial_gradient_node_get_vradius(node);
	}

}

internal class GskRadialGradientNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskRadialGradientNodeHandle gsk_radial_gradient_node_new(graphene_rect_tHandle bounds, graphene_point_tHandle center, float hradius, float vradius, float start, float end, GskColorStop[] color_stops, UIntPtr n_color_stops);

	[DllImport(Libraries.Gsk4)]
	internal static extern graphene_point_tHandle gsk_radial_gradient_node_get_center(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern IntPtr gsk_radial_gradient_node_get_color_stops(GskRenderNodeHandle node, out UIntPtr n_stops);

	[DllImport(Libraries.Gsk4)]
	internal static extern float gsk_radial_gradient_node_get_end(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern float gsk_radial_gradient_node_get_hradius(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern UIntPtr gsk_radial_gradient_node_get_n_color_stops(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern float gsk_radial_gradient_node_get_start(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern float gsk_radial_gradient_node_get_vradius(GskRenderNodeHandle node);

}
