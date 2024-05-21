namespace MentorLake.Gtk4.Gsk4;

public class GskPathHandle : BaseSafeHandle
{
}


public static class GskPathHandleExtensions
{
	public static bool Foreach(this GskPathHandle self, GskPathForeachFlags flags, GskPathForeachFunc func, IntPtr user_data)
	{
		return GskPathExterns.gsk_path_foreach(self, flags, func, user_data);
	}

	public static bool GetBounds(this GskPathHandle self, out graphene_rect_t bounds)
	{
		return GskPathExterns.gsk_path_get_bounds(self, out bounds);
	}

	public static bool GetClosestPoint(this GskPathHandle self, graphene_point_tHandle point, float threshold, out GskPathPoint result, out float distance)
	{
		return GskPathExterns.gsk_path_get_closest_point(self, point, threshold, out result, out distance);
	}

	public static bool GetEndPoint(this GskPathHandle self, out GskPathPoint result)
	{
		return GskPathExterns.gsk_path_get_end_point(self, out result);
	}

	public static bool GetStartPoint(this GskPathHandle self, out GskPathPoint result)
	{
		return GskPathExterns.gsk_path_get_start_point(self, out result);
	}

	public static bool GetStrokeBounds(this GskPathHandle self, GskStrokeHandle stroke, out graphene_rect_t bounds)
	{
		return GskPathExterns.gsk_path_get_stroke_bounds(self, stroke, out bounds);
	}

	public static bool InFill(this GskPathHandle self, graphene_point_tHandle point, GskFillRule fill_rule)
	{
		return GskPathExterns.gsk_path_in_fill(self, point, fill_rule);
	}

	public static bool IsClosed(this GskPathHandle self)
	{
		return GskPathExterns.gsk_path_is_closed(self);
	}

	public static bool IsEmpty(this GskPathHandle self)
	{
		return GskPathExterns.gsk_path_is_empty(self);
	}

	public static GskPathHandle Print(this GskPathHandle self, GStringHandle @string)
	{
		GskPathExterns.gsk_path_print(self, @string);
		return self;
	}

	public static GskPathHandle Ref(this GskPathHandle self)
	{
		return GskPathExterns.gsk_path_ref(self);
	}

	public static GskPathHandle ToCairo(this GskPathHandle self, cairo_tHandle cr)
	{
		GskPathExterns.gsk_path_to_cairo(self, cr);
		return self;
	}

	public static string ToString(this GskPathHandle self)
	{
		return GskPathExterns.gsk_path_to_string(self);
	}

	public static GskPathHandle Unref(this GskPathHandle self)
	{
		GskPathExterns.gsk_path_unref(self);
		return self;
	}

}
internal class GskPathExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern bool gsk_path_foreach(GskPathHandle self, GskPathForeachFlags flags, GskPathForeachFunc func, IntPtr user_data);

	[DllImport(Libraries.Gsk4)]
	internal static extern bool gsk_path_get_bounds(GskPathHandle self, out graphene_rect_t bounds);

	[DllImport(Libraries.Gsk4)]
	internal static extern bool gsk_path_get_closest_point(GskPathHandle self, graphene_point_tHandle point, float threshold, out GskPathPoint result, out float distance);

	[DllImport(Libraries.Gsk4)]
	internal static extern bool gsk_path_get_end_point(GskPathHandle self, out GskPathPoint result);

	[DllImport(Libraries.Gsk4)]
	internal static extern bool gsk_path_get_start_point(GskPathHandle self, out GskPathPoint result);

	[DllImport(Libraries.Gsk4)]
	internal static extern bool gsk_path_get_stroke_bounds(GskPathHandle self, GskStrokeHandle stroke, out graphene_rect_t bounds);

	[DllImport(Libraries.Gsk4)]
	internal static extern bool gsk_path_in_fill(GskPathHandle self, graphene_point_tHandle point, GskFillRule fill_rule);

	[DllImport(Libraries.Gsk4)]
	internal static extern bool gsk_path_is_closed(GskPathHandle self);

	[DllImport(Libraries.Gsk4)]
	internal static extern bool gsk_path_is_empty(GskPathHandle self);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_path_print(GskPathHandle self, GStringHandle @string);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskPathHandle gsk_path_ref(GskPathHandle self);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_path_to_cairo(GskPathHandle self, cairo_tHandle cr);

	[DllImport(Libraries.Gsk4)]
	internal static extern string gsk_path_to_string(GskPathHandle self);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_path_unref(GskPathHandle self);

}

public struct GskPath
{
}
