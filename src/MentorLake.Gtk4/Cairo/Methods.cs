using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;

public static class Methods
{
	[DllImport(Libraries.Cairo)]
	public static extern int cairo_version();

	[DllImport(Libraries.Cairo)]
	public static extern string cairo_version_string();

	[DllImport(Libraries.Cairo)]
	public static extern cairo_glyph_t[] cairo_glyph_allocate(int num_glyphs);

	[DllImport(Libraries.Cairo)]
	public static extern cairo_text_cluster_t[] cairo_text_cluster_allocate(int num_clusters);

	[DllImport(Libraries.Cairo)]
	public static extern void cairo_text_cluster_free(cairo_text_cluster_t[] clusters);

	[DllImport(Libraries.Cairo)]
	public static extern cairo_font_options_tHandle cairo_font_options_create();

	[DllImport(Libraries.Cairo)]
	public static extern cairo_font_face_tHandle cairo_toy_font_face_create(string family, cairo_font_slant_t slant, cairo_font_weight_t weight);

	[DllImport(Libraries.Cairo)]
	public static extern cairo_font_face_tHandle cairo_user_font_face_create();

	[DllImport(Libraries.Cairo)]
	public static extern string cairo_status_to_string(cairo_status_t status);

	[DllImport(Libraries.Cairo)]
	public static extern cairo_surface_tHandle cairo_image_surface_create(cairo_format_t format, int width, int height);

	[DllImport(Libraries.Cairo)]
	public static extern int cairo_format_stride_for_width(cairo_format_t format, int width);

	[DllImport(Libraries.Cairo)]
	public static extern cairo_surface_tHandle cairo_image_surface_create_for_data(byte[] data, cairo_format_t format, int width, int height, int stride);

	[DllImport(Libraries.Cairo)]
	public static extern cairo_surface_tHandle cairo_image_surface_create_from_png(string filename);

	[DllImport(Libraries.Cairo)]
	public static extern cairo_surface_tHandle cairo_image_surface_create_from_png_stream(cairo_read_func_t read_func, IntPtr closure);

	[DllImport(Libraries.Cairo)]
	public static extern cairo_surface_tHandle cairo_recording_surface_create(cairo_content_t contentT, cairo_rectangle_tHandle extents);

	[DllImport(Libraries.Cairo)]
	public static extern cairo_pattern_tHandle cairo_pattern_create_raster_source(IntPtr user_data, cairo_content_t contentT, int width, int height);

	[DllImport(Libraries.Cairo)]
	public static extern cairo_pattern_tHandle cairo_pattern_create_rgb(double red, double green, double blue);

	[DllImport(Libraries.Cairo)]
	public static extern cairo_pattern_tHandle cairo_pattern_create_rgba(double red, double green, double blue, double alpha);

	[DllImport(Libraries.Cairo)]
	public static extern cairo_pattern_tHandle cairo_pattern_create_linear(double x0, double y0, double x1, double y1);

	[DllImport(Libraries.Cairo)]
	public static extern cairo_pattern_tHandle cairo_pattern_create_radial(double cx0, double cy0, double radius0, double cx1, double cy1, double radius1);

	[DllImport(Libraries.Cairo)]
	public static extern cairo_pattern_tHandle cairo_pattern_create_mesh();

	[DllImport(Libraries.Cairo)]
	public static extern cairo_region_tHandle cairo_region_create();

	[DllImport(Libraries.Cairo)]
	public static extern void cairo_debug_reset_static_data();
}
