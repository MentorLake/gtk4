using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;

public static class cairo_patternExterns
{
	[DllImport(Libraries.Cairo, EntryPoint = "cairo_raster_source_pattern_set_callback_data")]
	internal static extern void cairo_raster_source_pattern_set_callback_data(this cairo_patternHandle pattern, IntPtr data);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_raster_source_pattern_get_callback_data")]
	internal static extern IntPtr cairo_raster_source_pattern_get_callback_data(this cairo_patternHandle pattern);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_raster_source_pattern_set_acquire")]
	internal static extern void cairo_raster_source_pattern_set_acquire(this cairo_patternHandle pattern, cairo_raster_source_acquire_func_t acquire, cairo_raster_source_release_func_t release);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_raster_source_pattern_get_acquire")]
	internal static extern void cairo_raster_source_pattern_get_acquire(this cairo_patternHandle pattern, out cairo_raster_source_acquire_func_t acquire, out cairo_raster_source_release_func_t release);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_raster_source_pattern_set_snapshot")]
	internal static extern void cairo_raster_source_pattern_set_snapshot(this cairo_patternHandle pattern, cairo_raster_source_snapshot_func_t snapshot);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_raster_source_pattern_get_snapshot")]
	internal static extern cairo_raster_source_snapshot_func_t cairo_raster_source_pattern_get_snapshot(this cairo_patternHandle pattern);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_raster_source_pattern_set_copy")]
	internal static extern void cairo_raster_source_pattern_set_copy(this cairo_patternHandle pattern, cairo_raster_source_copy_func_t copy);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_raster_source_pattern_get_copy")]
	internal static extern cairo_raster_source_copy_func_t cairo_raster_source_pattern_get_copy(this cairo_patternHandle pattern);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_raster_source_pattern_set_finish")]
	internal static extern void cairo_raster_source_pattern_set_finish(this cairo_patternHandle pattern, cairo_raster_source_finish_func_t finish);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_raster_source_pattern_get_finish")]
	internal static extern cairo_raster_source_finish_func_t cairo_raster_source_pattern_get_finish(this cairo_patternHandle pattern);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_reference")]
	internal static extern cairo_patternHandle cairo_pattern_reference(this cairo_patternHandle pattern);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_destroy")]
	internal static extern void cairo_pattern_destroy(this cairo_patternHandle pattern);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_get_reference_count")]
	internal static extern uint cairo_pattern_get_reference_count(this cairo_patternHandle pattern);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_status")]
	internal static extern _cairo_status cairo_pattern_status(this cairo_patternHandle pattern);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_get_user_data")]
	internal static extern IntPtr cairo_pattern_get_user_data(this cairo_patternHandle pattern, cairo_user_data_keyHandle key);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_set_user_data")]
	internal static extern _cairo_status cairo_pattern_set_user_data(this cairo_patternHandle pattern, cairo_user_data_keyHandle key, IntPtr user_data, cairo_destroy_func_t destroy);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_get_type")]
	internal static extern _cairo_pattern_type cairo_pattern_get_type(this cairo_patternHandle pattern);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_add_color_stop_rgb")]
	internal static extern void cairo_pattern_add_color_stop_rgb(this cairo_patternHandle pattern, double offset, double red, double green, double blue);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_add_color_stop_rgba")]
	internal static extern void cairo_pattern_add_color_stop_rgba(this cairo_patternHandle pattern, double offset, double red, double green, double blue, double alpha);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_mesh_pattern_begin_patch")]
	internal static extern void cairo_mesh_pattern_begin_patch(this cairo_patternHandle pattern);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_mesh_pattern_end_patch")]
	internal static extern void cairo_mesh_pattern_end_patch(this cairo_patternHandle pattern);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_mesh_pattern_curve_to")]
	internal static extern void cairo_mesh_pattern_curve_to(this cairo_patternHandle pattern, double x1, double y1, double x2, double y2, double x3, double y3);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_mesh_pattern_line_to")]
	internal static extern void cairo_mesh_pattern_line_to(this cairo_patternHandle pattern, double x, double y);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_mesh_pattern_move_to")]
	internal static extern void cairo_mesh_pattern_move_to(this cairo_patternHandle pattern, double x, double y);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_mesh_pattern_set_control_point")]
	internal static extern void cairo_mesh_pattern_set_control_point(this cairo_patternHandle pattern, uint point_num, double x, double y);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_mesh_pattern_set_corner_color_rgb")]
	internal static extern void cairo_mesh_pattern_set_corner_color_rgb(this cairo_patternHandle pattern, uint corner_num, double red, double green, double blue);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_mesh_pattern_set_corner_color_rgba")]
	internal static extern void cairo_mesh_pattern_set_corner_color_rgba(this cairo_patternHandle pattern, uint corner_num, double red, double green, double blue, double alpha);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_set_matrix")]
	internal static extern void cairo_pattern_set_matrix(this cairo_patternHandle pattern, cairo_matrixHandle matrix);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_get_matrix")]
	internal static extern void cairo_pattern_get_matrix(this cairo_patternHandle pattern, cairo_matrixHandle matrix);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_set_extend")]
	internal static extern void cairo_pattern_set_extend(this cairo_patternHandle pattern, _cairo_extend extend);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_get_extend")]
	internal static extern _cairo_extend cairo_pattern_get_extend(this cairo_patternHandle pattern);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_set_filter")]
	internal static extern void cairo_pattern_set_filter(this cairo_patternHandle pattern, _cairo_filter filter);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_get_filter")]
	internal static extern _cairo_filter cairo_pattern_get_filter(this cairo_patternHandle pattern);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_get_rgba")]
	internal static extern _cairo_status cairo_pattern_get_rgba(this cairo_patternHandle pattern, out double red, out double green, out double blue, out double alpha);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_get_surface")]
	internal static extern _cairo_status cairo_pattern_get_surface(this cairo_patternHandle pattern, out cairo_surfaceHandle surface);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_get_color_stop_rgba")]
	internal static extern _cairo_status cairo_pattern_get_color_stop_rgba(this cairo_patternHandle pattern, int index, out double offset, out double red, out double green, out double blue, out double alpha);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_get_color_stop_count")]
	internal static extern _cairo_status cairo_pattern_get_color_stop_count(this cairo_patternHandle pattern, out int count);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_get_linear_points")]
	internal static extern _cairo_status cairo_pattern_get_linear_points(this cairo_patternHandle pattern, out double x0, out double y0, out double x1, out double y1);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_get_radial_circles")]
	internal static extern _cairo_status cairo_pattern_get_radial_circles(this cairo_patternHandle pattern, out double x0, out double y0, out double r0, out double x1, out double y1, out double r1);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_mesh_pattern_get_patch_count")]
	internal static extern _cairo_status cairo_mesh_pattern_get_patch_count(this cairo_patternHandle pattern, out uint count);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_mesh_pattern_get_path")]
	internal static extern cairo_pathHandle cairo_mesh_pattern_get_path(this cairo_patternHandle pattern, uint patch_num);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_mesh_pattern_get_corner_color_rgba")]
	internal static extern _cairo_status cairo_mesh_pattern_get_corner_color_rgba(this cairo_patternHandle pattern, uint patch_num, uint corner_num, out double red, out double green, out double blue, out double alpha);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_mesh_pattern_get_control_point")]
	internal static extern _cairo_status cairo_mesh_pattern_get_control_point(this cairo_patternHandle pattern, uint patch_num, uint point_num, out double x, out double y);
}
