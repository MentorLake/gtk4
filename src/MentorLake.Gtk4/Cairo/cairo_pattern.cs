using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;

public class cairo_pattern_tHandle : BaseSafeHandle { }
public struct cairo_pattern_t { }

public static class cairo_patternAdaptors
{
	public static cairo_pattern_tHandle CairoRasterSourcePatternSetCallbackData(this cairo_pattern_tHandle patternT, IntPtr data)
	{
		cairo_patternExterns.cairo_raster_source_pattern_set_callback_data(patternT, data);
		return patternT;
	}

	public static IntPtr CairoRasterSourcePatternGetCallbackData(this cairo_pattern_tHandle patternT)
	{
		return cairo_patternExterns.cairo_raster_source_pattern_get_callback_data(patternT);
	}

	public static cairo_pattern_tHandle CairoRasterSourcePatternSetAcquire(this cairo_pattern_tHandle patternT, cairo_raster_source_acquire_func_t acquire, cairo_raster_source_release_func_t release)
	{
		cairo_patternExterns.cairo_raster_source_pattern_set_acquire(patternT, acquire, release);
		return patternT;
	}

	public static cairo_pattern_tHandle CairoRasterSourcePatternGetAcquire(this cairo_pattern_tHandle patternT, out cairo_raster_source_acquire_func_t acquire, out cairo_raster_source_release_func_t release)
	{
		cairo_patternExterns.cairo_raster_source_pattern_get_acquire(patternT, out acquire, out release);
		return patternT;
	}

	public static cairo_pattern_tHandle CairoRasterSourcePatternSetSnapshot(this cairo_pattern_tHandle patternT, cairo_raster_source_snapshot_func_t snapshot)
	{
		cairo_patternExterns.cairo_raster_source_pattern_set_snapshot(patternT, snapshot);
		return patternT;
	}

	public static cairo_raster_source_snapshot_func_t CairoRasterSourcePatternGetSnapshot(this cairo_pattern_tHandle patternT)
	{
		return cairo_patternExterns.cairo_raster_source_pattern_get_snapshot(patternT);
	}

	public static cairo_pattern_tHandle CairoRasterSourcePatternSetCopy(this cairo_pattern_tHandle patternT, cairo_raster_source_copy_func_t copy)
	{
		cairo_patternExterns.cairo_raster_source_pattern_set_copy(patternT, copy);
		return patternT;
	}

	public static cairo_raster_source_copy_func_t CairoRasterSourcePatternGetCopy(this cairo_pattern_tHandle patternT)
	{
		return cairo_patternExterns.cairo_raster_source_pattern_get_copy(patternT);
	}

	public static cairo_pattern_tHandle CairoRasterSourcePatternSetFinish(this cairo_pattern_tHandle patternT, cairo_raster_source_finish_func_t finish)
	{
		cairo_patternExterns.cairo_raster_source_pattern_set_finish(patternT, finish);
		return patternT;
	}

	public static cairo_raster_source_finish_func_t CairoRasterSourcePatternGetFinish(this cairo_pattern_tHandle patternT)
	{
		return cairo_patternExterns.cairo_raster_source_pattern_get_finish(patternT);
	}

	public static cairo_pattern_tHandle CairoPatternReference(this cairo_pattern_tHandle patternT)
	{
		return cairo_patternExterns.cairo_pattern_reference(patternT);
	}

	public static cairo_pattern_tHandle CairoPatternDestroy(this cairo_pattern_tHandle patternT)
	{
		cairo_patternExterns.cairo_pattern_destroy(patternT);
		return patternT;
	}

	public static uint CairoPatternGetReferenceCount(this cairo_pattern_tHandle patternT)
	{
		return cairo_patternExterns.cairo_pattern_get_reference_count(patternT);
	}

	public static cairo_status_t CairoPatternStatus(this cairo_pattern_tHandle patternT)
	{
		return cairo_patternExterns.cairo_pattern_status(patternT);
	}

	public static IntPtr CairoPatternGetUserData(this cairo_pattern_tHandle patternT, cairo_user_data_key_tHandle keyT)
	{
		return cairo_patternExterns.cairo_pattern_get_user_data(patternT, keyT);
	}

	public static cairo_status_t CairoPatternSetUserData(this cairo_pattern_tHandle patternT, cairo_user_data_key_tHandle keyT, IntPtr user_data, cairo_destroy_func_t destroy)
	{
		return cairo_patternExterns.cairo_pattern_set_user_data(patternT, keyT, user_data, destroy);
	}

	public static cairo_pattern_type_t CairoPatternGetType(this cairo_pattern_tHandle patternT)
	{
		return cairo_patternExterns.cairo_pattern_get_type(patternT);
	}

	public static cairo_pattern_tHandle CairoPatternAddColorStopRgb(this cairo_pattern_tHandle patternT, double offset, double red, double green, double blue)
	{
		cairo_patternExterns.cairo_pattern_add_color_stop_rgb(patternT, offset, red, green, blue);
		return patternT;
	}

	public static cairo_pattern_tHandle CairoPatternAddColorStopRgba(this cairo_pattern_tHandle patternT, double offset, double red, double green, double blue, double alpha)
	{
		cairo_patternExterns.cairo_pattern_add_color_stop_rgba(patternT, offset, red, green, blue, alpha);
		return patternT;
	}

	public static cairo_pattern_tHandle CairoMeshPatternBeginPatch(this cairo_pattern_tHandle patternT)
	{
		cairo_patternExterns.cairo_mesh_pattern_begin_patch(patternT);
		return patternT;
	}

	public static cairo_pattern_tHandle CairoMeshPatternEndPatch(this cairo_pattern_tHandle patternT)
	{
		cairo_patternExterns.cairo_mesh_pattern_end_patch(patternT);
		return patternT;
	}

	public static cairo_pattern_tHandle CairoMeshPatternCurveTo(this cairo_pattern_tHandle patternT, double x1, double y1, double x2, double y2, double x3, double y3)
	{
		cairo_patternExterns.cairo_mesh_pattern_curve_to(patternT, x1, y1, x2, y2, x3, y3);
		return patternT;
	}

	public static cairo_pattern_tHandle CairoMeshPatternLineTo(this cairo_pattern_tHandle patternT, double x, double y)
	{
		cairo_patternExterns.cairo_mesh_pattern_line_to(patternT, x, y);
		return patternT;
	}

	public static cairo_pattern_tHandle CairoMeshPatternMoveTo(this cairo_pattern_tHandle patternT, double x, double y)
	{
		cairo_patternExterns.cairo_mesh_pattern_move_to(patternT, x, y);
		return patternT;
	}

	public static cairo_pattern_tHandle CairoMeshPatternSetControlPoint(this cairo_pattern_tHandle patternT, uint point_num, double x, double y)
	{
		cairo_patternExterns.cairo_mesh_pattern_set_control_point(patternT, point_num, x, y);
		return patternT;
	}

	public static cairo_pattern_tHandle CairoMeshPatternSetCornerColorRgb(this cairo_pattern_tHandle patternT, uint corner_num, double red, double green, double blue)
	{
		cairo_patternExterns.cairo_mesh_pattern_set_corner_color_rgb(patternT, corner_num, red, green, blue);
		return patternT;
	}

	public static cairo_pattern_tHandle CairoMeshPatternSetCornerColorRgba(this cairo_pattern_tHandle patternT, uint corner_num, double red, double green, double blue, double alpha)
	{
		cairo_patternExterns.cairo_mesh_pattern_set_corner_color_rgba(patternT, corner_num, red, green, blue, alpha);
		return patternT;
	}

	public static cairo_pattern_tHandle CairoPatternSetMatrix(this cairo_pattern_tHandle patternT, cairo_matrix_tHandle matrixT)
	{
		cairo_patternExterns.cairo_pattern_set_matrix(patternT, matrixT);
		return patternT;
	}

	public static cairo_pattern_tHandle CairoPatternGetMatrix(this cairo_pattern_tHandle patternT, cairo_matrix_tHandle matrixT)
	{
		cairo_patternExterns.cairo_pattern_get_matrix(patternT, matrixT);
		return patternT;
	}

	public static cairo_pattern_tHandle CairoPatternSetExtend(this cairo_pattern_tHandle patternT, cairo_extend_t extend)
	{
		cairo_patternExterns.cairo_pattern_set_extend(patternT, extend);
		return patternT;
	}

	public static cairo_extend_t CairoPatternGetExtend(this cairo_pattern_tHandle patternT)
	{
		return cairo_patternExterns.cairo_pattern_get_extend(patternT);
	}

	public static cairo_pattern_tHandle CairoPatternSetFilter(this cairo_pattern_tHandle patternT, cairo_filter_t filter)
	{
		cairo_patternExterns.cairo_pattern_set_filter(patternT, filter);
		return patternT;
	}

	public static cairo_filter_t CairoPatternGetFilter(this cairo_pattern_tHandle patternT)
	{
		return cairo_patternExterns.cairo_pattern_get_filter(patternT);
	}

	public static cairo_status_t CairoPatternGetRgba(this cairo_pattern_tHandle patternT, out double red, out double green, out double blue, out double alpha)
	{
		return cairo_patternExterns.cairo_pattern_get_rgba(patternT, out red, out green, out blue, out alpha);
	}

	public static cairo_status_t CairoPatternGetSurface(this cairo_pattern_tHandle patternT, out cairo_surface_tHandle surfaceT)
	{
		return cairo_patternExterns.cairo_pattern_get_surface(patternT, out surfaceT);
	}

	public static cairo_status_t CairoPatternGetColorStopRgba(this cairo_pattern_tHandle patternT, int index, out double offset, out double red, out double green, out double blue, out double alpha)
	{
		return cairo_patternExterns.cairo_pattern_get_color_stop_rgba(patternT, index, out offset, out red, out green, out blue, out alpha);
	}

	public static cairo_status_t CairoPatternGetColorStopCount(this cairo_pattern_tHandle patternT, out int count)
	{
		return cairo_patternExterns.cairo_pattern_get_color_stop_count(patternT, out count);
	}

	public static cairo_status_t CairoPatternGetLinearPoints(this cairo_pattern_tHandle patternT, out double x0, out double y0, out double x1, out double y1)
	{
		return cairo_patternExterns.cairo_pattern_get_linear_points(patternT, out x0, out y0, out x1, out y1);
	}

	public static cairo_status_t CairoPatternGetRadialCircles(this cairo_pattern_tHandle patternT, out double x0, out double y0, out double r0, out double x1, out double y1, out double r1)
	{
		return cairo_patternExterns.cairo_pattern_get_radial_circles(patternT, out x0, out y0, out r0, out x1, out y1, out r1);
	}

	public static cairo_status_t CairoMeshPatternGetPatchCount(this cairo_pattern_tHandle patternT, out uint count)
	{
		return cairo_patternExterns.cairo_mesh_pattern_get_patch_count(patternT, out count);
	}

	public static cairo_path_tHandle CairoMeshPatternGetPath(this cairo_pattern_tHandle patternT, uint patch_num)
	{
		return cairo_patternExterns.cairo_mesh_pattern_get_path(patternT, patch_num);
	}

	public static cairo_status_t CairoMeshPatternGetCornerColorRgba(this cairo_pattern_tHandle patternT, uint patch_num, uint corner_num, out double red, out double green, out double blue, out double alpha)
	{
		return cairo_patternExterns.cairo_mesh_pattern_get_corner_color_rgba(patternT, patch_num, corner_num, out red, out green, out blue, out alpha);
	}

	public static cairo_status_t CairoMeshPatternGetControlPoint(this cairo_pattern_tHandle patternT, uint patch_num, uint point_num, out double x, out double y)
	{
		return cairo_patternExterns.cairo_mesh_pattern_get_control_point(patternT, patch_num, point_num, out x, out y);
	}
}

public static class cairo_patternExterns
{
	[DllImport(Libraries.Cairo, EntryPoint = "cairo_raster_source_pattern_set_callback_data")]
	internal static extern void cairo_raster_source_pattern_set_callback_data(this cairo_pattern_tHandle patternT, IntPtr data);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_raster_source_pattern_get_callback_data")]
	internal static extern IntPtr cairo_raster_source_pattern_get_callback_data(this cairo_pattern_tHandle patternT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_raster_source_pattern_set_acquire")]
	internal static extern void cairo_raster_source_pattern_set_acquire(this cairo_pattern_tHandle patternT, cairo_raster_source_acquire_func_t acquire, cairo_raster_source_release_func_t release);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_raster_source_pattern_get_acquire")]
	internal static extern void cairo_raster_source_pattern_get_acquire(this cairo_pattern_tHandle patternT, out cairo_raster_source_acquire_func_t acquire, out cairo_raster_source_release_func_t release);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_raster_source_pattern_set_snapshot")]
	internal static extern void cairo_raster_source_pattern_set_snapshot(this cairo_pattern_tHandle patternT, cairo_raster_source_snapshot_func_t snapshot);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_raster_source_pattern_get_snapshot")]
	internal static extern cairo_raster_source_snapshot_func_t cairo_raster_source_pattern_get_snapshot(this cairo_pattern_tHandle patternT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_raster_source_pattern_set_copy")]
	internal static extern void cairo_raster_source_pattern_set_copy(this cairo_pattern_tHandle patternT, cairo_raster_source_copy_func_t copy);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_raster_source_pattern_get_copy")]
	internal static extern cairo_raster_source_copy_func_t cairo_raster_source_pattern_get_copy(this cairo_pattern_tHandle patternT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_raster_source_pattern_set_finish")]
	internal static extern void cairo_raster_source_pattern_set_finish(this cairo_pattern_tHandle patternT, cairo_raster_source_finish_func_t finish);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_raster_source_pattern_get_finish")]
	internal static extern cairo_raster_source_finish_func_t cairo_raster_source_pattern_get_finish(this cairo_pattern_tHandle patternT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_reference")]
	internal static extern cairo_pattern_tHandle cairo_pattern_reference(this cairo_pattern_tHandle patternT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_destroy")]
	internal static extern void cairo_pattern_destroy(this cairo_pattern_tHandle patternT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_get_reference_count")]
	internal static extern uint cairo_pattern_get_reference_count(this cairo_pattern_tHandle patternT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_status")]
	internal static extern cairo_status_t cairo_pattern_status(this cairo_pattern_tHandle patternT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_get_user_data")]
	internal static extern IntPtr cairo_pattern_get_user_data(this cairo_pattern_tHandle patternT, cairo_user_data_key_tHandle keyT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_set_user_data")]
	internal static extern cairo_status_t cairo_pattern_set_user_data(this cairo_pattern_tHandle patternT, cairo_user_data_key_tHandle keyT, IntPtr user_data, cairo_destroy_func_t destroy);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_get_type")]
	internal static extern cairo_pattern_type_t cairo_pattern_get_type(this cairo_pattern_tHandle patternT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_add_color_stop_rgb")]
	internal static extern void cairo_pattern_add_color_stop_rgb(this cairo_pattern_tHandle patternT, double offset, double red, double green, double blue);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_add_color_stop_rgba")]
	internal static extern void cairo_pattern_add_color_stop_rgba(this cairo_pattern_tHandle patternT, double offset, double red, double green, double blue, double alpha);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_mesh_pattern_begin_patch")]
	internal static extern void cairo_mesh_pattern_begin_patch(this cairo_pattern_tHandle patternT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_mesh_pattern_end_patch")]
	internal static extern void cairo_mesh_pattern_end_patch(this cairo_pattern_tHandle patternT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_mesh_pattern_curve_to")]
	internal static extern void cairo_mesh_pattern_curve_to(this cairo_pattern_tHandle patternT, double x1, double y1, double x2, double y2, double x3, double y3);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_mesh_pattern_line_to")]
	internal static extern void cairo_mesh_pattern_line_to(this cairo_pattern_tHandle patternT, double x, double y);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_mesh_pattern_move_to")]
	internal static extern void cairo_mesh_pattern_move_to(this cairo_pattern_tHandle patternT, double x, double y);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_mesh_pattern_set_control_point")]
	internal static extern void cairo_mesh_pattern_set_control_point(this cairo_pattern_tHandle patternT, uint point_num, double x, double y);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_mesh_pattern_set_corner_color_rgb")]
	internal static extern void cairo_mesh_pattern_set_corner_color_rgb(this cairo_pattern_tHandle patternT, uint corner_num, double red, double green, double blue);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_mesh_pattern_set_corner_color_rgba")]
	internal static extern void cairo_mesh_pattern_set_corner_color_rgba(this cairo_pattern_tHandle patternT, uint corner_num, double red, double green, double blue, double alpha);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_set_matrix")]
	internal static extern void cairo_pattern_set_matrix(this cairo_pattern_tHandle patternT, cairo_matrix_tHandle matrixT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_get_matrix")]
	internal static extern void cairo_pattern_get_matrix(this cairo_pattern_tHandle patternT, cairo_matrix_tHandle matrixT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_set_extend")]
	internal static extern void cairo_pattern_set_extend(this cairo_pattern_tHandle patternT, cairo_extend_t extend);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_get_extend")]
	internal static extern cairo_extend_t cairo_pattern_get_extend(this cairo_pattern_tHandle patternT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_set_filter")]
	internal static extern void cairo_pattern_set_filter(this cairo_pattern_tHandle patternT, cairo_filter_t filter);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_get_filter")]
	internal static extern cairo_filter_t cairo_pattern_get_filter(this cairo_pattern_tHandle patternT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_get_rgba")]
	internal static extern cairo_status_t cairo_pattern_get_rgba(this cairo_pattern_tHandle patternT, out double red, out double green, out double blue, out double alpha);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_get_surface")]
	internal static extern cairo_status_t cairo_pattern_get_surface(this cairo_pattern_tHandle patternT, out cairo_surface_tHandle surfaceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_get_color_stop_rgba")]
	internal static extern cairo_status_t cairo_pattern_get_color_stop_rgba(this cairo_pattern_tHandle patternT, int index, out double offset, out double red, out double green, out double blue, out double alpha);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_get_color_stop_count")]
	internal static extern cairo_status_t cairo_pattern_get_color_stop_count(this cairo_pattern_tHandle patternT, out int count);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_get_linear_points")]
	internal static extern cairo_status_t cairo_pattern_get_linear_points(this cairo_pattern_tHandle patternT, out double x0, out double y0, out double x1, out double y1);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_get_radial_circles")]
	internal static extern cairo_status_t cairo_pattern_get_radial_circles(this cairo_pattern_tHandle patternT, out double x0, out double y0, out double r0, out double x1, out double y1, out double r1);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_mesh_pattern_get_patch_count")]
	internal static extern cairo_status_t cairo_mesh_pattern_get_patch_count(this cairo_pattern_tHandle patternT, out uint count);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_mesh_pattern_get_path")]
	internal static extern cairo_path_tHandle cairo_mesh_pattern_get_path(this cairo_pattern_tHandle patternT, uint patch_num);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_mesh_pattern_get_corner_color_rgba")]
	internal static extern cairo_status_t cairo_mesh_pattern_get_corner_color_rgba(this cairo_pattern_tHandle patternT, uint patch_num, uint corner_num, out double red, out double green, out double blue, out double alpha);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_mesh_pattern_get_control_point")]
	internal static extern cairo_status_t cairo_mesh_pattern_get_control_point(this cairo_pattern_tHandle patternT, uint patch_num, uint point_num, out double x, out double y);
}
