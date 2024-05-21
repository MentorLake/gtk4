namespace MentorLake.Gtk4.Gsk4;

public class GskRoundedRectHandle : BaseSafeHandle
{
}


public static class GskRoundedRectHandleExtensions
{
	public static bool ContainsPoint(this GskRoundedRectHandle self, graphene_point_tHandle point)
	{
		return GskRoundedRectExterns.gsk_rounded_rect_contains_point(self, point);
	}

	public static bool ContainsRect(this GskRoundedRectHandle self, graphene_rect_tHandle rect)
	{
		return GskRoundedRectExterns.gsk_rounded_rect_contains_rect(self, rect);
	}

	public static GskRoundedRectHandle Init(this GskRoundedRectHandle self, graphene_rect_tHandle bounds, graphene_size_tHandle top_left, graphene_size_tHandle top_right, graphene_size_tHandle bottom_right, graphene_size_tHandle bottom_left)
	{
		return GskRoundedRectExterns.gsk_rounded_rect_init(self, bounds, top_left, top_right, bottom_right, bottom_left);
	}

	public static GskRoundedRectHandle InitCopy(this GskRoundedRectHandle self, GskRoundedRectHandle src)
	{
		return GskRoundedRectExterns.gsk_rounded_rect_init_copy(self, src);
	}

	public static GskRoundedRectHandle InitFromRect(this GskRoundedRectHandle self, graphene_rect_tHandle bounds, float radius)
	{
		return GskRoundedRectExterns.gsk_rounded_rect_init_from_rect(self, bounds, radius);
	}

	public static bool IntersectsRect(this GskRoundedRectHandle self, graphene_rect_tHandle rect)
	{
		return GskRoundedRectExterns.gsk_rounded_rect_intersects_rect(self, rect);
	}

	public static bool IsRectilinear(this GskRoundedRectHandle self)
	{
		return GskRoundedRectExterns.gsk_rounded_rect_is_rectilinear(self);
	}

	public static GskRoundedRectHandle Normalize(this GskRoundedRectHandle self)
	{
		return GskRoundedRectExterns.gsk_rounded_rect_normalize(self);
	}

	public static GskRoundedRectHandle Offset(this GskRoundedRectHandle self, float dx, float dy)
	{
		return GskRoundedRectExterns.gsk_rounded_rect_offset(self, dx, dy);
	}

	public static GskRoundedRectHandle Shrink(this GskRoundedRectHandle self, float top, float right, float bottom, float left)
	{
		return GskRoundedRectExterns.gsk_rounded_rect_shrink(self, top, right, bottom, left);
	}

}
internal class GskRoundedRectExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern bool gsk_rounded_rect_contains_point(GskRoundedRectHandle self, graphene_point_tHandle point);

	[DllImport(Libraries.Gsk4)]
	internal static extern bool gsk_rounded_rect_contains_rect(GskRoundedRectHandle self, graphene_rect_tHandle rect);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskRoundedRectHandle gsk_rounded_rect_init(GskRoundedRectHandle self, graphene_rect_tHandle bounds, graphene_size_tHandle top_left, graphene_size_tHandle top_right, graphene_size_tHandle bottom_right, graphene_size_tHandle bottom_left);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskRoundedRectHandle gsk_rounded_rect_init_copy(GskRoundedRectHandle self, GskRoundedRectHandle src);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskRoundedRectHandle gsk_rounded_rect_init_from_rect(GskRoundedRectHandle self, graphene_rect_tHandle bounds, float radius);

	[DllImport(Libraries.Gsk4)]
	internal static extern bool gsk_rounded_rect_intersects_rect(GskRoundedRectHandle self, graphene_rect_tHandle rect);

	[DllImport(Libraries.Gsk4)]
	internal static extern bool gsk_rounded_rect_is_rectilinear(GskRoundedRectHandle self);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskRoundedRectHandle gsk_rounded_rect_normalize(GskRoundedRectHandle self);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskRoundedRectHandle gsk_rounded_rect_offset(GskRoundedRectHandle self, float dx, float dy);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskRoundedRectHandle gsk_rounded_rect_shrink(GskRoundedRectHandle self, float top, float right, float bottom, float left);

}

public struct GskRoundedRect
{
	public graphene_rect_t bounds;
	public None corner;
}
