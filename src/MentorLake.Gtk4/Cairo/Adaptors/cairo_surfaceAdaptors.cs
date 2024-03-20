using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;
public static class cairo_surfaceAdaptors
{
    public static cairoHandle CairoCreate(this cairo_surfaceHandle target)
    {
        return cairo_surfaceExterns.cairo_create(target);
    }

    public static cairo_surfaceHandle CairoSurfaceCreateSimilar(this cairo_surfaceHandle other, _cairo_content content, int width, int height)
    {
        return cairo_surfaceExterns.cairo_surface_create_similar(other, content, width, height);
    }

    public static cairo_surfaceHandle CairoSurfaceCreateSimilarImage(this cairo_surfaceHandle other, _cairo_format format, int width, int height)
    {
        return cairo_surfaceExterns.cairo_surface_create_similar_image(other, format, width, height);
    }

    public static cairo_surfaceHandle CairoSurfaceMapToImage(this cairo_surfaceHandle surface, cairo_rectangle_intHandle extents)
    {
        return cairo_surfaceExterns.cairo_surface_map_to_image(surface, extents);
    }

    public static cairo_surfaceHandle CairoSurfaceUnmapImage(this cairo_surfaceHandle surface, cairo_surfaceHandle image)
    {
        cairo_surfaceExterns.cairo_surface_unmap_image(surface, image);
        return surface;
    }

    public static cairo_surfaceHandle CairoSurfaceCreateForRectangle(this cairo_surfaceHandle target, double x, double y, double width, double height)
    {
        return cairo_surfaceExterns.cairo_surface_create_for_rectangle(target, x, y, width, height);
    }

    public static cairo_surfaceHandle CairoSurfaceCreateObserver(this cairo_surfaceHandle target, cairo_surface_observer_mode_t mode)
    {
        return cairo_surfaceExterns.cairo_surface_create_observer(target, mode);
    }

    public static _cairo_status CairoSurfaceObserverAddPaintCallback(this cairo_surfaceHandle abstract_surface, cairo_surface_observer_callback_t func, IntPtr data)
    {
        return cairo_surfaceExterns.cairo_surface_observer_add_paint_callback(abstract_surface, func, data);
    }

    public static _cairo_status CairoSurfaceObserverAddMaskCallback(this cairo_surfaceHandle abstract_surface, cairo_surface_observer_callback_t func, IntPtr data)
    {
        return cairo_surfaceExterns.cairo_surface_observer_add_mask_callback(abstract_surface, func, data);
    }

    public static _cairo_status CairoSurfaceObserverAddFillCallback(this cairo_surfaceHandle abstract_surface, cairo_surface_observer_callback_t func, IntPtr data)
    {
        return cairo_surfaceExterns.cairo_surface_observer_add_fill_callback(abstract_surface, func, data);
    }

    public static _cairo_status CairoSurfaceObserverAddStrokeCallback(this cairo_surfaceHandle abstract_surface, cairo_surface_observer_callback_t func, IntPtr data)
    {
        return cairo_surfaceExterns.cairo_surface_observer_add_stroke_callback(abstract_surface, func, data);
    }

    public static _cairo_status CairoSurfaceObserverAddGlyphsCallback(this cairo_surfaceHandle abstract_surface, cairo_surface_observer_callback_t func, IntPtr data)
    {
        return cairo_surfaceExterns.cairo_surface_observer_add_glyphs_callback(abstract_surface, func, data);
    }

    public static _cairo_status CairoSurfaceObserverAddFlushCallback(this cairo_surfaceHandle abstract_surface, cairo_surface_observer_callback_t func, IntPtr data)
    {
        return cairo_surfaceExterns.cairo_surface_observer_add_flush_callback(abstract_surface, func, data);
    }

    public static _cairo_status CairoSurfaceObserverAddFinishCallback(this cairo_surfaceHandle abstract_surface, cairo_surface_observer_callback_t func, IntPtr data)
    {
        return cairo_surfaceExterns.cairo_surface_observer_add_finish_callback(abstract_surface, func, data);
    }

    public static _cairo_status CairoSurfaceObserverPrint(this cairo_surfaceHandle surface, cairo_write_func_t write_func, IntPtr closure)
    {
        return cairo_surfaceExterns.cairo_surface_observer_print(surface, write_func, closure);
    }

    public static double CairoSurfaceObserverElapsed(this cairo_surfaceHandle surface)
    {
        return cairo_surfaceExterns.cairo_surface_observer_elapsed(surface);
    }

    public static cairo_surfaceHandle CairoSurfaceReference(this cairo_surfaceHandle surface)
    {
        return cairo_surfaceExterns.cairo_surface_reference(surface);
    }

    public static cairo_surfaceHandle CairoSurfaceFinish(this cairo_surfaceHandle surface)
    {
        cairo_surfaceExterns.cairo_surface_finish(surface);
        return surface;
    }

    public static cairo_surfaceHandle CairoSurfaceDestroy(this cairo_surfaceHandle surface)
    {
        cairo_surfaceExterns.cairo_surface_destroy(surface);
        return surface;
    }

    public static cairo_deviceHandle CairoSurfaceGetDevice(this cairo_surfaceHandle surface)
    {
        return cairo_surfaceExterns.cairo_surface_get_device(surface);
    }

    public static uint CairoSurfaceGetReferenceCount(this cairo_surfaceHandle surface)
    {
        return cairo_surfaceExterns.cairo_surface_get_reference_count(surface);
    }

    public static _cairo_status CairoSurfaceStatus(this cairo_surfaceHandle surface)
    {
        return cairo_surfaceExterns.cairo_surface_status(surface);
    }

    public static _cairo_surface_type CairoSurfaceGetType(this cairo_surfaceHandle surface)
    {
        return cairo_surfaceExterns.cairo_surface_get_type(surface);
    }

    public static _cairo_content CairoSurfaceGetContent(this cairo_surfaceHandle surface)
    {
        return cairo_surfaceExterns.cairo_surface_get_content(surface);
    }

    public static _cairo_status CairoSurfaceWriteToPng(this cairo_surfaceHandle surface, string filename)
    {
        return cairo_surfaceExterns.cairo_surface_write_to_png(surface, filename);
    }

    public static _cairo_status CairoSurfaceWriteToPngStream(this cairo_surfaceHandle surface, cairo_write_func_t write_func, IntPtr closure)
    {
        return cairo_surfaceExterns.cairo_surface_write_to_png_stream(surface, write_func, closure);
    }

    public static IntPtr CairoSurfaceGetUserData(this cairo_surfaceHandle surface, cairo_user_data_keyHandle key)
    {
        return cairo_surfaceExterns.cairo_surface_get_user_data(surface, key);
    }

    public static _cairo_status CairoSurfaceSetUserData(this cairo_surfaceHandle surface, cairo_user_data_keyHandle key, IntPtr user_data, cairo_destroy_func_t destroy)
    {
        return cairo_surfaceExterns.cairo_surface_set_user_data(surface, key, user_data, destroy);
    }

    public static cairo_surfaceHandle CairoSurfaceGetMimeData(this cairo_surfaceHandle surface, string mime_type, out byte[] data, out nuint length)
    {
        cairo_surfaceExterns.cairo_surface_get_mime_data(surface, mime_type, out data, out length);
        return surface;
    }

    public static _cairo_status CairoSurfaceSetMimeData(this cairo_surfaceHandle surface, string mime_type, byte[] data, nuint length, cairo_destroy_func_t destroy, IntPtr closure)
    {
        return cairo_surfaceExterns.cairo_surface_set_mime_data(surface, mime_type, data, length, destroy, closure);
    }

    public static int CairoSurfaceSupportsMimeType(this cairo_surfaceHandle surface, string mime_type)
    {
        return cairo_surfaceExterns.cairo_surface_supports_mime_type(surface, mime_type);
    }

    public static cairo_surfaceHandle CairoSurfaceGetFontOptions(this cairo_surfaceHandle surface, cairo_font_optionsHandle options)
    {
        cairo_surfaceExterns.cairo_surface_get_font_options(surface, options);
        return surface;
    }

    public static cairo_surfaceHandle CairoSurfaceFlush(this cairo_surfaceHandle surface)
    {
        cairo_surfaceExterns.cairo_surface_flush(surface);
        return surface;
    }

    public static cairo_surfaceHandle CairoSurfaceMarkDirty(this cairo_surfaceHandle surface)
    {
        cairo_surfaceExterns.cairo_surface_mark_dirty(surface);
        return surface;
    }

    public static cairo_surfaceHandle CairoSurfaceMarkDirtyRectangle(this cairo_surfaceHandle surface, int x, int y, int width, int height)
    {
        cairo_surfaceExterns.cairo_surface_mark_dirty_rectangle(surface, x, y, width, height);
        return surface;
    }

    public static cairo_surfaceHandle CairoSurfaceSetDeviceScale(this cairo_surfaceHandle surface, double x_scale, double y_scale)
    {
        cairo_surfaceExterns.cairo_surface_set_device_scale(surface, x_scale, y_scale);
        return surface;
    }

    public static cairo_surfaceHandle CairoSurfaceGetDeviceScale(this cairo_surfaceHandle surface, out double x_scale, out double y_scale)
    {
        cairo_surfaceExterns.cairo_surface_get_device_scale(surface, out x_scale, out y_scale);
        return surface;
    }

    public static cairo_surfaceHandle CairoSurfaceSetDeviceOffset(this cairo_surfaceHandle surface, double x_offset, double y_offset)
    {
        cairo_surfaceExterns.cairo_surface_set_device_offset(surface, x_offset, y_offset);
        return surface;
    }

    public static cairo_surfaceHandle CairoSurfaceGetDeviceOffset(this cairo_surfaceHandle surface, out double x_offset, out double y_offset)
    {
        cairo_surfaceExterns.cairo_surface_get_device_offset(surface, out x_offset, out y_offset);
        return surface;
    }

    public static cairo_surfaceHandle CairoSurfaceSetFallbackResolution(this cairo_surfaceHandle surface, double x_pixels_per_inch, double y_pixels_per_inch)
    {
        cairo_surfaceExterns.cairo_surface_set_fallback_resolution(surface, x_pixels_per_inch, y_pixels_per_inch);
        return surface;
    }

    public static cairo_surfaceHandle CairoSurfaceGetFallbackResolution(this cairo_surfaceHandle surface, out double x_pixels_per_inch, out double y_pixels_per_inch)
    {
        cairo_surfaceExterns.cairo_surface_get_fallback_resolution(surface, out x_pixels_per_inch, out y_pixels_per_inch);
        return surface;
    }

    public static cairo_surfaceHandle CairoSurfaceCopyPage(this cairo_surfaceHandle surface)
    {
        cairo_surfaceExterns.cairo_surface_copy_page(surface);
        return surface;
    }

    public static cairo_surfaceHandle CairoSurfaceShowPage(this cairo_surfaceHandle surface)
    {
        cairo_surfaceExterns.cairo_surface_show_page(surface);
        return surface;
    }

    public static int CairoSurfaceHasShowTextGlyphs(this cairo_surfaceHandle surface)
    {
        return cairo_surfaceExterns.cairo_surface_has_show_text_glyphs(surface);
    }

    public static byte[] CairoImageSurfaceGetData(this cairo_surfaceHandle surface)
    {
        return cairo_surfaceExterns.cairo_image_surface_get_data(surface);
    }

    public static _cairo_format CairoImageSurfaceGetFormat(this cairo_surfaceHandle surface)
    {
        return cairo_surfaceExterns.cairo_image_surface_get_format(surface);
    }

    public static int CairoImageSurfaceGetWidth(this cairo_surfaceHandle surface)
    {
        return cairo_surfaceExterns.cairo_image_surface_get_width(surface);
    }

    public static int CairoImageSurfaceGetHeight(this cairo_surfaceHandle surface)
    {
        return cairo_surfaceExterns.cairo_image_surface_get_height(surface);
    }

    public static int CairoImageSurfaceGetStride(this cairo_surfaceHandle surface)
    {
        return cairo_surfaceExterns.cairo_image_surface_get_stride(surface);
    }

    public static cairo_surfaceHandle CairoRecordingSurfaceInkExtents(this cairo_surfaceHandle surface, out double x0, out double y0, out double width, out double height)
    {
        cairo_surfaceExterns.cairo_recording_surface_ink_extents(surface, out x0, out y0, out width, out height);
        return surface;
    }

    public static int CairoRecordingSurfaceGetExtents(this cairo_surfaceHandle surface, cairo_rectangleHandle extents)
    {
        return cairo_surfaceExterns.cairo_recording_surface_get_extents(surface, extents);
    }

    public static cairo_patternHandle CairoPatternCreateForSurface(this cairo_surfaceHandle surface)
    {
        return cairo_surfaceExterns.cairo_pattern_create_for_surface(surface);
    }
}
