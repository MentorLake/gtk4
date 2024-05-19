namespace MentorLake.Gtk4.GdkPixbuf;

public class GdkPixbufAnimationIterHandle : GObjectHandle
{
}

public static class GdkPixbufAnimationIterHandleExtensions
{
	public static bool Advance(this GdkPixbufAnimationIterHandle iter, GTimeValHandle current_time)
	{
		return GdkPixbufAnimationIterExterns.gdk_pixbuf_animation_iter_advance(iter, current_time);
	}

	public static int GetDelayTime(this GdkPixbufAnimationIterHandle iter)
	{
		return GdkPixbufAnimationIterExterns.gdk_pixbuf_animation_iter_get_delay_time(iter);
	}

	public static GdkPixbufHandle GetPixbuf(this GdkPixbufAnimationIterHandle iter)
	{
		return GdkPixbufAnimationIterExterns.gdk_pixbuf_animation_iter_get_pixbuf(iter);
	}

	public static bool OnCurrentlyLoadingFrame(this GdkPixbufAnimationIterHandle iter)
	{
		return GdkPixbufAnimationIterExterns.gdk_pixbuf_animation_iter_on_currently_loading_frame(iter);
	}

}

internal class GdkPixbufAnimationIterExterns
{
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern bool gdk_pixbuf_animation_iter_advance(GdkPixbufAnimationIterHandle iter, GTimeValHandle current_time);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern int gdk_pixbuf_animation_iter_get_delay_time(GdkPixbufAnimationIterHandle iter);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufHandle gdk_pixbuf_animation_iter_get_pixbuf(GdkPixbufAnimationIterHandle iter);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern bool gdk_pixbuf_animation_iter_on_currently_loading_frame(GdkPixbufAnimationIterHandle iter);

}
