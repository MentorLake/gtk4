namespace MentorLake.Gtk4.Gsk4;

internal class Gsk4GlobalFunctionExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskRenderNodeHandle gsk_value_dup_render_node(GValueHandle value);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_value_set_render_node(GValueHandle value, GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_value_take_render_node(GValueHandle value, GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskRenderNodeHandle gsk_value_get_render_node(GValueHandle value);

}
