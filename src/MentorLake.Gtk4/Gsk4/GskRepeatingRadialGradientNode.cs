namespace MentorLake.Gtk4.Gsk4;

public class GskRepeatingRadialGradientNodeHandle : GskRenderNodeHandle
{
	public static GskRepeatingRadialGradientNodeHandle New(graphene_rect_tHandle bounds, graphene_point_tHandle center, float hradius, float vradius, float start, float end, GskColorStop[] color_stops, UIntPtr n_color_stops)
	{
		return GskRepeatingRadialGradientNodeExterns.gsk_repeating_radial_gradient_node_new(bounds, center, hradius, vradius, start, end, color_stops, n_color_stops);
	}

}

public static class GskRepeatingRadialGradientNodeHandleExtensions
{
}

internal class GskRepeatingRadialGradientNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskRepeatingRadialGradientNodeHandle gsk_repeating_radial_gradient_node_new(graphene_rect_tHandle bounds, graphene_point_tHandle center, float hradius, float vradius, float start, float end, GskColorStop[] color_stops, UIntPtr n_color_stops);

}
