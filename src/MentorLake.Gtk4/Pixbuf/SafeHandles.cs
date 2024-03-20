using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Pixbuf;
public class GdkPixbufAnimationIterHandle : GObjectHandle
{
}

public class GdkPixbufSimpleAnimHandle : GObjectHandle
{
	public static GdkPixbufSimpleAnimHandle New(int width, int height, float rate)
	{
		return GdkPixbufSimpleAnimExterns.gdk_pixbuf_simple_anim_new(width, height, rate);
	}
}

public class GdkPixbufHandle : GObjectHandle
{
	public static GdkPixbufHandle New(GdkColorspace colorspace, int has_alpha, int bits_per_sample, int width, int height)
	{
		return GdkPixbufExterns.gdk_pixbuf_new(colorspace, has_alpha, bits_per_sample, width, height);
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

public class GdkPixbufLoaderClassHandle : GObjectHandle
{
}

public class GdkPixbufAnimationHandle : GObjectHandle
{
	public static GdkPixbufAnimationHandle NewFromFile(string filename, out GErrorHandle error)
	{
		return GdkPixbufAnimationExterns.gdk_pixbuf_animation_new_from_file(filename, out error);
	}

	public static GdkPixbufAnimationHandle NewFromStream(GInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GdkPixbufAnimationExterns.gdk_pixbuf_animation_new_from_stream(stream, cancellable, out error);
	}

	public static GdkPixbufAnimationHandle NewFromResource(string resource_path, out GErrorHandle error)
	{
		return GdkPixbufAnimationExterns.gdk_pixbuf_animation_new_from_resource(resource_path, out error);
	}
}

public class GdkPixbufFormatHandle : GObjectHandle
{
}

public class GdkPixbufSimpleAnimClassHandle : GObjectHandle
{
}

public class GdkPixbufLoaderHandle : GObjectHandle
{
	public static GdkPixbufLoaderHandle New()
	{
		return GdkPixbufLoaderExterns.gdk_pixbuf_loader_new();
	}

	public static GdkPixbufLoaderHandle NewWithType(string image_type, out GErrorHandle error)
	{
		return GdkPixbufLoaderExterns.gdk_pixbuf_loader_new_with_type(image_type, out error);
	}

	public static GdkPixbufLoaderHandle NewWithMimeType(string mime_type, out GErrorHandle error)
	{
		return GdkPixbufLoaderExterns.gdk_pixbuf_loader_new_with_mime_type(mime_type, out error);
	}
}
