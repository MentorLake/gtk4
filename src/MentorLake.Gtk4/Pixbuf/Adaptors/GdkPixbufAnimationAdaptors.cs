using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Pixbuf;
public static class GdkPixbufAnimationAdaptors
{
	public static GdkPixbufAnimationHandle Ref(this GdkPixbufAnimationHandle animation)
	{
		return GdkPixbufAnimationExterns.gdk_pixbuf_animation_ref(animation);
	}

	public static GdkPixbufAnimationHandle Unref(this GdkPixbufAnimationHandle animation)
	{
		GdkPixbufAnimationExterns.gdk_pixbuf_animation_unref(animation);
		return animation;
	}

	public static int GetWidth(this GdkPixbufAnimationHandle animation)
	{
		return GdkPixbufAnimationExterns.gdk_pixbuf_animation_get_width(animation);
	}

	public static int GetHeight(this GdkPixbufAnimationHandle animation)
	{
		return GdkPixbufAnimationExterns.gdk_pixbuf_animation_get_height(animation);
	}

	public static int IsStaticImage(this GdkPixbufAnimationHandle animation)
	{
		return GdkPixbufAnimationExterns.gdk_pixbuf_animation_is_static_image(animation);
	}

	public static GdkPixbufHandle GetStaticImage(this GdkPixbufAnimationHandle animation)
	{
		return GdkPixbufAnimationExterns.gdk_pixbuf_animation_get_static_image(animation);
	}

	public static GdkPixbufAnimationIterHandle GetIter(this GdkPixbufAnimationHandle animation, GTimeValHandle start_time)
	{
		return GdkPixbufAnimationExterns.gdk_pixbuf_animation_get_iter(animation, start_time);
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
