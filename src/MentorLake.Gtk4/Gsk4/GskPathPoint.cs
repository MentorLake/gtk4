namespace MentorLake.Gtk4.Gsk4;

public class GskPathPointHandle : BaseSafeHandle
{
}


public static class GskPathPointHandleExtensions
{
	public static int Compare(this GskPathPointHandle point1, GskPathPointHandle point2)
	{
		return GskPathPointExterns.gsk_path_point_compare(point1, point2);
	}

	public static GskPathPointHandle Copy(this GskPathPointHandle point)
	{
		return GskPathPointExterns.gsk_path_point_copy(point);
	}

	public static bool Equal(this GskPathPointHandle point1, GskPathPointHandle point2)
	{
		return GskPathPointExterns.gsk_path_point_equal(point1, point2);
	}

	public static GskPathPointHandle Free(this GskPathPointHandle point)
	{
		GskPathPointExterns.gsk_path_point_free(point);
		return point;
	}

	public static float GetCurvature(this GskPathPointHandle point, GskPathHandle path, GskPathDirection direction, out graphene_point_t center)
	{
		return GskPathPointExterns.gsk_path_point_get_curvature(point, path, direction, out center);
	}

	public static float GetDistance(this GskPathPointHandle point, GskPathMeasureHandle measure)
	{
		return GskPathPointExterns.gsk_path_point_get_distance(point, measure);
	}

	public static GskPathPointHandle GetPosition(this GskPathPointHandle point, GskPathHandle path, out graphene_point_t position)
	{
		GskPathPointExterns.gsk_path_point_get_position(point, path, out position);
		return point;
	}

	public static float GetRotation(this GskPathPointHandle point, GskPathHandle path, GskPathDirection direction)
	{
		return GskPathPointExterns.gsk_path_point_get_rotation(point, path, direction);
	}

	public static GskPathPointHandle GetTangent(this GskPathPointHandle point, GskPathHandle path, GskPathDirection direction, out graphene_vec2_t tangent)
	{
		GskPathPointExterns.gsk_path_point_get_tangent(point, path, direction, out tangent);
		return point;
	}

}
internal class GskPathPointExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern int gsk_path_point_compare(GskPathPointHandle point1, GskPathPointHandle point2);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskPathPointHandle gsk_path_point_copy(GskPathPointHandle point);

	[DllImport(Libraries.Gsk4)]
	internal static extern bool gsk_path_point_equal(GskPathPointHandle point1, GskPathPointHandle point2);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_path_point_free(GskPathPointHandle point);

	[DllImport(Libraries.Gsk4)]
	internal static extern float gsk_path_point_get_curvature(GskPathPointHandle point, GskPathHandle path, GskPathDirection direction, out graphene_point_t center);

	[DllImport(Libraries.Gsk4)]
	internal static extern float gsk_path_point_get_distance(GskPathPointHandle point, GskPathMeasureHandle measure);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_path_point_get_position(GskPathPointHandle point, GskPathHandle path, out graphene_point_t position);

	[DllImport(Libraries.Gsk4)]
	internal static extern float gsk_path_point_get_rotation(GskPathPointHandle point, GskPathHandle path, GskPathDirection direction);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_path_point_get_tangent(GskPathPointHandle point, GskPathHandle path, GskPathDirection direction, out graphene_vec2_t tangent);

}

public struct GskPathPoint
{
}
