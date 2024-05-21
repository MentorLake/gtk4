namespace MentorLake.Gtk4.Gsk4;

public class GskPathMeasureHandle : BaseSafeHandle
{
	public static GskPathMeasureHandle New(GskPathHandle path)
	{
		return GskPathMeasureExterns.gsk_path_measure_new(path);
	}

	public static GskPathMeasureHandle NewWithTolerance(GskPathHandle path, float tolerance)
	{
		return GskPathMeasureExterns.gsk_path_measure_new_with_tolerance(path, tolerance);
	}

}


public static class GskPathMeasureHandleExtensions
{
	public static float GetLength(this GskPathMeasureHandle self)
	{
		return GskPathMeasureExterns.gsk_path_measure_get_length(self);
	}

	public static GskPathHandle GetPath(this GskPathMeasureHandle self)
	{
		return GskPathMeasureExterns.gsk_path_measure_get_path(self);
	}

	public static bool GetPoint(this GskPathMeasureHandle self, float distance, out GskPathPoint result)
	{
		return GskPathMeasureExterns.gsk_path_measure_get_point(self, distance, out result);
	}

	public static float GetTolerance(this GskPathMeasureHandle self)
	{
		return GskPathMeasureExterns.gsk_path_measure_get_tolerance(self);
	}

	public static GskPathMeasureHandle Ref(this GskPathMeasureHandle self)
	{
		return GskPathMeasureExterns.gsk_path_measure_ref(self);
	}

	public static GskPathMeasureHandle Unref(this GskPathMeasureHandle self)
	{
		GskPathMeasureExterns.gsk_path_measure_unref(self);
		return self;
	}

}
internal class GskPathMeasureExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskPathMeasureHandle gsk_path_measure_new(GskPathHandle path);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskPathMeasureHandle gsk_path_measure_new_with_tolerance(GskPathHandle path, float tolerance);

	[DllImport(Libraries.Gsk4)]
	internal static extern float gsk_path_measure_get_length(GskPathMeasureHandle self);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskPathHandle gsk_path_measure_get_path(GskPathMeasureHandle self);

	[DllImport(Libraries.Gsk4)]
	internal static extern bool gsk_path_measure_get_point(GskPathMeasureHandle self, float distance, out GskPathPoint result);

	[DllImport(Libraries.Gsk4)]
	internal static extern float gsk_path_measure_get_tolerance(GskPathMeasureHandle self);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskPathMeasureHandle gsk_path_measure_ref(GskPathMeasureHandle self);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_path_measure_unref(GskPathMeasureHandle self);

}

public struct GskPathMeasure
{
}
