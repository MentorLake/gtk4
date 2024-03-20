using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Pixbuf;
public static class GdkPixbufExterns
{
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_ref")]
    internal static extern GdkPixbufHandle gdk_pixbuf_ref(this GdkPixbufHandle pixbuf);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_unref")]
    [Obsolete]
    internal static extern void gdk_pixbuf_unref(this GdkPixbufHandle pixbuf);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_get_colorspace")]
    internal static extern GdkColorspace gdk_pixbuf_get_colorspace(this GdkPixbufHandle pixbuf);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_get_n_channels")]
    internal static extern int gdk_pixbuf_get_n_channels(this GdkPixbufHandle pixbuf);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_get_has_alpha")]
    internal static extern int gdk_pixbuf_get_has_alpha(this GdkPixbufHandle pixbuf);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_get_bits_per_sample")]
    internal static extern int gdk_pixbuf_get_bits_per_sample(this GdkPixbufHandle pixbuf);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_get_pixels")]
    internal static extern string gdk_pixbuf_get_pixels(this GdkPixbufHandle pixbuf);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_get_width")]
    internal static extern int gdk_pixbuf_get_width(this GdkPixbufHandle pixbuf);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_get_height")]
    internal static extern int gdk_pixbuf_get_height(this GdkPixbufHandle pixbuf);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_get_rowstride")]
    internal static extern int gdk_pixbuf_get_rowstride(this GdkPixbufHandle pixbuf);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_get_byte_length")]
    internal static extern nuint gdk_pixbuf_get_byte_length(this GdkPixbufHandle pixbuf);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_get_pixels_with_length")]
    internal static extern byte[] gdk_pixbuf_get_pixels_with_length(this GdkPixbufHandle pixbuf, out uint length);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_read_pixels")]
    internal static extern byte[] gdk_pixbuf_read_pixels(this GdkPixbufHandle pixbuf);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_read_pixel_bytes")]
    internal static extern GBytesHandle gdk_pixbuf_read_pixel_bytes(this GdkPixbufHandle pixbuf);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_copy")]
    internal static extern GdkPixbufHandle gdk_pixbuf_copy(this GdkPixbufHandle pixbuf);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_new_subpixbuf")]
    internal static extern GdkPixbufHandle gdk_pixbuf_new_subpixbuf(this GdkPixbufHandle src_pixbuf, int src_x, int src_y, int width, int height);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_fill")]
    internal static extern void gdk_pixbuf_fill(this GdkPixbufHandle pixbuf, uint pixel);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_save")]
    internal static extern int gdk_pixbuf_save(this GdkPixbufHandle pixbuf, string filename, string type, out GErrorHandle error, IntPtr @__argList);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_savev")]
    internal static extern int gdk_pixbuf_savev(this GdkPixbufHandle pixbuf, string filename, string type, string[] option_keys, string[] option_values, out GErrorHandle error);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_save_to_callback")]
    internal static extern int gdk_pixbuf_save_to_callback(this GdkPixbufHandle pixbuf, GdkPixbufSaveFunc save_func, IntPtr user_data, string type, out GErrorHandle error, IntPtr @__argList);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_save_to_callbackv")]
    internal static extern int gdk_pixbuf_save_to_callbackv(this GdkPixbufHandle pixbuf, GdkPixbufSaveFunc save_func, IntPtr user_data, string type, string[] option_keys, string[] option_values, out GErrorHandle error);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_save_to_buffer")]
    internal static extern int gdk_pixbuf_save_to_buffer(this GdkPixbufHandle pixbuf, byte[] buffer, out nuint buffer_size, string type, out GErrorHandle error, IntPtr @__argList);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_save_to_bufferv")]
    internal static extern int gdk_pixbuf_save_to_bufferv(this GdkPixbufHandle pixbuf, byte[] buffer, out nuint buffer_size, string type, string[] option_keys, string[] option_values, out GErrorHandle error);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_save_to_stream")]
    internal static extern int gdk_pixbuf_save_to_stream(this GdkPixbufHandle pixbuf, GOutputStreamHandle stream, string type, GCancellableHandle cancellable, out GErrorHandle error, IntPtr @__argList);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_save_to_stream_async")]
    internal static extern void gdk_pixbuf_save_to_stream_async(this GdkPixbufHandle pixbuf, GOutputStreamHandle stream, string type, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data, IntPtr @__argList);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_save_to_streamv_async")]
    internal static extern void gdk_pixbuf_save_to_streamv_async(this GdkPixbufHandle pixbuf, GOutputStreamHandle stream, string type, string[] option_keys, string[] option_values, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_save_to_streamv")]
    internal static extern int gdk_pixbuf_save_to_streamv(this GdkPixbufHandle pixbuf, GOutputStreamHandle stream, string type, string[] option_keys, string[] option_values, GCancellableHandle cancellable, out GErrorHandle error);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_add_alpha")]
    internal static extern GdkPixbufHandle gdk_pixbuf_add_alpha(this GdkPixbufHandle pixbuf, int substitute_color, char r, char g, char b);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_copy_area")]
    internal static extern void gdk_pixbuf_copy_area(this GdkPixbufHandle src_pixbuf, int src_x, int src_y, int width, int height, GdkPixbufHandle dest_pixbuf, int dest_x, int dest_y);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_saturate_and_pixelate")]
    internal static extern void gdk_pixbuf_saturate_and_pixelate(this GdkPixbufHandle src, GdkPixbufHandle dest, float saturation, int pixelate);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_apply_embedded_orientation")]
    internal static extern GdkPixbufHandle gdk_pixbuf_apply_embedded_orientation(this GdkPixbufHandle src);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_set_option")]
    internal static extern int gdk_pixbuf_set_option(this GdkPixbufHandle pixbuf, string key, string value);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_get_option")]
    internal static extern string gdk_pixbuf_get_option(this GdkPixbufHandle pixbuf, string key);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_remove_option")]
    internal static extern int gdk_pixbuf_remove_option(this GdkPixbufHandle pixbuf, string key);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_get_options")]
    internal static extern GHashTableHandle gdk_pixbuf_get_options(this GdkPixbufHandle pixbuf);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_copy_options")]
    internal static extern int gdk_pixbuf_copy_options(this GdkPixbufHandle src_pixbuf, GdkPixbufHandle dest_pixbuf);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_scale")]
    internal static extern void gdk_pixbuf_scale(this GdkPixbufHandle src, GdkPixbufHandle dest, int dest_x, int dest_y, int dest_width, int dest_height, double offset_x, double offset_y, double scale_x, double scale_y, GdkInterpType interp_type);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_composite")]
    internal static extern void gdk_pixbuf_composite(this GdkPixbufHandle src, GdkPixbufHandle dest, int dest_x, int dest_y, int dest_width, int dest_height, double offset_x, double offset_y, double scale_x, double scale_y, GdkInterpType interp_type, int overall_alpha);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_composite_color")]
    internal static extern void gdk_pixbuf_composite_color(this GdkPixbufHandle src, GdkPixbufHandle dest, int dest_x, int dest_y, int dest_width, int dest_height, double offset_x, double offset_y, double scale_x, double scale_y, GdkInterpType interp_type, int overall_alpha, int check_x, int check_y, int check_size, uint color1, uint color2);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_scale_simple")]
    internal static extern GdkPixbufHandle gdk_pixbuf_scale_simple(this GdkPixbufHandle src, int dest_width, int dest_height, GdkInterpType interp_type);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_composite_color_simple")]
    internal static extern GdkPixbufHandle gdk_pixbuf_composite_color_simple(this GdkPixbufHandle src, int dest_width, int dest_height, GdkInterpType interp_type, int overall_alpha, int check_size, uint color1, uint color2);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_rotate_simple")]
    internal static extern GdkPixbufHandle gdk_pixbuf_rotate_simple(this GdkPixbufHandle src, GdkPixbufRotation angle);
    [DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_flip")]
    internal static extern GdkPixbufHandle gdk_pixbuf_flip(this GdkPixbufHandle src, int horizontal);
    [DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkPixbufHandle gdk_pixbuf_new(GdkColorspace colorspace, int has_alpha, int bits_per_sample, int width, int height);
    [DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkPixbufHandle gdk_pixbuf_new_from_file(string filename, out GErrorHandle error);
    [DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkPixbufHandle gdk_pixbuf_new_from_file_at_size(string filename, int width, int height, out GErrorHandle error);
    [DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkPixbufHandle gdk_pixbuf_new_from_file_at_scale(string filename, int width, int height, int preserve_aspect_ratio, out GErrorHandle error);
    [DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkPixbufHandle gdk_pixbuf_new_from_resource(string resource_path, out GErrorHandle error);
    [DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkPixbufHandle gdk_pixbuf_new_from_resource_at_scale(string resource_path, int width, int height, int preserve_aspect_ratio, out GErrorHandle error);
    [DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkPixbufHandle gdk_pixbuf_new_from_data(string data, GdkColorspace colorspace, int has_alpha, int bits_per_sample, int width, int height, int rowstride, GdkPixbufDestroyNotify destroy_fn, IntPtr destroy_fn_data);
    [DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkPixbufHandle gdk_pixbuf_new_from_bytes(GBytesHandle data, GdkColorspace colorspace, int has_alpha, int bits_per_sample, int width, int height, int rowstride);
    [DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkPixbufHandle gdk_pixbuf_new_from_xpm_data(string data);
    [DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkPixbufHandle gdk_pixbuf_new_from_inline(int data_length, byte[] data, int copy_pixels, out GErrorHandle error);
    [DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkPixbufHandle gdk_pixbuf_new_from_stream(GInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error);
    [DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkPixbufHandle gdk_pixbuf_new_from_stream_finish(GAsyncResultHandle async_result, out GErrorHandle error);
    [DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkPixbufHandle gdk_pixbuf_new_from_stream_at_scale(GInputStreamHandle stream, int width, int height, int preserve_aspect_ratio, GCancellableHandle cancellable, out GErrorHandle error);
}
