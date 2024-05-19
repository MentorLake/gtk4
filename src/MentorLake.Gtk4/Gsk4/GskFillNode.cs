namespace MentorLake.Gtk4.Gsk4;

public class GskFillNodeHandle : GskRenderNodeHandle
{
	public static GskFillNodeHandle New(GskRenderNodeHandle child, GskPathHandle path, GskFillRule fill_rule)
	{
		return GskFillNodeExterns.gsk_fill_node_new(child, path, fill_rule);
	}

}

public static class GskFillNodeHandleExtensions
{
	public static GskRenderNodeHandle GetChild(this GskFillNodeHandle node)
	{
		return GskFillNodeExterns.gsk_fill_node_get_child(node);
	}

	public static GskFillRule GetFillRule(this GskFillNodeHandle node)
	{
		return GskFillNodeExterns.gsk_fill_node_get_fill_rule(node);
	}

	public static GskPathHandle GetPath(this GskFillNodeHandle node)
	{
		return GskFillNodeExterns.gsk_fill_node_get_path(node);
	}

}

internal class GskFillNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskFillNodeHandle gsk_fill_node_new(GskRenderNodeHandle child, GskPathHandle path, GskFillRule fill_rule);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskRenderNodeHandle gsk_fill_node_get_child(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskFillRule gsk_fill_node_get_fill_rule(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskPathHandle gsk_fill_node_get_path(GskRenderNodeHandle node);

}
