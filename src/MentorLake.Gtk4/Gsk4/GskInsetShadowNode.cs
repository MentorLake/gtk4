namespace MentorLake.Gtk4.Gsk4;

public class GskInsetShadowNodeHandle : GskRenderNodeHandle
{
	public static GskInsetShadowNodeHandle New(GskRoundedRectHandle outline, GdkRGBAHandle color, float dx, float dy, float spread, float blur_radius)
	{
		return GskInsetShadowNodeExterns.gsk_inset_shadow_node_new(outline, color, dx, dy, spread, blur_radius);
	}

}

public static class GskInsetShadowNodeHandleExtensions
{
	public static float GetBlurRadius(this GskInsetShadowNodeHandle node)
	{
		return GskInsetShadowNodeExterns.gsk_inset_shadow_node_get_blur_radius(node);
	}

	public static GdkRGBAHandle GetColor(this GskInsetShadowNodeHandle node)
	{
		return GskInsetShadowNodeExterns.gsk_inset_shadow_node_get_color(node);
	}

	public static float GetDx(this GskInsetShadowNodeHandle node)
	{
		return GskInsetShadowNodeExterns.gsk_inset_shadow_node_get_dx(node);
	}

	public static float GetDy(this GskInsetShadowNodeHandle node)
	{
		return GskInsetShadowNodeExterns.gsk_inset_shadow_node_get_dy(node);
	}

	public static GskRoundedRectHandle GetOutline(this GskInsetShadowNodeHandle node)
	{
		return GskInsetShadowNodeExterns.gsk_inset_shadow_node_get_outline(node);
	}

	public static float GetSpread(this GskInsetShadowNodeHandle node)
	{
		return GskInsetShadowNodeExterns.gsk_inset_shadow_node_get_spread(node);
	}

}

internal class GskInsetShadowNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskInsetShadowNodeHandle gsk_inset_shadow_node_new(GskRoundedRectHandle outline, GdkRGBAHandle color, float dx, float dy, float spread, float blur_radius);

	[DllImport(Libraries.Gsk4)]
	internal static extern float gsk_inset_shadow_node_get_blur_radius(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern GdkRGBAHandle gsk_inset_shadow_node_get_color(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern float gsk_inset_shadow_node_get_dx(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern float gsk_inset_shadow_node_get_dy(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskRoundedRectHandle gsk_inset_shadow_node_get_outline(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern float gsk_inset_shadow_node_get_spread(GskRenderNodeHandle node);

}
