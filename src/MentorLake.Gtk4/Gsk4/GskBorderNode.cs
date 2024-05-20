namespace MentorLake.Gtk4.Gsk4;

public class GskBorderNodeHandle : GskRenderNodeHandle
{
	public static GskBorderNodeHandle New(GskRoundedRectHandle outline, float[] border_width, GdkRGBA[] border_color)
	{
		return GskBorderNodeExterns.gsk_border_node_new(outline, border_width, border_color);
	}

}

public static class GskBorderNodeHandleExtensions
{
	public static IntPtr GetColors(this GskBorderNodeHandle node)
	{
		return GskBorderNodeExterns.gsk_border_node_get_colors(node);
	}

	public static GskRoundedRectHandle GetOutline(this GskBorderNodeHandle node)
	{
		return GskBorderNodeExterns.gsk_border_node_get_outline(node);
	}

	public static IntPtr GetWidths(this GskBorderNodeHandle node)
	{
		return GskBorderNodeExterns.gsk_border_node_get_widths(node);
	}

}

internal class GskBorderNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskBorderNodeHandle gsk_border_node_new(GskRoundedRectHandle outline, float[] border_width, GdkRGBA[] border_color);

	[DllImport(Libraries.Gsk4)]
	internal static extern IntPtr gsk_border_node_get_colors(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskRoundedRectHandle gsk_border_node_get_outline(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern IntPtr gsk_border_node_get_widths(GskRenderNodeHandle node);

}
