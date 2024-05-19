namespace MentorLake.Gtk4.GdkPixbuf;

public class GdkPixbufAnimationHandle : GObjectHandle
{
	public static GdkPixbufAnimationHandle NewFromFile(string filename, out GErrorHandle error)
	{
		return GdkPixbufAnimationExterns.gdk_pixbuf_animation_new_from_file(filename, out error);
	}

	public static GdkPixbufAnimationHandle NewFromResource(string resource_path, out GErrorHandle error)
	{
		return GdkPixbufAnimationExterns.gdk_pixbuf_animation_new_from_resource(resource_path, out error);
	}

	public static GdkPixbufAnimationHandle NewFromStream(GInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GdkPixbufAnimationExterns.gdk_pixbuf_animation_new_from_stream(stream, cancellable, out error);
	}

	public static GdkPixbufAnimationHandle NewFromStreamFinish(GAsyncResultHandle async_result, out GErrorHandle error)
	{
		return GdkPixbufAnimationExterns.gdk_pixbuf_animation_new_from_stream_finish(async_result, out error);
	}

	public static void NewFromStreamAsync(GInputStreamHandle stream, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GdkPixbufAnimationExterns.gdk_pixbuf_animation_new_from_stream_async(stream, cancellable, callback, user_data);
	}

}

public static class GdkPixbufAnimationHandleExtensions
{
	public static int GetHeight(this GdkPixbufAnimationHandle animation)
	{
		return GdkPixbufAnimationExterns.gdk_pixbuf_animation_get_height(animation);
	}

	public static GdkPixbufAnimationIterHandle GetIter(this GdkPixbufAnimationHandle animation, GTimeValHandle start_time)
	{
		return GdkPixbufAnimationExterns.gdk_pixbuf_animation_get_iter(animation, start_time);
	}

	public static GdkPixbufHandle GetStaticImage(this GdkPixbufAnimationHandle animation)
	{
		return GdkPixbufAnimationExterns.gdk_pixbuf_animation_get_static_image(animation);
	}

	public static int GetWidth(this GdkPixbufAnimationHandle animation)
	{
		return GdkPixbufAnimationExterns.gdk_pixbuf_animation_get_width(animation);
	}

	public static bool IsStaticImage(this GdkPixbufAnimationHandle animation)
	{
		return GdkPixbufAnimationExterns.gdk_pixbuf_animation_is_static_image(animation);
	}

	public static GdkPixbufAnimationHandle Ref(this GdkPixbufAnimationHandle animation)
	{
		return GdkPixbufAnimationExterns.gdk_pixbuf_animation_ref(animation);
	}

	public static GdkPixbufAnimationHandle Unref(this GdkPixbufAnimationHandle animation)
	{
		GdkPixbufAnimationExterns.gdk_pixbuf_animation_unref(animation);
		return animation;
	}

}

internal class GdkPixbufAnimationExterns
{
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufAnimationHandle gdk_pixbuf_animation_new_from_file(string filename, out GErrorHandle error);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufAnimationHandle gdk_pixbuf_animation_new_from_resource(string resource_path, out GErrorHandle error);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufAnimationHandle gdk_pixbuf_animation_new_from_stream(GInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufAnimationHandle gdk_pixbuf_animation_new_from_stream_finish(GAsyncResultHandle async_result, out GErrorHandle error);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern int gdk_pixbuf_animation_get_height(GdkPixbufAnimationHandle animation);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufAnimationIterHandle gdk_pixbuf_animation_get_iter(GdkPixbufAnimationHandle animation, GTimeValHandle start_time);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufHandle gdk_pixbuf_animation_get_static_image(GdkPixbufAnimationHandle animation);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern int gdk_pixbuf_animation_get_width(GdkPixbufAnimationHandle animation);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern bool gdk_pixbuf_animation_is_static_image(GdkPixbufAnimationHandle animation);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufAnimationHandle gdk_pixbuf_animation_ref(GdkPixbufAnimationHandle animation);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern void gdk_pixbuf_animation_unref(GdkPixbufAnimationHandle animation);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern void gdk_pixbuf_animation_new_from_stream_async(GInputStreamHandle stream, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

}
