namespace MentorLake.Gtk4.Gsk4;

public class GskColorMatrixNodeHandle : GskRenderNodeHandle
{
	public static GskColorMatrixNodeHandle New(GskRenderNodeHandle child, graphene_matrix_tHandle color_matrix, graphene_vec4_tHandle color_offset)
	{
		return GskColorMatrixNodeExterns.gsk_color_matrix_node_new(child, color_matrix, color_offset);
	}

}

public static class GskColorMatrixNodeHandleExtensions
{
	public static GskRenderNodeHandle GetChild(this GskColorMatrixNodeHandle node)
	{
		return GskColorMatrixNodeExterns.gsk_color_matrix_node_get_child(node);
	}

	public static graphene_matrix_tHandle GetColorMatrix(this GskColorMatrixNodeHandle node)
	{
		return GskColorMatrixNodeExterns.gsk_color_matrix_node_get_color_matrix(node);
	}

	public static graphene_vec4_tHandle GetColorOffset(this GskColorMatrixNodeHandle node)
	{
		return GskColorMatrixNodeExterns.gsk_color_matrix_node_get_color_offset(node);
	}

}

internal class GskColorMatrixNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskColorMatrixNodeHandle gsk_color_matrix_node_new(GskRenderNodeHandle child, graphene_matrix_tHandle color_matrix, graphene_vec4_tHandle color_offset);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskRenderNodeHandle gsk_color_matrix_node_get_child(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern graphene_matrix_tHandle gsk_color_matrix_node_get_color_matrix(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern graphene_vec4_tHandle gsk_color_matrix_node_get_color_offset(GskRenderNodeHandle node);

}
