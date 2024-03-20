using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;

public static class Methods
{
	[DllImport(Libraries.Cairo, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int cairo_version();

	[DllImport(Libraries.Cairo, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string cairo_version_string();

	[DllImport(Libraries.Cairo, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern cairo_glyph_t[] cairo_glyph_allocate(int num_glyphs);

	[DllImport(Libraries.Cairo, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern cairo_text_cluster_t[] cairo_text_cluster_allocate(int num_clusters);

	[DllImport(Libraries.Cairo, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void cairo_text_cluster_free(cairo_text_cluster_t[] clusters);

	[DllImport(Libraries.Cairo, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern cairo_font_optionsHandle cairo_font_options_create();

	[DllImport(Libraries.Cairo, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern cairo_font_faceHandle cairo_toy_font_face_create(string family, _cairo_font_slant slant, _cairo_font_weight weight);

	[DllImport(Libraries.Cairo, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern cairo_font_faceHandle cairo_user_font_face_create();

	[DllImport(Libraries.Cairo, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string cairo_status_to_string(_cairo_status status);

	[DllImport(Libraries.Cairo, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern cairo_surfaceHandle cairo_image_surface_create(_cairo_format format, int width, int height);

	[DllImport(Libraries.Cairo, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int cairo_format_stride_for_width(_cairo_format format, int width);

	[DllImport(Libraries.Cairo, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern cairo_surfaceHandle cairo_image_surface_create_for_data(byte[] data, _cairo_format format, int width, int height, int stride);

	[DllImport(Libraries.Cairo, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern cairo_surfaceHandle cairo_image_surface_create_from_png(string filename);

	[DllImport(Libraries.Cairo, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern cairo_surfaceHandle cairo_image_surface_create_from_png_stream(cairo_read_func_t read_func, IntPtr closure);

	[DllImport(Libraries.Cairo, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern cairo_surfaceHandle cairo_recording_surface_create(_cairo_content content, cairo_rectangleHandle extents);

	[DllImport(Libraries.Cairo, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern cairo_patternHandle cairo_pattern_create_raster_source(IntPtr user_data, _cairo_content content, int width, int height);

	[DllImport(Libraries.Cairo, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern cairo_patternHandle cairo_pattern_create_rgb(double red, double green, double blue);

	[DllImport(Libraries.Cairo, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern cairo_patternHandle cairo_pattern_create_rgba(double red, double green, double blue, double alpha);

	[DllImport(Libraries.Cairo, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern cairo_patternHandle cairo_pattern_create_linear(double x0, double y0, double x1, double y1);

	[DllImport(Libraries.Cairo, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern cairo_patternHandle cairo_pattern_create_radial(double cx0, double cy0, double radius0, double cx1, double cy1, double radius1);

	[DllImport(Libraries.Cairo, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern cairo_patternHandle cairo_pattern_create_mesh();

	[DllImport(Libraries.Cairo, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern cairo_regionHandle cairo_region_create();

	[DllImport(Libraries.Cairo, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void cairo_debug_reset_static_data();
}
