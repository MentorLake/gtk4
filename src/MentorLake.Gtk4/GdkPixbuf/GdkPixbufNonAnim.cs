namespace MentorLake.Gtk4.GdkPixbuf;

public class GdkPixbufNonAnimHandle : GdkPixbufAnimationHandle
{
	public static GdkPixbufNonAnimHandle New(GdkPixbufHandle pixbuf)
	{
		return GdkPixbufNonAnimExterns.gdk_pixbuf_non_anim_new(pixbuf);
	}

}

public static class GdkPixbufNonAnimHandleExtensions
{
}

internal class GdkPixbufNonAnimExterns
{
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufNonAnimHandle gdk_pixbuf_non_anim_new(GdkPixbufHandle pixbuf);

}
