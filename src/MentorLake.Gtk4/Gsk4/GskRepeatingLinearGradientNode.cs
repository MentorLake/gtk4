namespace MentorLake.Gtk4.Gsk4;

public class GskRepeatingLinearGradientNodeHandle : GskRenderNodeHandle
{
	public static GskRepeatingLinearGradientNodeHandle New(graphene_rect_tHandle bounds, graphene_point_tHandle start, graphene_point_tHandle end, GskColorStop[] color_stops, UIntPtr n_color_stops)
	{
		return GskRepeatingLinearGradientNodeExterns.gsk_repeating_linear_gradient_node_new(bounds, start, end, color_stops, n_color_stops);
	}

}

public static class GskRepeatingLinearGradientNodeHandleExtensions
{
}

internal class GskRepeatingLinearGradientNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskRepeatingLinearGradientNodeHandle gsk_repeating_linear_gradient_node_new(graphene_rect_tHandle bounds, graphene_point_tHandle start, graphene_point_tHandle end, GskColorStop[] color_stops, UIntPtr n_color_stops);

}
