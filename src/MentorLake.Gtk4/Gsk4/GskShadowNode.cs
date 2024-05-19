namespace MentorLake.Gtk4.Gsk4;

public class GskShadowNodeHandle : GskRenderNodeHandle
{
	public static GskShadowNodeHandle New(GskRenderNodeHandle child, GskShadow[] shadows, int n_shadows)
	{
		return GskShadowNodeExterns.gsk_shadow_node_new(child, shadows, n_shadows);
	}

}

public static class GskShadowNodeHandleExtensions
{
	public static GskRenderNodeHandle GetChild(this GskShadowNodeHandle node)
	{
		return GskShadowNodeExterns.gsk_shadow_node_get_child(node);
	}

	public static int GetNShadows(this GskShadowNodeHandle node)
	{
		return GskShadowNodeExterns.gsk_shadow_node_get_n_shadows(node);
	}

	public static GskShadowHandle GetShadow(this GskShadowNodeHandle node, int i)
	{
		return GskShadowNodeExterns.gsk_shadow_node_get_shadow(node, i);
	}

}

internal class GskShadowNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskShadowNodeHandle gsk_shadow_node_new(GskRenderNodeHandle child, GskShadow[] shadows, int n_shadows);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskRenderNodeHandle gsk_shadow_node_get_child(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern int gsk_shadow_node_get_n_shadows(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskShadowHandle gsk_shadow_node_get_shadow(GskRenderNodeHandle node, int i);

}
