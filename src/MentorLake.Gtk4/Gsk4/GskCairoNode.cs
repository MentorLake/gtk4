namespace MentorLake.Gtk4.Gsk4;

public class GskCairoNodeHandle : GskRenderNodeHandle
{
	public static GskCairoNodeHandle New(graphene_rect_tHandle bounds)
	{
		return GskCairoNodeExterns.gsk_cairo_node_new(bounds);
	}

}

public static class GskCairoNodeHandleExtensions
{
	public static cairo_tHandle GetDrawContext(this GskCairoNodeHandle node)
	{
		return GskCairoNodeExterns.gsk_cairo_node_get_draw_context(node);
	}

	public static cairo_surface_tHandle GetSurface(this GskCairoNodeHandle node)
	{
		return GskCairoNodeExterns.gsk_cairo_node_get_surface(node);
	}

}

internal class GskCairoNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskCairoNodeHandle gsk_cairo_node_new(graphene_rect_tHandle bounds);

	[DllImport(Libraries.Gsk4)]
	internal static extern cairo_tHandle gsk_cairo_node_get_draw_context(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern cairo_surface_tHandle gsk_cairo_node_get_surface(GskRenderNodeHandle node);

}
