using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;

public static class cairo_surfaceExterns
{
	[DllImport(Libraries.Cairo, EntryPoint = "cairo_create")]
	internal static extern cairoHandle cairo_create(this cairo_surfaceHandle target);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_create_similar")]
	internal static extern cairo_surfaceHandle cairo_surface_create_similar(this cairo_surfaceHandle other, _cairo_content content, int width, int height);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_create_similar_image")]
	internal static extern cairo_surfaceHandle cairo_surface_create_similar_image(this cairo_surfaceHandle other, _cairo_format format, int width, int height);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_map_to_image")]
	internal static extern cairo_surfaceHandle cairo_surface_map_to_image(this cairo_surfaceHandle surface, cairo_rectangle_intHandle extents);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_unmap_image")]
	internal static extern void cairo_surface_unmap_image(this cairo_surfaceHandle surface, cairo_surfaceHandle image);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_create_for_rectangle")]
	internal static extern cairo_surfaceHandle cairo_surface_create_for_rectangle(this cairo_surfaceHandle target, double x, double y, double width, double height);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_create_observer")]
	internal static extern cairo_surfaceHandle cairo_surface_create_observer(this cairo_surfaceHandle target, cairo_surface_observer_mode_t mode);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_observer_add_paint_callback")]
	internal static extern _cairo_status cairo_surface_observer_add_paint_callback(this cairo_surfaceHandle abstract_surface, cairo_surface_observer_callback_t func, IntPtr data);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_observer_add_mask_callback")]
	internal static extern _cairo_status cairo_surface_observer_add_mask_callback(this cairo_surfaceHandle abstract_surface, cairo_surface_observer_callback_t func, IntPtr data);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_observer_add_fill_callback")]
	internal static extern _cairo_status cairo_surface_observer_add_fill_callback(this cairo_surfaceHandle abstract_surface, cairo_surface_observer_callback_t func, IntPtr data);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_observer_add_stroke_callback")]
	internal static extern _cairo_status cairo_surface_observer_add_stroke_callback(this cairo_surfaceHandle abstract_surface, cairo_surface_observer_callback_t func, IntPtr data);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_observer_add_glyphs_callback")]
	internal static extern _cairo_status cairo_surface_observer_add_glyphs_callback(this cairo_surfaceHandle abstract_surface, cairo_surface_observer_callback_t func, IntPtr data);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_observer_add_flush_callback")]
	internal static extern _cairo_status cairo_surface_observer_add_flush_callback(this cairo_surfaceHandle abstract_surface, cairo_surface_observer_callback_t func, IntPtr data);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_observer_add_finish_callback")]
	internal static extern _cairo_status cairo_surface_observer_add_finish_callback(this cairo_surfaceHandle abstract_surface, cairo_surface_observer_callback_t func, IntPtr data);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_observer_print")]
	internal static extern _cairo_status cairo_surface_observer_print(this cairo_surfaceHandle surface, cairo_write_func_t write_func, IntPtr closure);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_observer_elapsed")]
	internal static extern double cairo_surface_observer_elapsed(this cairo_surfaceHandle surface);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_reference")]
	internal static extern cairo_surfaceHandle cairo_surface_reference(this cairo_surfaceHandle surface);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_finish")]
	internal static extern void cairo_surface_finish(this cairo_surfaceHandle surface);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_destroy")]
	internal static extern void cairo_surface_destroy(this cairo_surfaceHandle surface);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_get_device")]
	internal static extern cairo_deviceHandle cairo_surface_get_device(this cairo_surfaceHandle surface);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_get_reference_count")]
	internal static extern uint cairo_surface_get_reference_count(this cairo_surfaceHandle surface);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_status")]
	internal static extern _cairo_status cairo_surface_status(this cairo_surfaceHandle surface);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_get_type")]
	internal static extern _cairo_surface_type cairo_surface_get_type(this cairo_surfaceHandle surface);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_get_content")]
	internal static extern _cairo_content cairo_surface_get_content(this cairo_surfaceHandle surface);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_write_to_png")]
	internal static extern _cairo_status cairo_surface_write_to_png(this cairo_surfaceHandle surface, string filename);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_write_to_png_stream")]
	internal static extern _cairo_status cairo_surface_write_to_png_stream(this cairo_surfaceHandle surface, cairo_write_func_t write_func, IntPtr closure);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_get_user_data")]
	internal static extern IntPtr cairo_surface_get_user_data(this cairo_surfaceHandle surface, cairo_user_data_keyHandle key);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_set_user_data")]
	internal static extern _cairo_status cairo_surface_set_user_data(this cairo_surfaceHandle surface, cairo_user_data_keyHandle key, IntPtr user_data, cairo_destroy_func_t destroy);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_get_mime_data")]
	internal static extern void cairo_surface_get_mime_data(this cairo_surfaceHandle surface, string mime_type, out byte[] data, out nuint length);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_set_mime_data")]
	internal static extern _cairo_status cairo_surface_set_mime_data(this cairo_surfaceHandle surface, string mime_type, byte[] data, nuint length, cairo_destroy_func_t destroy, IntPtr closure);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_supports_mime_type")]
	internal static extern int cairo_surface_supports_mime_type(this cairo_surfaceHandle surface, string mime_type);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_get_font_options")]
	internal static extern void cairo_surface_get_font_options(this cairo_surfaceHandle surface, cairo_font_optionsHandle options);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_flush")]
	internal static extern void cairo_surface_flush(this cairo_surfaceHandle surface);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_mark_dirty")]
	internal static extern void cairo_surface_mark_dirty(this cairo_surfaceHandle surface);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_mark_dirty_rectangle")]
	internal static extern void cairo_surface_mark_dirty_rectangle(this cairo_surfaceHandle surface, int x, int y, int width, int height);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_set_device_scale")]
	internal static extern void cairo_surface_set_device_scale(this cairo_surfaceHandle surface, double x_scale, double y_scale);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_get_device_scale")]
	internal static extern void cairo_surface_get_device_scale(this cairo_surfaceHandle surface, out double x_scale, out double y_scale);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_set_device_offset")]
	internal static extern void cairo_surface_set_device_offset(this cairo_surfaceHandle surface, double x_offset, double y_offset);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_get_device_offset")]
	internal static extern void cairo_surface_get_device_offset(this cairo_surfaceHandle surface, out double x_offset, out double y_offset);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_set_fallback_resolution")]
	internal static extern void cairo_surface_set_fallback_resolution(this cairo_surfaceHandle surface, double x_pixels_per_inch, double y_pixels_per_inch);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_get_fallback_resolution")]
	internal static extern void cairo_surface_get_fallback_resolution(this cairo_surfaceHandle surface, out double x_pixels_per_inch, out double y_pixels_per_inch);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_copy_page")]
	internal static extern void cairo_surface_copy_page(this cairo_surfaceHandle surface);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_show_page")]
	internal static extern void cairo_surface_show_page(this cairo_surfaceHandle surface);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_has_show_text_glyphs")]
	internal static extern int cairo_surface_has_show_text_glyphs(this cairo_surfaceHandle surface);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_image_surface_get_data")]
	internal static extern byte[] cairo_image_surface_get_data(this cairo_surfaceHandle surface);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_image_surface_get_format")]
	internal static extern _cairo_format cairo_image_surface_get_format(this cairo_surfaceHandle surface);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_image_surface_get_width")]
	internal static extern int cairo_image_surface_get_width(this cairo_surfaceHandle surface);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_image_surface_get_height")]
	internal static extern int cairo_image_surface_get_height(this cairo_surfaceHandle surface);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_image_surface_get_stride")]
	internal static extern int cairo_image_surface_get_stride(this cairo_surfaceHandle surface);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_recording_surface_ink_extents")]
	internal static extern void cairo_recording_surface_ink_extents(this cairo_surfaceHandle surface, out double x0, out double y0, out double width, out double height);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_recording_surface_get_extents")]
	internal static extern int cairo_recording_surface_get_extents(this cairo_surfaceHandle surface, cairo_rectangleHandle extents);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_create_for_surface")]
	internal static extern cairo_patternHandle cairo_pattern_create_for_surface(this cairo_surfaceHandle surface);
}
