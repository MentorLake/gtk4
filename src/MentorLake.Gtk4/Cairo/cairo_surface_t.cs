using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;

public class cairo_surface_tHandle : BaseSafeHandle { }
public struct cairo_surface_t { }

public static class cairo_surfaceAdaptors
{
	public static cairo_tHandle CairoCreate(this cairo_surface_tHandle target)
	{
		return cairo_surfaceExterns.cairo_create(target);
	}

	public static cairo_surface_tHandle CairoSurfaceCreateSimilar(this cairo_surface_tHandle other, cairo_content_t contentT, int width, int height)
	{
		return cairo_surfaceExterns.cairo_surface_create_similar(other, contentT, width, height);
	}

	public static cairo_surface_tHandle CairoSurfaceCreateSimilarImage(this cairo_surface_tHandle other, cairo_format_t format, int width, int height)
	{
		return cairo_surfaceExterns.cairo_surface_create_similar_image(other, format, width, height);
	}

	public static cairo_surface_tHandle CairoSurfaceMapToImage(this cairo_surface_tHandle surfaceT, cairo_rectangle_int_tHandle extents)
	{
		return cairo_surfaceExterns.cairo_surface_map_to_image(surfaceT, extents);
	}

	public static cairo_surface_tHandle CairoSurfaceUnmapImage(this cairo_surface_tHandle surfaceT, cairo_surface_tHandle image)
	{
		cairo_surfaceExterns.cairo_surface_unmap_image(surfaceT, image);
		return surfaceT;
	}

	public static cairo_surface_tHandle CairoSurfaceCreateForRectangle(this cairo_surface_tHandle target, double x, double y, double width, double height)
	{
		return cairo_surfaceExterns.cairo_surface_create_for_rectangle(target, x, y, width, height);
	}

	public static cairo_surface_tHandle CairoSurfaceCreateObserver(this cairo_surface_tHandle target, cairo_surface_observer_mode_t mode)
	{
		return cairo_surfaceExterns.cairo_surface_create_observer(target, mode);
	}

	public static cairo_status_t CairoSurfaceObserverAddPaintCallback(this cairo_surface_tHandle abstractSurfaceT, cairo_surface_observer_callback_t func, IntPtr data)
	{
		return cairo_surfaceExterns.cairo_surface_observer_add_paint_callback(abstractSurfaceT, func, data);
	}

	public static cairo_status_t CairoSurfaceObserverAddMaskCallback(this cairo_surface_tHandle abstractSurfaceT, cairo_surface_observer_callback_t func, IntPtr data)
	{
		return cairo_surfaceExterns.cairo_surface_observer_add_mask_callback(abstractSurfaceT, func, data);
	}

	public static cairo_status_t CairoSurfaceObserverAddFillCallback(this cairo_surface_tHandle abstractSurfaceT, cairo_surface_observer_callback_t func, IntPtr data)
	{
		return cairo_surfaceExterns.cairo_surface_observer_add_fill_callback(abstractSurfaceT, func, data);
	}

	public static cairo_status_t CairoSurfaceObserverAddStrokeCallback(this cairo_surface_tHandle abstractSurfaceT, cairo_surface_observer_callback_t func, IntPtr data)
	{
		return cairo_surfaceExterns.cairo_surface_observer_add_stroke_callback(abstractSurfaceT, func, data);
	}

	public static cairo_status_t CairoSurfaceObserverAddGlyphsCallback(this cairo_surface_tHandle abstractSurfaceT, cairo_surface_observer_callback_t func, IntPtr data)
	{
		return cairo_surfaceExterns.cairo_surface_observer_add_glyphs_callback(abstractSurfaceT, func, data);
	}

	public static cairo_status_t CairoSurfaceObserverAddFlushCallback(this cairo_surface_tHandle abstractSurfaceT, cairo_surface_observer_callback_t func, IntPtr data)
	{
		return cairo_surfaceExterns.cairo_surface_observer_add_flush_callback(abstractSurfaceT, func, data);
	}

	public static cairo_status_t CairoSurfaceObserverAddFinishCallback(this cairo_surface_tHandle abstractSurfaceT, cairo_surface_observer_callback_t func, IntPtr data)
	{
		return cairo_surfaceExterns.cairo_surface_observer_add_finish_callback(abstractSurfaceT, func, data);
	}

	public static cairo_status_t CairoSurfaceObserverPrint(this cairo_surface_tHandle surfaceT, cairo_write_func_t write_func, IntPtr closure)
	{
		return cairo_surfaceExterns.cairo_surface_observer_print(surfaceT, write_func, closure);
	}

	public static double CairoSurfaceObserverElapsed(this cairo_surface_tHandle surfaceT)
	{
		return cairo_surfaceExterns.cairo_surface_observer_elapsed(surfaceT);
	}

	public static cairo_surface_tHandle CairoSurfaceReference(this cairo_surface_tHandle surfaceT)
	{
		return cairo_surfaceExterns.cairo_surface_reference(surfaceT);
	}

	public static cairo_surface_tHandle CairoSurfaceFinish(this cairo_surface_tHandle surfaceT)
	{
		cairo_surfaceExterns.cairo_surface_finish(surfaceT);
		return surfaceT;
	}

	public static cairo_surface_tHandle CairoSurfaceDestroy(this cairo_surface_tHandle surfaceT)
	{
		cairo_surfaceExterns.cairo_surface_destroy(surfaceT);
		return surfaceT;
	}

	public static cairo_device_tHandle CairoSurfaceGetDevice(this cairo_surface_tHandle surfaceT)
	{
		return cairo_surfaceExterns.cairo_surface_get_device(surfaceT);
	}

	public static uint CairoSurfaceGetReferenceCount(this cairo_surface_tHandle surfaceT)
	{
		return cairo_surfaceExterns.cairo_surface_get_reference_count(surfaceT);
	}

	public static cairo_status_t CairoSurfaceStatus(this cairo_surface_tHandle surfaceT)
	{
		return cairo_surfaceExterns.cairo_surface_status(surfaceT);
	}

	public static cairo_surface_type_t CairoSurfaceGetType(this cairo_surface_tHandle surfaceT)
	{
		return cairo_surfaceExterns.cairo_surface_get_type(surfaceT);
	}

	public static cairo_content_t CairoSurfaceGetContent(this cairo_surface_tHandle surfaceT)
	{
		return cairo_surfaceExterns.cairo_surface_get_content(surfaceT);
	}

	public static cairo_status_t CairoSurfaceWriteToPng(this cairo_surface_tHandle surfaceT, string filename)
	{
		return cairo_surfaceExterns.cairo_surface_write_to_png(surfaceT, filename);
	}

	public static cairo_status_t CairoSurfaceWriteToPngStream(this cairo_surface_tHandle surfaceT, cairo_write_func_t write_func, IntPtr closure)
	{
		return cairo_surfaceExterns.cairo_surface_write_to_png_stream(surfaceT, write_func, closure);
	}

	public static IntPtr CairoSurfaceGetUserData(this cairo_surface_tHandle surfaceT, cairo_user_data_key_tHandle keyT)
	{
		return cairo_surfaceExterns.cairo_surface_get_user_data(surfaceT, keyT);
	}

	public static cairo_status_t CairoSurfaceSetUserData(this cairo_surface_tHandle surfaceT, cairo_user_data_key_tHandle keyT, IntPtr user_data, cairo_destroy_func_t destroy)
	{
		return cairo_surfaceExterns.cairo_surface_set_user_data(surfaceT, keyT, user_data, destroy);
	}

	public static cairo_surface_tHandle CairoSurfaceGetMimeData(this cairo_surface_tHandle surfaceT, string mime_type, out byte[] data, out nuint length)
	{
		cairo_surfaceExterns.cairo_surface_get_mime_data(surfaceT, mime_type, out data, out length);
		return surfaceT;
	}

	public static cairo_status_t CairoSurfaceSetMimeData(this cairo_surface_tHandle surfaceT, string mime_type, byte[] data, nuint length, cairo_destroy_func_t destroy, IntPtr closure)
	{
		return cairo_surfaceExterns.cairo_surface_set_mime_data(surfaceT, mime_type, data, length, destroy, closure);
	}

	public static int CairoSurfaceSupportsMimeType(this cairo_surface_tHandle surfaceT, string mime_type)
	{
		return cairo_surfaceExterns.cairo_surface_supports_mime_type(surfaceT, mime_type);
	}

	public static cairo_surface_tHandle CairoSurfaceGetFontOptions(this cairo_surface_tHandle surfaceT, cairo_font_options_tHandle optionsT)
	{
		cairo_surfaceExterns.cairo_surface_get_font_options(surfaceT, optionsT);
		return surfaceT;
	}

	public static cairo_surface_tHandle CairoSurfaceFlush(this cairo_surface_tHandle surfaceT)
	{
		cairo_surfaceExterns.cairo_surface_flush(surfaceT);
		return surfaceT;
	}

	public static cairo_surface_tHandle CairoSurfaceMarkDirty(this cairo_surface_tHandle surfaceT)
	{
		cairo_surfaceExterns.cairo_surface_mark_dirty(surfaceT);
		return surfaceT;
	}

	public static cairo_surface_tHandle CairoSurfaceMarkDirtyRectangle(this cairo_surface_tHandle surfaceT, int x, int y, int width, int height)
	{
		cairo_surfaceExterns.cairo_surface_mark_dirty_rectangle(surfaceT, x, y, width, height);
		return surfaceT;
	}

	public static cairo_surface_tHandle CairoSurfaceSetDeviceScale(this cairo_surface_tHandle surfaceT, double x_scale, double y_scale)
	{
		cairo_surfaceExterns.cairo_surface_set_device_scale(surfaceT, x_scale, y_scale);
		return surfaceT;
	}

	public static cairo_surface_tHandle CairoSurfaceGetDeviceScale(this cairo_surface_tHandle surfaceT, out double x_scale, out double y_scale)
	{
		cairo_surfaceExterns.cairo_surface_get_device_scale(surfaceT, out x_scale, out y_scale);
		return surfaceT;
	}

	public static cairo_surface_tHandle CairoSurfaceSetDeviceOffset(this cairo_surface_tHandle surfaceT, double x_offset, double y_offset)
	{
		cairo_surfaceExterns.cairo_surface_set_device_offset(surfaceT, x_offset, y_offset);
		return surfaceT;
	}

	public static cairo_surface_tHandle CairoSurfaceGetDeviceOffset(this cairo_surface_tHandle surfaceT, out double x_offset, out double y_offset)
	{
		cairo_surfaceExterns.cairo_surface_get_device_offset(surfaceT, out x_offset, out y_offset);
		return surfaceT;
	}

	public static cairo_surface_tHandle CairoSurfaceSetFallbackResolution(this cairo_surface_tHandle surfaceT, double x_pixels_per_inch, double y_pixels_per_inch)
	{
		cairo_surfaceExterns.cairo_surface_set_fallback_resolution(surfaceT, x_pixels_per_inch, y_pixels_per_inch);
		return surfaceT;
	}

	public static cairo_surface_tHandle CairoSurfaceGetFallbackResolution(this cairo_surface_tHandle surfaceT, out double x_pixels_per_inch, out double y_pixels_per_inch)
	{
		cairo_surfaceExterns.cairo_surface_get_fallback_resolution(surfaceT, out x_pixels_per_inch, out y_pixels_per_inch);
		return surfaceT;
	}

	public static cairo_surface_tHandle CairoSurfaceCopyPage(this cairo_surface_tHandle surfaceT)
	{
		cairo_surfaceExterns.cairo_surface_copy_page(surfaceT);
		return surfaceT;
	}

	public static cairo_surface_tHandle CairoSurfaceShowPage(this cairo_surface_tHandle surfaceT)
	{
		cairo_surfaceExterns.cairo_surface_show_page(surfaceT);
		return surfaceT;
	}

	public static int CairoSurfaceHasShowTextGlyphs(this cairo_surface_tHandle surfaceT)
	{
		return cairo_surfaceExterns.cairo_surface_has_show_text_glyphs(surfaceT);
	}

	public static byte[] CairoImageSurfaceGetData(this cairo_surface_tHandle surfaceT)
	{
		return cairo_surfaceExterns.cairo_image_surface_get_data(surfaceT);
	}

	public static cairo_format_t CairoImageSurfaceGetFormat(this cairo_surface_tHandle surfaceT)
	{
		return cairo_surfaceExterns.cairo_image_surface_get_format(surfaceT);
	}

	public static int CairoImageSurfaceGetWidth(this cairo_surface_tHandle surfaceT)
	{
		return cairo_surfaceExterns.cairo_image_surface_get_width(surfaceT);
	}

	public static int CairoImageSurfaceGetHeight(this cairo_surface_tHandle surfaceT)
	{
		return cairo_surfaceExterns.cairo_image_surface_get_height(surfaceT);
	}

	public static int CairoImageSurfaceGetStride(this cairo_surface_tHandle surfaceT)
	{
		return cairo_surfaceExterns.cairo_image_surface_get_stride(surfaceT);
	}

	public static cairo_surface_tHandle CairoRecordingSurfaceInkExtents(this cairo_surface_tHandle surfaceT, out double x0, out double y0, out double width, out double height)
	{
		cairo_surfaceExterns.cairo_recording_surface_ink_extents(surfaceT, out x0, out y0, out width, out height);
		return surfaceT;
	}

	public static int CairoRecordingSurfaceGetExtents(this cairo_surface_tHandle surfaceT, cairo_rectangle_tHandle extents)
	{
		return cairo_surfaceExterns.cairo_recording_surface_get_extents(surfaceT, extents);
	}

	public static cairo_pattern_tHandle CairoPatternCreateForSurface(this cairo_surface_tHandle surfaceT)
	{
		return cairo_surfaceExterns.cairo_pattern_create_for_surface(surfaceT);
	}
}

public static class cairo_surfaceExterns
{
	[DllImport(Libraries.Cairo, EntryPoint = "cairo_create")]
	internal static extern cairo_tHandle cairo_create(this cairo_surface_tHandle target);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_create_similar")]
	internal static extern cairo_surface_tHandle cairo_surface_create_similar(this cairo_surface_tHandle other, cairo_content_t contentT, int width, int height);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_create_similar_image")]
	internal static extern cairo_surface_tHandle cairo_surface_create_similar_image(this cairo_surface_tHandle other, cairo_format_t format, int width, int height);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_map_to_image")]
	internal static extern cairo_surface_tHandle cairo_surface_map_to_image(this cairo_surface_tHandle surfaceT, cairo_rectangle_int_tHandle extents);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_unmap_image")]
	internal static extern void cairo_surface_unmap_image(this cairo_surface_tHandle surfaceT, cairo_surface_tHandle image);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_create_for_rectangle")]
	internal static extern cairo_surface_tHandle cairo_surface_create_for_rectangle(this cairo_surface_tHandle target, double x, double y, double width, double height);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_create_observer")]
	internal static extern cairo_surface_tHandle cairo_surface_create_observer(this cairo_surface_tHandle target, cairo_surface_observer_mode_t mode);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_observer_add_paint_callback")]
	internal static extern cairo_status_t cairo_surface_observer_add_paint_callback(this cairo_surface_tHandle abstractSurfaceT, cairo_surface_observer_callback_t func, IntPtr data);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_observer_add_mask_callback")]
	internal static extern cairo_status_t cairo_surface_observer_add_mask_callback(this cairo_surface_tHandle abstractSurfaceT, cairo_surface_observer_callback_t func, IntPtr data);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_observer_add_fill_callback")]
	internal static extern cairo_status_t cairo_surface_observer_add_fill_callback(this cairo_surface_tHandle abstractSurfaceT, cairo_surface_observer_callback_t func, IntPtr data);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_observer_add_stroke_callback")]
	internal static extern cairo_status_t cairo_surface_observer_add_stroke_callback(this cairo_surface_tHandle abstractSurfaceT, cairo_surface_observer_callback_t func, IntPtr data);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_observer_add_glyphs_callback")]
	internal static extern cairo_status_t cairo_surface_observer_add_glyphs_callback(this cairo_surface_tHandle abstractSurfaceT, cairo_surface_observer_callback_t func, IntPtr data);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_observer_add_flush_callback")]
	internal static extern cairo_status_t cairo_surface_observer_add_flush_callback(this cairo_surface_tHandle abstractSurfaceT, cairo_surface_observer_callback_t func, IntPtr data);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_observer_add_finish_callback")]
	internal static extern cairo_status_t cairo_surface_observer_add_finish_callback(this cairo_surface_tHandle abstractSurfaceT, cairo_surface_observer_callback_t func, IntPtr data);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_observer_print")]
	internal static extern cairo_status_t cairo_surface_observer_print(this cairo_surface_tHandle surfaceT, cairo_write_func_t write_func, IntPtr closure);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_observer_elapsed")]
	internal static extern double cairo_surface_observer_elapsed(this cairo_surface_tHandle surfaceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_reference")]
	internal static extern cairo_surface_tHandle cairo_surface_reference(this cairo_surface_tHandle surfaceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_finish")]
	internal static extern void cairo_surface_finish(this cairo_surface_tHandle surfaceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_destroy")]
	internal static extern void cairo_surface_destroy(this cairo_surface_tHandle surfaceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_get_device")]
	internal static extern cairo_device_tHandle cairo_surface_get_device(this cairo_surface_tHandle surfaceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_get_reference_count")]
	internal static extern uint cairo_surface_get_reference_count(this cairo_surface_tHandle surfaceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_status")]
	internal static extern cairo_status_t cairo_surface_status(this cairo_surface_tHandle surfaceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_get_type")]
	internal static extern cairo_surface_type_t cairo_surface_get_type(this cairo_surface_tHandle surfaceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_get_content")]
	internal static extern cairo_content_t cairo_surface_get_content(this cairo_surface_tHandle surfaceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_write_to_png")]
	internal static extern cairo_status_t cairo_surface_write_to_png(this cairo_surface_tHandle surfaceT, string filename);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_write_to_png_stream")]
	internal static extern cairo_status_t cairo_surface_write_to_png_stream(this cairo_surface_tHandle surfaceT, cairo_write_func_t write_func, IntPtr closure);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_get_user_data")]
	internal static extern IntPtr cairo_surface_get_user_data(this cairo_surface_tHandle surfaceT, cairo_user_data_key_tHandle keyT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_set_user_data")]
	internal static extern cairo_status_t cairo_surface_set_user_data(this cairo_surface_tHandle surfaceT, cairo_user_data_key_tHandle keyT, IntPtr user_data, cairo_destroy_func_t destroy);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_get_mime_data")]
	internal static extern void cairo_surface_get_mime_data(this cairo_surface_tHandle surfaceT, string mime_type, out byte[] data, out nuint length);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_set_mime_data")]
	internal static extern cairo_status_t cairo_surface_set_mime_data(this cairo_surface_tHandle surfaceT, string mime_type, byte[] data, nuint length, cairo_destroy_func_t destroy, IntPtr closure);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_supports_mime_type")]
	internal static extern int cairo_surface_supports_mime_type(this cairo_surface_tHandle surfaceT, string mime_type);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_get_font_options")]
	internal static extern void cairo_surface_get_font_options(this cairo_surface_tHandle surfaceT, cairo_font_options_tHandle optionsT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_flush")]
	internal static extern void cairo_surface_flush(this cairo_surface_tHandle surfaceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_mark_dirty")]
	internal static extern void cairo_surface_mark_dirty(this cairo_surface_tHandle surfaceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_mark_dirty_rectangle")]
	internal static extern void cairo_surface_mark_dirty_rectangle(this cairo_surface_tHandle surfaceT, int x, int y, int width, int height);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_set_device_scale")]
	internal static extern void cairo_surface_set_device_scale(this cairo_surface_tHandle surfaceT, double x_scale, double y_scale);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_get_device_scale")]
	internal static extern void cairo_surface_get_device_scale(this cairo_surface_tHandle surfaceT, out double x_scale, out double y_scale);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_set_device_offset")]
	internal static extern void cairo_surface_set_device_offset(this cairo_surface_tHandle surfaceT, double x_offset, double y_offset);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_get_device_offset")]
	internal static extern void cairo_surface_get_device_offset(this cairo_surface_tHandle surfaceT, out double x_offset, out double y_offset);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_set_fallback_resolution")]
	internal static extern void cairo_surface_set_fallback_resolution(this cairo_surface_tHandle surfaceT, double x_pixels_per_inch, double y_pixels_per_inch);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_get_fallback_resolution")]
	internal static extern void cairo_surface_get_fallback_resolution(this cairo_surface_tHandle surfaceT, out double x_pixels_per_inch, out double y_pixels_per_inch);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_copy_page")]
	internal static extern void cairo_surface_copy_page(this cairo_surface_tHandle surfaceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_show_page")]
	internal static extern void cairo_surface_show_page(this cairo_surface_tHandle surfaceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_surface_has_show_text_glyphs")]
	internal static extern int cairo_surface_has_show_text_glyphs(this cairo_surface_tHandle surfaceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_image_surface_get_data")]
	internal static extern byte[] cairo_image_surface_get_data(this cairo_surface_tHandle surfaceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_image_surface_get_format")]
	internal static extern cairo_format_t cairo_image_surface_get_format(this cairo_surface_tHandle surfaceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_image_surface_get_width")]
	internal static extern int cairo_image_surface_get_width(this cairo_surface_tHandle surfaceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_image_surface_get_height")]
	internal static extern int cairo_image_surface_get_height(this cairo_surface_tHandle surfaceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_image_surface_get_stride")]
	internal static extern int cairo_image_surface_get_stride(this cairo_surface_tHandle surfaceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_recording_surface_ink_extents")]
	internal static extern void cairo_recording_surface_ink_extents(this cairo_surface_tHandle surfaceT, out double x0, out double y0, out double width, out double height);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_recording_surface_get_extents")]
	internal static extern int cairo_recording_surface_get_extents(this cairo_surface_tHandle surfaceT, cairo_rectangle_tHandle extents);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pattern_create_for_surface")]
	internal static extern cairo_pattern_tHandle cairo_pattern_create_for_surface(this cairo_surface_tHandle surfaceT);
}
