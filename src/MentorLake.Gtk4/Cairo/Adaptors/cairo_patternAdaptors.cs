using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;
public static class cairo_patternAdaptors
{
    public static cairo_patternHandle CairoRasterSourcePatternSetCallbackData(this cairo_patternHandle pattern, IntPtr data)
    {
        cairo_patternExterns.cairo_raster_source_pattern_set_callback_data(pattern, data);
        return pattern;
    }

    public static IntPtr CairoRasterSourcePatternGetCallbackData(this cairo_patternHandle pattern)
    {
        return cairo_patternExterns.cairo_raster_source_pattern_get_callback_data(pattern);
    }

    public static cairo_patternHandle CairoRasterSourcePatternSetAcquire(this cairo_patternHandle pattern, cairo_raster_source_acquire_func_t acquire, cairo_raster_source_release_func_t release)
    {
        cairo_patternExterns.cairo_raster_source_pattern_set_acquire(pattern, acquire, release);
        return pattern;
    }

    public static cairo_patternHandle CairoRasterSourcePatternGetAcquire(this cairo_patternHandle pattern, out cairo_raster_source_acquire_func_t acquire, out cairo_raster_source_release_func_t release)
    {
        cairo_patternExterns.cairo_raster_source_pattern_get_acquire(pattern, out acquire, out release);
        return pattern;
    }

    public static cairo_patternHandle CairoRasterSourcePatternSetSnapshot(this cairo_patternHandle pattern, cairo_raster_source_snapshot_func_t snapshot)
    {
        cairo_patternExterns.cairo_raster_source_pattern_set_snapshot(pattern, snapshot);
        return pattern;
    }

    public static cairo_raster_source_snapshot_func_t CairoRasterSourcePatternGetSnapshot(this cairo_patternHandle pattern)
    {
        return cairo_patternExterns.cairo_raster_source_pattern_get_snapshot(pattern);
    }

    public static cairo_patternHandle CairoRasterSourcePatternSetCopy(this cairo_patternHandle pattern, cairo_raster_source_copy_func_t copy)
    {
        cairo_patternExterns.cairo_raster_source_pattern_set_copy(pattern, copy);
        return pattern;
    }

    public static cairo_raster_source_copy_func_t CairoRasterSourcePatternGetCopy(this cairo_patternHandle pattern)
    {
        return cairo_patternExterns.cairo_raster_source_pattern_get_copy(pattern);
    }

    public static cairo_patternHandle CairoRasterSourcePatternSetFinish(this cairo_patternHandle pattern, cairo_raster_source_finish_func_t finish)
    {
        cairo_patternExterns.cairo_raster_source_pattern_set_finish(pattern, finish);
        return pattern;
    }

    public static cairo_raster_source_finish_func_t CairoRasterSourcePatternGetFinish(this cairo_patternHandle pattern)
    {
        return cairo_patternExterns.cairo_raster_source_pattern_get_finish(pattern);
    }

    public static cairo_patternHandle CairoPatternReference(this cairo_patternHandle pattern)
    {
        return cairo_patternExterns.cairo_pattern_reference(pattern);
    }

    public static cairo_patternHandle CairoPatternDestroy(this cairo_patternHandle pattern)
    {
        cairo_patternExterns.cairo_pattern_destroy(pattern);
        return pattern;
    }

    public static uint CairoPatternGetReferenceCount(this cairo_patternHandle pattern)
    {
        return cairo_patternExterns.cairo_pattern_get_reference_count(pattern);
    }

    public static _cairo_status CairoPatternStatus(this cairo_patternHandle pattern)
    {
        return cairo_patternExterns.cairo_pattern_status(pattern);
    }

    public static IntPtr CairoPatternGetUserData(this cairo_patternHandle pattern, cairo_user_data_keyHandle key)
    {
        return cairo_patternExterns.cairo_pattern_get_user_data(pattern, key);
    }

    public static _cairo_status CairoPatternSetUserData(this cairo_patternHandle pattern, cairo_user_data_keyHandle key, IntPtr user_data, cairo_destroy_func_t destroy)
    {
        return cairo_patternExterns.cairo_pattern_set_user_data(pattern, key, user_data, destroy);
    }

    public static _cairo_pattern_type CairoPatternGetType(this cairo_patternHandle pattern)
    {
        return cairo_patternExterns.cairo_pattern_get_type(pattern);
    }

    public static cairo_patternHandle CairoPatternAddColorStopRgb(this cairo_patternHandle pattern, double offset, double red, double green, double blue)
    {
        cairo_patternExterns.cairo_pattern_add_color_stop_rgb(pattern, offset, red, green, blue);
        return pattern;
    }

    public static cairo_patternHandle CairoPatternAddColorStopRgba(this cairo_patternHandle pattern, double offset, double red, double green, double blue, double alpha)
    {
        cairo_patternExterns.cairo_pattern_add_color_stop_rgba(pattern, offset, red, green, blue, alpha);
        return pattern;
    }

    public static cairo_patternHandle CairoMeshPatternBeginPatch(this cairo_patternHandle pattern)
    {
        cairo_patternExterns.cairo_mesh_pattern_begin_patch(pattern);
        return pattern;
    }

    public static cairo_patternHandle CairoMeshPatternEndPatch(this cairo_patternHandle pattern)
    {
        cairo_patternExterns.cairo_mesh_pattern_end_patch(pattern);
        return pattern;
    }

    public static cairo_patternHandle CairoMeshPatternCurveTo(this cairo_patternHandle pattern, double x1, double y1, double x2, double y2, double x3, double y3)
    {
        cairo_patternExterns.cairo_mesh_pattern_curve_to(pattern, x1, y1, x2, y2, x3, y3);
        return pattern;
    }

    public static cairo_patternHandle CairoMeshPatternLineTo(this cairo_patternHandle pattern, double x, double y)
    {
        cairo_patternExterns.cairo_mesh_pattern_line_to(pattern, x, y);
        return pattern;
    }

    public static cairo_patternHandle CairoMeshPatternMoveTo(this cairo_patternHandle pattern, double x, double y)
    {
        cairo_patternExterns.cairo_mesh_pattern_move_to(pattern, x, y);
        return pattern;
    }

    public static cairo_patternHandle CairoMeshPatternSetControlPoint(this cairo_patternHandle pattern, uint point_num, double x, double y)
    {
        cairo_patternExterns.cairo_mesh_pattern_set_control_point(pattern, point_num, x, y);
        return pattern;
    }

    public static cairo_patternHandle CairoMeshPatternSetCornerColorRgb(this cairo_patternHandle pattern, uint corner_num, double red, double green, double blue)
    {
        cairo_patternExterns.cairo_mesh_pattern_set_corner_color_rgb(pattern, corner_num, red, green, blue);
        return pattern;
    }

    public static cairo_patternHandle CairoMeshPatternSetCornerColorRgba(this cairo_patternHandle pattern, uint corner_num, double red, double green, double blue, double alpha)
    {
        cairo_patternExterns.cairo_mesh_pattern_set_corner_color_rgba(pattern, corner_num, red, green, blue, alpha);
        return pattern;
    }

    public static cairo_patternHandle CairoPatternSetMatrix(this cairo_patternHandle pattern, cairo_matrixHandle matrix)
    {
        cairo_patternExterns.cairo_pattern_set_matrix(pattern, matrix);
        return pattern;
    }

    public static cairo_patternHandle CairoPatternGetMatrix(this cairo_patternHandle pattern, cairo_matrixHandle matrix)
    {
        cairo_patternExterns.cairo_pattern_get_matrix(pattern, matrix);
        return pattern;
    }

    public static cairo_patternHandle CairoPatternSetExtend(this cairo_patternHandle pattern, _cairo_extend extend)
    {
        cairo_patternExterns.cairo_pattern_set_extend(pattern, extend);
        return pattern;
    }

    public static _cairo_extend CairoPatternGetExtend(this cairo_patternHandle pattern)
    {
        return cairo_patternExterns.cairo_pattern_get_extend(pattern);
    }

    public static cairo_patternHandle CairoPatternSetFilter(this cairo_patternHandle pattern, _cairo_filter filter)
    {
        cairo_patternExterns.cairo_pattern_set_filter(pattern, filter);
        return pattern;
    }

    public static _cairo_filter CairoPatternGetFilter(this cairo_patternHandle pattern)
    {
        return cairo_patternExterns.cairo_pattern_get_filter(pattern);
    }

    public static _cairo_status CairoPatternGetRgba(this cairo_patternHandle pattern, out double red, out double green, out double blue, out double alpha)
    {
        return cairo_patternExterns.cairo_pattern_get_rgba(pattern, out red, out green, out blue, out alpha);
    }

    public static _cairo_status CairoPatternGetSurface(this cairo_patternHandle pattern, out cairo_surfaceHandle surface)
    {
        return cairo_patternExterns.cairo_pattern_get_surface(pattern, out surface);
    }

    public static _cairo_status CairoPatternGetColorStopRgba(this cairo_patternHandle pattern, int index, out double offset, out double red, out double green, out double blue, out double alpha)
    {
        return cairo_patternExterns.cairo_pattern_get_color_stop_rgba(pattern, index, out offset, out red, out green, out blue, out alpha);
    }

    public static _cairo_status CairoPatternGetColorStopCount(this cairo_patternHandle pattern, out int count)
    {
        return cairo_patternExterns.cairo_pattern_get_color_stop_count(pattern, out count);
    }

    public static _cairo_status CairoPatternGetLinearPoints(this cairo_patternHandle pattern, out double x0, out double y0, out double x1, out double y1)
    {
        return cairo_patternExterns.cairo_pattern_get_linear_points(pattern, out x0, out y0, out x1, out y1);
    }

    public static _cairo_status CairoPatternGetRadialCircles(this cairo_patternHandle pattern, out double x0, out double y0, out double r0, out double x1, out double y1, out double r1)
    {
        return cairo_patternExterns.cairo_pattern_get_radial_circles(pattern, out x0, out y0, out r0, out x1, out y1, out r1);
    }

    public static _cairo_status CairoMeshPatternGetPatchCount(this cairo_patternHandle pattern, out uint count)
    {
        return cairo_patternExterns.cairo_mesh_pattern_get_patch_count(pattern, out count);
    }

    public static cairo_pathHandle CairoMeshPatternGetPath(this cairo_patternHandle pattern, uint patch_num)
    {
        return cairo_patternExterns.cairo_mesh_pattern_get_path(pattern, patch_num);
    }

    public static _cairo_status CairoMeshPatternGetCornerColorRgba(this cairo_patternHandle pattern, uint patch_num, uint corner_num, out double red, out double green, out double blue, out double alpha)
    {
        return cairo_patternExterns.cairo_mesh_pattern_get_corner_color_rgba(pattern, patch_num, corner_num, out red, out green, out blue, out alpha);
    }

    public static _cairo_status CairoMeshPatternGetControlPoint(this cairo_patternHandle pattern, uint patch_num, uint point_num, out double x, out double y)
    {
        return cairo_patternExterns.cairo_mesh_pattern_get_control_point(pattern, patch_num, point_num, out x, out y);
    }
}
