using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.Graphene;

namespace MentorLake.Gtk4.Gsk;

public static class GskRoundedRectExterns
{
	[DllImport(Libraries.Gsk, EntryPoint = "gsk_rounded_rect_init")]
	internal static extern GskRoundedRectHandle gsk_rounded_rect_init(this GskRoundedRectHandle self, graphene_rect_tHandle bounds, graphene_size_tHandle top_left, graphene_size_tHandle top_right, graphene_size_tHandle bottom_right, graphene_size_tHandle bottom_left);

	[DllImport(Libraries.Gsk, EntryPoint = "gsk_rounded_rect_init_copy")]
	internal static extern GskRoundedRectHandle gsk_rounded_rect_init_copy(this GskRoundedRectHandle self, GskRoundedRectHandle src);

	[DllImport(Libraries.Gsk, EntryPoint = "gsk_rounded_rect_init_from_rect")]
	internal static extern GskRoundedRectHandle gsk_rounded_rect_init_from_rect(this GskRoundedRectHandle self, graphene_rect_tHandle bounds, float radius);

	[DllImport(Libraries.Gsk, EntryPoint = "gsk_rounded_rect_normalize")]
	internal static extern GskRoundedRectHandle gsk_rounded_rect_normalize(this GskRoundedRectHandle self);

	[DllImport(Libraries.Gsk, EntryPoint = "gsk_rounded_rect_offset")]
	internal static extern GskRoundedRectHandle gsk_rounded_rect_offset(this GskRoundedRectHandle self, float dx, float dy);

	[DllImport(Libraries.Gsk, EntryPoint = "gsk_rounded_rect_shrink")]
	internal static extern GskRoundedRectHandle gsk_rounded_rect_shrink(this GskRoundedRectHandle self, float top, float right, float bottom, float left);

	[DllImport(Libraries.Gsk, EntryPoint = "gsk_rounded_rect_is_rectilinear")]
	internal static extern int gsk_rounded_rect_is_rectilinear(this GskRoundedRectHandle self);

	[DllImport(Libraries.Gsk, EntryPoint = "gsk_rounded_rect_contains_point")]
	internal static extern int gsk_rounded_rect_contains_point(this GskRoundedRectHandle self, graphene_point_tHandle point);

	[DllImport(Libraries.Gsk, EntryPoint = "gsk_rounded_rect_contains_rect")]
	internal static extern int gsk_rounded_rect_contains_rect(this GskRoundedRectHandle self, graphene_rect_tHandle rect);

	[DllImport(Libraries.Gsk, EntryPoint = "gsk_rounded_rect_intersects_rect")]
	internal static extern int gsk_rounded_rect_intersects_rect(this GskRoundedRectHandle self, graphene_rect_tHandle rect);

	[DllImport(Libraries.Gsk, EntryPoint = "gsk_border_node_new")]
	internal static extern GskRenderNodeHandle gsk_border_node_new(this GskRoundedRectHandle outline, float[] border_width, GdkRGBA border_color);

	[DllImport(Libraries.Gsk, EntryPoint = "gsk_inset_shadow_node_new")]
	internal static extern GskRenderNodeHandle gsk_inset_shadow_node_new(this GskRoundedRectHandle outline, GdkRGBAHandle color, float dx, float dy, float spread, float blur_radius);

	[DllImport(Libraries.Gsk, EntryPoint = "gsk_outset_shadow_node_new")]
	internal static extern GskRenderNodeHandle gsk_outset_shadow_node_new(this GskRoundedRectHandle outline, GdkRGBAHandle color, float dx, float dy, float spread, float blur_radius);
}
