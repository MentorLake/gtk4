using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cairo_surface_observer_callback_t(cairo_surface_tHandle observer, cairo_surface_tHandle target, IntPtr data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate cairo_status_t cairo_user_scaled_font_render_glyph_func_t(cairo_scaled_font_tHandle scaledFontT, nuint glyph, cairo_tHandle cr, cairo_text_extents_tHandle extents);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate cairo_status_t cairo_user_scaled_font_text_to_glyphs_func_t(cairo_scaled_font_tHandle scaledFontT, string utf8, int utf8_len, cairo_glyph_tHandle[] glyphs, ref int num_glyphs, cairo_text_cluster_tHandle[] clusters, ref int num_clusters, ref cairo_text_cluster_flags_t cluster_flags);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate cairo_status_t cairo_raster_source_snapshot_func_t(cairo_pattern_tHandle patternT, IntPtr callback_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate cairo_status_t cairo_write_func_t(IntPtr closure, byte[] data, uint length);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate cairo_status_t cairo_read_func_t(IntPtr closure, byte[] data, uint length);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cairo_raster_source_finish_func_t(cairo_pattern_tHandle patternT, IntPtr callback_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate cairo_status_t cairo_user_scaled_font_unicode_to_glyph_func_t(cairo_scaled_font_tHandle scaledFontT, nuint unicode, out nuint glyph_index);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate cairo_status_t cairo_raster_source_copy_func_t(cairo_pattern_tHandle patternT, IntPtr callback_data, cairo_pattern_tHandle other);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cairo_destroy_func_t(IntPtr data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cairo_raster_source_release_func_t(cairo_pattern_tHandle patternT, IntPtr callback_data, cairo_surface_tHandle surfaceT);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate cairo_surface_tHandle cairo_raster_source_acquire_func_t(cairo_pattern_tHandle patternT, IntPtr callback_data, cairo_surface_tHandle target, cairo_rectangle_int_tHandle extents);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate cairo_status_t cairo_user_scaled_font_init_func_t(cairo_scaled_font_tHandle scaledFontT, cairo_tHandle cr, cairo_font_extents_tHandle extents);
