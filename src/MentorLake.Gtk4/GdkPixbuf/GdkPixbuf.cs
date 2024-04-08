using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.GdkPixbuf;

public class GdkPixbufHandle : GObjectHandle, GIconHandle, GLoadableIconHandle
{
	public static GdkPixbufHandle New(GdkColorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height)
	{
		return GdkPixbufExterns.gdk_pixbuf_new(colorspace, has_alpha, bits_per_sample, width, height);
	}

	public static GdkPixbufHandle NewFromBytes(GBytesHandle data, GdkColorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height, int rowstride)
	{
		return GdkPixbufExterns.gdk_pixbuf_new_from_bytes(data, colorspace, has_alpha, bits_per_sample, width, height, rowstride);
	}

	public static GdkPixbufHandle NewFromData(string data, GdkColorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height, int rowstride, GdkPixbufDestroyNotify destroy_fn, IntPtr destroy_fn_data)
	{
		return GdkPixbufExterns.gdk_pixbuf_new_from_data(data, colorspace, has_alpha, bits_per_sample, width, height, rowstride, destroy_fn, destroy_fn_data);
	}

	public static GdkPixbufHandle NewFromFile(string filename, out GErrorHandle error)
	{
		return GdkPixbufExterns.gdk_pixbuf_new_from_file(filename, out error);
	}

	public static GdkPixbufHandle NewFromFileAtScale(string filename, int width, int height, bool preserve_aspect_ratio, out GErrorHandle error)
	{
		return GdkPixbufExterns.gdk_pixbuf_new_from_file_at_scale(filename, width, height, preserve_aspect_ratio, out error);
	}

	public static GdkPixbufHandle NewFromFileAtSize(string filename, int width, int height, out GErrorHandle error)
	{
		return GdkPixbufExterns.gdk_pixbuf_new_from_file_at_size(filename, width, height, out error);
	}

	public static GdkPixbufHandle NewFromInline(int data_length, byte[] data, bool copy_pixels, out GErrorHandle error)
	{
		return GdkPixbufExterns.gdk_pixbuf_new_from_inline(data_length, data, copy_pixels, out error);
	}

	public static GdkPixbufHandle NewFromResource(string resource_path, out GErrorHandle error)
	{
		return GdkPixbufExterns.gdk_pixbuf_new_from_resource(resource_path, out error);
	}

	public static GdkPixbufHandle NewFromResourceAtScale(string resource_path, int width, int height, bool preserve_aspect_ratio, out GErrorHandle error)
	{
		return GdkPixbufExterns.gdk_pixbuf_new_from_resource_at_scale(resource_path, width, height, preserve_aspect_ratio, out error);
	}

	public static GdkPixbufHandle NewFromStream(GInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GdkPixbufExterns.gdk_pixbuf_new_from_stream(stream, cancellable, out error);
	}

	public static GdkPixbufHandle NewFromStreamAtScale(GInputStreamHandle stream, int width, int height, bool preserve_aspect_ratio, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GdkPixbufExterns.gdk_pixbuf_new_from_stream_at_scale(stream, width, height, preserve_aspect_ratio, cancellable, out error);
	}

	public static GdkPixbufHandle NewFromStreamFinish(GAsyncResultHandle async_result, out GErrorHandle error)
	{
		return GdkPixbufExterns.gdk_pixbuf_new_from_stream_finish(async_result, out error);
	}

	public static GdkPixbufHandle NewFromXpmData(string[] data)
	{
		return GdkPixbufExterns.gdk_pixbuf_new_from_xpm_data(data);
	}

	public static int CalculateRowstride(GdkColorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height)
	{
		return GdkPixbufExterns.gdk_pixbuf_calculate_rowstride(colorspace, has_alpha, bits_per_sample, width, height);
	}

	public static GdkPixbufFormatHandle GetFileInfo(string filename, out int width, out int height)
	{
		return GdkPixbufExterns.gdk_pixbuf_get_file_info(filename, out width, out height);
	}

	public static void GetFileInfoAsync(string filename, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GdkPixbufExterns.gdk_pixbuf_get_file_info_async(filename, cancellable, callback, user_data);
	}

	public static GdkPixbufFormatHandle GetFileInfoFinish(GAsyncResultHandle async_result, out int width, out int height, out GErrorHandle error)
	{
		return GdkPixbufExterns.gdk_pixbuf_get_file_info_finish(async_result, out width, out height, out error);
	}

	public static GSListHandle GetFormats()
	{
		return GdkPixbufExterns.gdk_pixbuf_get_formats();
	}

	public static bool InitModules(string path, out GErrorHandle error)
	{
		return GdkPixbufExterns.gdk_pixbuf_init_modules(path, out error);
	}

	public static void NewFromStreamAsync(GInputStreamHandle stream, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GdkPixbufExterns.gdk_pixbuf_new_from_stream_async(stream, cancellable, callback, user_data);
	}

	public static void NewFromStreamAtScaleAsync(GInputStreamHandle stream, int width, int height, bool preserve_aspect_ratio, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GdkPixbufExterns.gdk_pixbuf_new_from_stream_at_scale_async(stream, width, height, preserve_aspect_ratio, cancellable, callback, user_data);
	}

	public static bool SaveToStreamFinish(GAsyncResultHandle async_result, out GErrorHandle error)
	{
		return GdkPixbufExterns.gdk_pixbuf_save_to_stream_finish(async_result, out error);
	}

}

public static class GdkPixbufHandleExtensions
{
	public static GdkPixbufHandle AddAlpha(this GdkPixbufHandle pixbuf, bool substitute_color, char r, char g, char b)
	{
		return GdkPixbufExterns.gdk_pixbuf_add_alpha(pixbuf, substitute_color, r, g, b);
	}

	public static GdkPixbufHandle ApplyEmbeddedOrientation(this GdkPixbufHandle src)
	{
		return GdkPixbufExterns.gdk_pixbuf_apply_embedded_orientation(src);
	}

	public static GdkPixbufHandle Composite(this GdkPixbufHandle src, GdkPixbufHandle dest, int dest_x, int dest_y, int dest_width, int dest_height, double offset_x, double offset_y, double scale_x, double scale_y, GdkInterpType interp_type, int overall_alpha)
	{
		GdkPixbufExterns.gdk_pixbuf_composite(src, dest, dest_x, dest_y, dest_width, dest_height, offset_x, offset_y, scale_x, scale_y, interp_type, overall_alpha);
		return src;
	}

	public static GdkPixbufHandle CompositeColor(this GdkPixbufHandle src, GdkPixbufHandle dest, int dest_x, int dest_y, int dest_width, int dest_height, double offset_x, double offset_y, double scale_x, double scale_y, GdkInterpType interp_type, int overall_alpha, int check_x, int check_y, int check_size, uint color1, uint color2)
	{
		GdkPixbufExterns.gdk_pixbuf_composite_color(src, dest, dest_x, dest_y, dest_width, dest_height, offset_x, offset_y, scale_x, scale_y, interp_type, overall_alpha, check_x, check_y, check_size, color1, color2);
		return src;
	}

	public static GdkPixbufHandle CompositeColorSimple(this GdkPixbufHandle src, int dest_width, int dest_height, GdkInterpType interp_type, int overall_alpha, int check_size, uint color1, uint color2)
	{
		return GdkPixbufExterns.gdk_pixbuf_composite_color_simple(src, dest_width, dest_height, interp_type, overall_alpha, check_size, color1, color2);
	}

	public static GdkPixbufHandle Copy(this GdkPixbufHandle pixbuf)
	{
		return GdkPixbufExterns.gdk_pixbuf_copy(pixbuf);
	}

	public static GdkPixbufHandle CopyArea(this GdkPixbufHandle src_pixbuf, int src_x, int src_y, int width, int height, GdkPixbufHandle dest_pixbuf, int dest_x, int dest_y)
	{
		GdkPixbufExterns.gdk_pixbuf_copy_area(src_pixbuf, src_x, src_y, width, height, dest_pixbuf, dest_x, dest_y);
		return src_pixbuf;
	}

	public static bool CopyOptions(this GdkPixbufHandle src_pixbuf, GdkPixbufHandle dest_pixbuf)
	{
		return GdkPixbufExterns.gdk_pixbuf_copy_options(src_pixbuf, dest_pixbuf);
	}

	public static GdkPixbufHandle Fill(this GdkPixbufHandle pixbuf, uint pixel)
	{
		GdkPixbufExterns.gdk_pixbuf_fill(pixbuf, pixel);
		return pixbuf;
	}

	public static GdkPixbufHandle Flip(this GdkPixbufHandle src, bool horizontal)
	{
		return GdkPixbufExterns.gdk_pixbuf_flip(src, horizontal);
	}

	public static int GetBitsPerSample(this GdkPixbufHandle pixbuf)
	{
		return GdkPixbufExterns.gdk_pixbuf_get_bits_per_sample(pixbuf);
	}

	public static int GetByteLength(this GdkPixbufHandle pixbuf)
	{
		return GdkPixbufExterns.gdk_pixbuf_get_byte_length(pixbuf);
	}

	public static GdkColorspace GetColorspace(this GdkPixbufHandle pixbuf)
	{
		return GdkPixbufExterns.gdk_pixbuf_get_colorspace(pixbuf);
	}

	public static bool GetHasAlpha(this GdkPixbufHandle pixbuf)
	{
		return GdkPixbufExterns.gdk_pixbuf_get_has_alpha(pixbuf);
	}

	public static int GetHeight(this GdkPixbufHandle pixbuf)
	{
		return GdkPixbufExterns.gdk_pixbuf_get_height(pixbuf);
	}

	public static int GetNChannels(this GdkPixbufHandle pixbuf)
	{
		return GdkPixbufExterns.gdk_pixbuf_get_n_channels(pixbuf);
	}

	public static string GetOption(this GdkPixbufHandle pixbuf, string key)
	{
		return GdkPixbufExterns.gdk_pixbuf_get_option(pixbuf, key);
	}

	public static GHashTableHandle GetOptions(this GdkPixbufHandle pixbuf)
	{
		return GdkPixbufExterns.gdk_pixbuf_get_options(pixbuf);
	}

	public static string GetPixels(this GdkPixbufHandle pixbuf)
	{
		return GdkPixbufExterns.gdk_pixbuf_get_pixels(pixbuf);
	}

	public static string GetPixelsWithLength(this GdkPixbufHandle pixbuf, out uint length)
	{
		return GdkPixbufExterns.gdk_pixbuf_get_pixels_with_length(pixbuf, out length);
	}

	public static int GetRowstride(this GdkPixbufHandle pixbuf)
	{
		return GdkPixbufExterns.gdk_pixbuf_get_rowstride(pixbuf);
	}

	public static int GetWidth(this GdkPixbufHandle pixbuf)
	{
		return GdkPixbufExterns.gdk_pixbuf_get_width(pixbuf);
	}

	public static GdkPixbufHandle NewSubpixbuf(this GdkPixbufHandle src_pixbuf, int src_x, int src_y, int width, int height)
	{
		return GdkPixbufExterns.gdk_pixbuf_new_subpixbuf(src_pixbuf, src_x, src_y, width, height);
	}

	public static GBytesHandle ReadPixelBytes(this GdkPixbufHandle pixbuf)
	{
		return GdkPixbufExterns.gdk_pixbuf_read_pixel_bytes(pixbuf);
	}

	public static byte[] ReadPixels(this GdkPixbufHandle pixbuf)
	{
		return GdkPixbufExterns.gdk_pixbuf_read_pixels(pixbuf);
	}

	public static GdkPixbufHandle Ref(this GdkPixbufHandle pixbuf)
	{
		return GdkPixbufExterns.gdk_pixbuf_ref(pixbuf);
	}

	public static bool RemoveOption(this GdkPixbufHandle pixbuf, string key)
	{
		return GdkPixbufExterns.gdk_pixbuf_remove_option(pixbuf, key);
	}

	public static GdkPixbufHandle RotateSimple(this GdkPixbufHandle src, GdkPixbufRotation angle)
	{
		return GdkPixbufExterns.gdk_pixbuf_rotate_simple(src, angle);
	}

	public static GdkPixbufHandle SaturateAndPixelate(this GdkPixbufHandle src, GdkPixbufHandle dest, float saturation, bool pixelate)
	{
		GdkPixbufExterns.gdk_pixbuf_saturate_and_pixelate(src, dest, saturation, pixelate);
		return src;
	}

	public static bool Save(this GdkPixbufHandle pixbuf, string filename, string type, out GErrorHandle error, IntPtr @__arglist)
	{
		return GdkPixbufExterns.gdk_pixbuf_save(pixbuf, filename, type, out error, @__arglist);
	}

	public static bool SaveToBuffer(this GdkPixbufHandle pixbuf, out string buffer, out int buffer_size, string type, out GErrorHandle error, IntPtr @__arglist)
	{
		return GdkPixbufExterns.gdk_pixbuf_save_to_buffer(pixbuf, out buffer, out buffer_size, type, out error, @__arglist);
	}

	public static bool SaveToBufferv(this GdkPixbufHandle pixbuf, out string buffer, out int buffer_size, string type, string[] option_keys, string[] option_values, out GErrorHandle error)
	{
		return GdkPixbufExterns.gdk_pixbuf_save_to_bufferv(pixbuf, out buffer, out buffer_size, type, option_keys, option_values, out error);
	}

	public static bool SaveToCallback(this GdkPixbufHandle pixbuf, GdkPixbufSaveFunc save_func, IntPtr user_data, string type, out GErrorHandle error, IntPtr @__arglist)
	{
		return GdkPixbufExterns.gdk_pixbuf_save_to_callback(pixbuf, save_func, user_data, type, out error, @__arglist);
	}

	public static bool SaveToCallbackv(this GdkPixbufHandle pixbuf, GdkPixbufSaveFunc save_func, IntPtr user_data, string type, string[] option_keys, string[] option_values, out GErrorHandle error)
	{
		return GdkPixbufExterns.gdk_pixbuf_save_to_callbackv(pixbuf, save_func, user_data, type, option_keys, option_values, out error);
	}

	public static bool SaveToStream(this GdkPixbufHandle pixbuf, GOutputStreamHandle stream, string type, GCancellableHandle cancellable, out GErrorHandle error, IntPtr @__arglist)
	{
		return GdkPixbufExterns.gdk_pixbuf_save_to_stream(pixbuf, stream, type, cancellable, out error, @__arglist);
	}

	public static GdkPixbufHandle SaveToStreamAsync(this GdkPixbufHandle pixbuf, GOutputStreamHandle stream, string type, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data, IntPtr @__arglist)
	{
		GdkPixbufExterns.gdk_pixbuf_save_to_stream_async(pixbuf, stream, type, cancellable, callback, user_data, @__arglist);
		return pixbuf;
	}

	public static bool SaveToStreamv(this GdkPixbufHandle pixbuf, GOutputStreamHandle stream, string type, string[] option_keys, string[] option_values, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GdkPixbufExterns.gdk_pixbuf_save_to_streamv(pixbuf, stream, type, option_keys, option_values, cancellable, out error);
	}

	public static GdkPixbufHandle SaveToStreamvAsync(this GdkPixbufHandle pixbuf, GOutputStreamHandle stream, string type, string[] option_keys, string[] option_values, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GdkPixbufExterns.gdk_pixbuf_save_to_streamv_async(pixbuf, stream, type, option_keys, option_values, cancellable, callback, user_data);
		return pixbuf;
	}

	public static bool Savev(this GdkPixbufHandle pixbuf, string filename, string type, string[] option_keys, string[] option_values, out GErrorHandle error)
	{
		return GdkPixbufExterns.gdk_pixbuf_savev(pixbuf, filename, type, option_keys, option_values, out error);
	}

	public static GdkPixbufHandle Scale(this GdkPixbufHandle src, GdkPixbufHandle dest, int dest_x, int dest_y, int dest_width, int dest_height, double offset_x, double offset_y, double scale_x, double scale_y, GdkInterpType interp_type)
	{
		GdkPixbufExterns.gdk_pixbuf_scale(src, dest, dest_x, dest_y, dest_width, dest_height, offset_x, offset_y, scale_x, scale_y, interp_type);
		return src;
	}

	public static GdkPixbufHandle ScaleSimple(this GdkPixbufHandle src, int dest_width, int dest_height, GdkInterpType interp_type)
	{
		return GdkPixbufExterns.gdk_pixbuf_scale_simple(src, dest_width, dest_height, interp_type);
	}

	public static bool SetOption(this GdkPixbufHandle pixbuf, string key, string value)
	{
		return GdkPixbufExterns.gdk_pixbuf_set_option(pixbuf, key, value);
	}

	public static GdkPixbufHandle Unref(this GdkPixbufHandle pixbuf)
	{
		GdkPixbufExterns.gdk_pixbuf_unref(pixbuf);
		return pixbuf;
	}

}

internal class GdkPixbufExterns
{
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufHandle gdk_pixbuf_new(GdkColorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufHandle gdk_pixbuf_new_from_bytes(GBytesHandle data, GdkColorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height, int rowstride);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufHandle gdk_pixbuf_new_from_data(string data, GdkColorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height, int rowstride, GdkPixbufDestroyNotify destroy_fn, IntPtr destroy_fn_data);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufHandle gdk_pixbuf_new_from_file(string filename, out GErrorHandle error);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufHandle gdk_pixbuf_new_from_file_at_scale(string filename, int width, int height, bool preserve_aspect_ratio, out GErrorHandle error);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufHandle gdk_pixbuf_new_from_file_at_size(string filename, int width, int height, out GErrorHandle error);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufHandle gdk_pixbuf_new_from_inline(int data_length, byte[] data, bool copy_pixels, out GErrorHandle error);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufHandle gdk_pixbuf_new_from_resource(string resource_path, out GErrorHandle error);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufHandle gdk_pixbuf_new_from_resource_at_scale(string resource_path, int width, int height, bool preserve_aspect_ratio, out GErrorHandle error);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufHandle gdk_pixbuf_new_from_stream(GInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufHandle gdk_pixbuf_new_from_stream_at_scale(GInputStreamHandle stream, int width, int height, bool preserve_aspect_ratio, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufHandle gdk_pixbuf_new_from_stream_finish(GAsyncResultHandle async_result, out GErrorHandle error);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufHandle gdk_pixbuf_new_from_xpm_data(string[] data);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufHandle gdk_pixbuf_add_alpha(GdkPixbufHandle pixbuf, bool substitute_color, char r, char g, char b);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufHandle gdk_pixbuf_apply_embedded_orientation(GdkPixbufHandle src);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern void gdk_pixbuf_composite(GdkPixbufHandle src, GdkPixbufHandle dest, int dest_x, int dest_y, int dest_width, int dest_height, double offset_x, double offset_y, double scale_x, double scale_y, GdkInterpType interp_type, int overall_alpha);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern void gdk_pixbuf_composite_color(GdkPixbufHandle src, GdkPixbufHandle dest, int dest_x, int dest_y, int dest_width, int dest_height, double offset_x, double offset_y, double scale_x, double scale_y, GdkInterpType interp_type, int overall_alpha, int check_x, int check_y, int check_size, uint color1, uint color2);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufHandle gdk_pixbuf_composite_color_simple(GdkPixbufHandle src, int dest_width, int dest_height, GdkInterpType interp_type, int overall_alpha, int check_size, uint color1, uint color2);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufHandle gdk_pixbuf_copy(GdkPixbufHandle pixbuf);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern void gdk_pixbuf_copy_area(GdkPixbufHandle src_pixbuf, int src_x, int src_y, int width, int height, GdkPixbufHandle dest_pixbuf, int dest_x, int dest_y);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern bool gdk_pixbuf_copy_options(GdkPixbufHandle src_pixbuf, GdkPixbufHandle dest_pixbuf);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern void gdk_pixbuf_fill(GdkPixbufHandle pixbuf, uint pixel);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufHandle gdk_pixbuf_flip(GdkPixbufHandle src, bool horizontal);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern int gdk_pixbuf_get_bits_per_sample(GdkPixbufHandle pixbuf);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern int gdk_pixbuf_get_byte_length(GdkPixbufHandle pixbuf);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkColorspace gdk_pixbuf_get_colorspace(GdkPixbufHandle pixbuf);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern bool gdk_pixbuf_get_has_alpha(GdkPixbufHandle pixbuf);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern int gdk_pixbuf_get_height(GdkPixbufHandle pixbuf);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern int gdk_pixbuf_get_n_channels(GdkPixbufHandle pixbuf);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern string gdk_pixbuf_get_option(GdkPixbufHandle pixbuf, string key);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GHashTableHandle gdk_pixbuf_get_options(GdkPixbufHandle pixbuf);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern string gdk_pixbuf_get_pixels(GdkPixbufHandle pixbuf);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern string gdk_pixbuf_get_pixels_with_length(GdkPixbufHandle pixbuf, out uint length);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern int gdk_pixbuf_get_rowstride(GdkPixbufHandle pixbuf);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern int gdk_pixbuf_get_width(GdkPixbufHandle pixbuf);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufHandle gdk_pixbuf_new_subpixbuf(GdkPixbufHandle src_pixbuf, int src_x, int src_y, int width, int height);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GBytesHandle gdk_pixbuf_read_pixel_bytes(GdkPixbufHandle pixbuf);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern byte[] gdk_pixbuf_read_pixels(GdkPixbufHandle pixbuf);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufHandle gdk_pixbuf_ref(GdkPixbufHandle pixbuf);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern bool gdk_pixbuf_remove_option(GdkPixbufHandle pixbuf, string key);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufHandle gdk_pixbuf_rotate_simple(GdkPixbufHandle src, GdkPixbufRotation angle);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern void gdk_pixbuf_saturate_and_pixelate(GdkPixbufHandle src, GdkPixbufHandle dest, float saturation, bool pixelate);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern bool gdk_pixbuf_save(GdkPixbufHandle pixbuf, string filename, string type, out GErrorHandle error, IntPtr @__arglist);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern bool gdk_pixbuf_save_to_buffer(GdkPixbufHandle pixbuf, out string buffer, out int buffer_size, string type, out GErrorHandle error, IntPtr @__arglist);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern bool gdk_pixbuf_save_to_bufferv(GdkPixbufHandle pixbuf, out string buffer, out int buffer_size, string type, string[] option_keys, string[] option_values, out GErrorHandle error);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern bool gdk_pixbuf_save_to_callback(GdkPixbufHandle pixbuf, GdkPixbufSaveFunc save_func, IntPtr user_data, string type, out GErrorHandle error, IntPtr @__arglist);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern bool gdk_pixbuf_save_to_callbackv(GdkPixbufHandle pixbuf, GdkPixbufSaveFunc save_func, IntPtr user_data, string type, string[] option_keys, string[] option_values, out GErrorHandle error);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern bool gdk_pixbuf_save_to_stream(GdkPixbufHandle pixbuf, GOutputStreamHandle stream, string type, GCancellableHandle cancellable, out GErrorHandle error, IntPtr @__arglist);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern void gdk_pixbuf_save_to_stream_async(GdkPixbufHandle pixbuf, GOutputStreamHandle stream, string type, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data, IntPtr @__arglist);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern bool gdk_pixbuf_save_to_streamv(GdkPixbufHandle pixbuf, GOutputStreamHandle stream, string type, string[] option_keys, string[] option_values, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern void gdk_pixbuf_save_to_streamv_async(GdkPixbufHandle pixbuf, GOutputStreamHandle stream, string type, string[] option_keys, string[] option_values, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern bool gdk_pixbuf_savev(GdkPixbufHandle pixbuf, string filename, string type, string[] option_keys, string[] option_values, out GErrorHandle error);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern void gdk_pixbuf_scale(GdkPixbufHandle src, GdkPixbufHandle dest, int dest_x, int dest_y, int dest_width, int dest_height, double offset_x, double offset_y, double scale_x, double scale_y, GdkInterpType interp_type);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufHandle gdk_pixbuf_scale_simple(GdkPixbufHandle src, int dest_width, int dest_height, GdkInterpType interp_type);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern bool gdk_pixbuf_set_option(GdkPixbufHandle pixbuf, string key, string value);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern void gdk_pixbuf_unref(GdkPixbufHandle pixbuf);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern int gdk_pixbuf_calculate_rowstride(GdkColorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufFormatHandle gdk_pixbuf_get_file_info(string filename, out int width, out int height);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern void gdk_pixbuf_get_file_info_async(string filename, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufFormatHandle gdk_pixbuf_get_file_info_finish(GAsyncResultHandle async_result, out int width, out int height, out GErrorHandle error);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GSListHandle gdk_pixbuf_get_formats();
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern bool gdk_pixbuf_init_modules(string path, out GErrorHandle error);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern void gdk_pixbuf_new_from_stream_async(GInputStreamHandle stream, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern void gdk_pixbuf_new_from_stream_at_scale_async(GInputStreamHandle stream, int width, int height, bool preserve_aspect_ratio, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern bool gdk_pixbuf_save_to_stream_finish(GAsyncResultHandle async_result, out GErrorHandle error);
}
