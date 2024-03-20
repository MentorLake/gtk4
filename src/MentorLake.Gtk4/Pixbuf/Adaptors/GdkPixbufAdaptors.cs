using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Pixbuf;
public static class GdkPixbufAdaptors
{
	public static GdkPixbufHandle Ref(this GdkPixbufHandle pixbuf)
	{
		return GdkPixbufExterns.gdk_pixbuf_ref(pixbuf);
	}

	public static GdkPixbufHandle Unref(this GdkPixbufHandle pixbuf)
	{
		GdkPixbufExterns.gdk_pixbuf_unref(pixbuf);
		return pixbuf;
	}

	public static GdkColorspace GetColorspace(this GdkPixbufHandle pixbuf)
	{
		return GdkPixbufExterns.gdk_pixbuf_get_colorspace(pixbuf);
	}

	public static int GetNChannels(this GdkPixbufHandle pixbuf)
	{
		return GdkPixbufExterns.gdk_pixbuf_get_n_channels(pixbuf);
	}

	public static int GetHasAlpha(this GdkPixbufHandle pixbuf)
	{
		return GdkPixbufExterns.gdk_pixbuf_get_has_alpha(pixbuf);
	}

	public static int GetBitsPerSample(this GdkPixbufHandle pixbuf)
	{
		return GdkPixbufExterns.gdk_pixbuf_get_bits_per_sample(pixbuf);
	}

	public static string GetPixels(this GdkPixbufHandle pixbuf)
	{
		return GdkPixbufExterns.gdk_pixbuf_get_pixels(pixbuf);
	}

	public static int GetWidth(this GdkPixbufHandle pixbuf)
	{
		return GdkPixbufExterns.gdk_pixbuf_get_width(pixbuf);
	}

	public static int GetHeight(this GdkPixbufHandle pixbuf)
	{
		return GdkPixbufExterns.gdk_pixbuf_get_height(pixbuf);
	}

	public static int GetRowstride(this GdkPixbufHandle pixbuf)
	{
		return GdkPixbufExterns.gdk_pixbuf_get_rowstride(pixbuf);
	}

	public static nuint GetByteLength(this GdkPixbufHandle pixbuf)
	{
		return GdkPixbufExterns.gdk_pixbuf_get_byte_length(pixbuf);
	}

	public static byte[] GetPixelsWithLength(this GdkPixbufHandle pixbuf, out uint length)
	{
		return GdkPixbufExterns.gdk_pixbuf_get_pixels_with_length(pixbuf, out length);
	}

	public static byte[] ReadPixels(this GdkPixbufHandle pixbuf)
	{
		return GdkPixbufExterns.gdk_pixbuf_read_pixels(pixbuf);
	}

	public static GBytesHandle ReadPixelBytes(this GdkPixbufHandle pixbuf)
	{
		return GdkPixbufExterns.gdk_pixbuf_read_pixel_bytes(pixbuf);
	}

	public static GdkPixbufHandle Copy(this GdkPixbufHandle pixbuf)
	{
		return GdkPixbufExterns.gdk_pixbuf_copy(pixbuf);
	}

	public static GdkPixbufHandle NewSubpixbuf(this GdkPixbufHandle src_pixbuf, int src_x, int src_y, int width, int height)
	{
		return GdkPixbufExterns.gdk_pixbuf_new_subpixbuf(src_pixbuf, src_x, src_y, width, height);
	}

	public static GdkPixbufHandle Fill(this GdkPixbufHandle pixbuf, uint pixel)
	{
		GdkPixbufExterns.gdk_pixbuf_fill(pixbuf, pixel);
		return pixbuf;
	}

	public static int Save(this GdkPixbufHandle pixbuf, string filename, string type, out GErrorHandle error, IntPtr @__argList)
	{
		return GdkPixbufExterns.gdk_pixbuf_save(pixbuf, filename, type, out error, @__argList);
	}

	public static int Savev(this GdkPixbufHandle pixbuf, string filename, string type, string[] option_keys, string[] option_values, out GErrorHandle error)
	{
		return GdkPixbufExterns.gdk_pixbuf_savev(pixbuf, filename, type, option_keys, option_values, out error);
	}

	public static int SaveToCallback(this GdkPixbufHandle pixbuf, GdkPixbufSaveFunc save_func, IntPtr user_data, string type, out GErrorHandle error, IntPtr @__argList)
	{
		return GdkPixbufExterns.gdk_pixbuf_save_to_callback(pixbuf, save_func, user_data, type, out error, @__argList);
	}

	public static int SaveToCallbackv(this GdkPixbufHandle pixbuf, GdkPixbufSaveFunc save_func, IntPtr user_data, string type, string[] option_keys, string[] option_values, out GErrorHandle error)
	{
		return GdkPixbufExterns.gdk_pixbuf_save_to_callbackv(pixbuf, save_func, user_data, type, option_keys, option_values, out error);
	}

	public static int SaveToBuffer(this GdkPixbufHandle pixbuf, byte[] buffer, out nuint buffer_size, string type, out GErrorHandle error, IntPtr @__argList)
	{
		return GdkPixbufExterns.gdk_pixbuf_save_to_buffer(pixbuf, buffer, out buffer_size, type, out error, @__argList);
	}

	public static int SaveToBufferv(this GdkPixbufHandle pixbuf, byte[] buffer, out nuint buffer_size, string type, string[] option_keys, string[] option_values, out GErrorHandle error)
	{
		return GdkPixbufExterns.gdk_pixbuf_save_to_bufferv(pixbuf, buffer, out buffer_size, type, option_keys, option_values, out error);
	}

	public static int SaveToStream(this GdkPixbufHandle pixbuf, GOutputStreamHandle stream, string type, GCancellableHandle cancellable, out GErrorHandle error, IntPtr @__argList)
	{
		return GdkPixbufExterns.gdk_pixbuf_save_to_stream(pixbuf, stream, type, cancellable, out error, @__argList);
	}

	public static GdkPixbufHandle SaveToStreamAsync(this GdkPixbufHandle pixbuf, GOutputStreamHandle stream, string type, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data, IntPtr @__argList)
	{
		GdkPixbufExterns.gdk_pixbuf_save_to_stream_async(pixbuf, stream, type, cancellable, callback, user_data, @__argList);
		return pixbuf;
	}

	public static GdkPixbufHandle SaveToStreamvAsync(this GdkPixbufHandle pixbuf, GOutputStreamHandle stream, string type, string[] option_keys, string[] option_values, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GdkPixbufExterns.gdk_pixbuf_save_to_streamv_async(pixbuf, stream, type, option_keys, option_values, cancellable, callback, user_data);
		return pixbuf;
	}

	public static int SaveToStreamv(this GdkPixbufHandle pixbuf, GOutputStreamHandle stream, string type, string[] option_keys, string[] option_values, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GdkPixbufExterns.gdk_pixbuf_save_to_streamv(pixbuf, stream, type, option_keys, option_values, cancellable, out error);
	}

	public static GdkPixbufHandle AddAlpha(this GdkPixbufHandle pixbuf, int substitute_color, char r, char g, char b)
	{
		return GdkPixbufExterns.gdk_pixbuf_add_alpha(pixbuf, substitute_color, r, g, b);
	}

	public static GdkPixbufHandle CopyArea(this GdkPixbufHandle src_pixbuf, int src_x, int src_y, int width, int height, GdkPixbufHandle dest_pixbuf, int dest_x, int dest_y)
	{
		GdkPixbufExterns.gdk_pixbuf_copy_area(src_pixbuf, src_x, src_y, width, height, dest_pixbuf, dest_x, dest_y);
		return src_pixbuf;
	}

	public static GdkPixbufHandle SaturateAndPixelate(this GdkPixbufHandle src, GdkPixbufHandle dest, float saturation, int pixelate)
	{
		GdkPixbufExterns.gdk_pixbuf_saturate_and_pixelate(src, dest, saturation, pixelate);
		return src;
	}

	public static GdkPixbufHandle ApplyEmbeddedOrientation(this GdkPixbufHandle src)
	{
		return GdkPixbufExterns.gdk_pixbuf_apply_embedded_orientation(src);
	}

	public static int SetOption(this GdkPixbufHandle pixbuf, string key, string value)
	{
		return GdkPixbufExterns.gdk_pixbuf_set_option(pixbuf, key, value);
	}

	public static string GetOption(this GdkPixbufHandle pixbuf, string key)
	{
		return GdkPixbufExterns.gdk_pixbuf_get_option(pixbuf, key);
	}

	public static int RemoveOption(this GdkPixbufHandle pixbuf, string key)
	{
		return GdkPixbufExterns.gdk_pixbuf_remove_option(pixbuf, key);
	}

	public static GHashTableHandle GetOptions(this GdkPixbufHandle pixbuf)
	{
		return GdkPixbufExterns.gdk_pixbuf_get_options(pixbuf);
	}

	public static int CopyOptions(this GdkPixbufHandle src_pixbuf, GdkPixbufHandle dest_pixbuf)
	{
		return GdkPixbufExterns.gdk_pixbuf_copy_options(src_pixbuf, dest_pixbuf);
	}

	public static GdkPixbufHandle Scale(this GdkPixbufHandle src, GdkPixbufHandle dest, int dest_x, int dest_y, int dest_width, int dest_height, double offset_x, double offset_y, double scale_x, double scale_y, GdkInterpType interp_type)
	{
		GdkPixbufExterns.gdk_pixbuf_scale(src, dest, dest_x, dest_y, dest_width, dest_height, offset_x, offset_y, scale_x, scale_y, interp_type);
		return src;
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

	public static GdkPixbufHandle ScaleSimple(this GdkPixbufHandle src, int dest_width, int dest_height, GdkInterpType interp_type)
	{
		return GdkPixbufExterns.gdk_pixbuf_scale_simple(src, dest_width, dest_height, interp_type);
	}

	public static GdkPixbufHandle CompositeColorSimple(this GdkPixbufHandle src, int dest_width, int dest_height, GdkInterpType interp_type, int overall_alpha, int check_size, uint color1, uint color2)
	{
		return GdkPixbufExterns.gdk_pixbuf_composite_color_simple(src, dest_width, dest_height, interp_type, overall_alpha, check_size, color1, color2);
	}

	public static GdkPixbufHandle RotateSimple(this GdkPixbufHandle src, GdkPixbufRotation angle)
	{
		return GdkPixbufExterns.gdk_pixbuf_rotate_simple(src, angle);
	}

	public static GdkPixbufHandle Flip(this GdkPixbufHandle src, int horizontal)
	{
		return GdkPixbufExterns.gdk_pixbuf_flip(src, horizontal);
	}

	public static GdkPixbufHandle NewFromFile(string filename, out GErrorHandle error)
	{
		return GdkPixbufExterns.gdk_pixbuf_new_from_file(filename, out error);
	}

	public static GdkPixbufHandle NewFromFileAtSize(string filename, int width, int height, out GErrorHandle error)
	{
		return GdkPixbufExterns.gdk_pixbuf_new_from_file_at_size(filename, width, height, out error);
	}

	public static GdkPixbufHandle NewFromFileAtScale(string filename, int width, int height, int preserve_aspect_ratio, out GErrorHandle error)
	{
		return GdkPixbufExterns.gdk_pixbuf_new_from_file_at_scale(filename, width, height, preserve_aspect_ratio, out error);
	}

	public static GdkPixbufHandle NewFromResource(string resource_path, out GErrorHandle error)
	{
		return GdkPixbufExterns.gdk_pixbuf_new_from_resource(resource_path, out error);
	}

	public static GdkPixbufHandle NewFromResourceAtScale(string resource_path, int width, int height, int preserve_aspect_ratio, out GErrorHandle error)
	{
		return GdkPixbufExterns.gdk_pixbuf_new_from_resource_at_scale(resource_path, width, height, preserve_aspect_ratio, out error);
	}

	public static GdkPixbufHandle NewFromData(string data, GdkColorspace colorspace, int has_alpha, int bits_per_sample, int width, int height, int rowstride, GdkPixbufDestroyNotify destroy_fn, IntPtr destroy_fn_data)
	{
		return GdkPixbufExterns.gdk_pixbuf_new_from_data(data, colorspace, has_alpha, bits_per_sample, width, height, rowstride, destroy_fn, destroy_fn_data);
	}

	public static GdkPixbufHandle NewFromBytes(GBytesHandle data, GdkColorspace colorspace, int has_alpha, int bits_per_sample, int width, int height, int rowstride)
	{
		return GdkPixbufExterns.gdk_pixbuf_new_from_bytes(data, colorspace, has_alpha, bits_per_sample, width, height, rowstride);
	}

	public static GdkPixbufHandle NewFromXpmData(string data)
	{
		return GdkPixbufExterns.gdk_pixbuf_new_from_xpm_data(data);
	}

	public static GdkPixbufHandle NewFromInline(int data_length, byte[] data, int copy_pixels, out GErrorHandle error)
	{
		return GdkPixbufExterns.gdk_pixbuf_new_from_inline(data_length, data, copy_pixels, out error);
	}

	public static GdkPixbufHandle NewFromStream(GInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GdkPixbufExterns.gdk_pixbuf_new_from_stream(stream, cancellable, out error);
	}

	public static GdkPixbufHandle NewFromStreamFinish(GAsyncResultHandle async_result, out GErrorHandle error)
	{
		return GdkPixbufExterns.gdk_pixbuf_new_from_stream_finish(async_result, out error);
	}

	public static GdkPixbufHandle NewFromStreamAtScale(GInputStreamHandle stream, int width, int height, int preserve_aspect_ratio, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GdkPixbufExterns.gdk_pixbuf_new_from_stream_at_scale(stream, width, height, preserve_aspect_ratio, cancellable, out error);
	}
}
