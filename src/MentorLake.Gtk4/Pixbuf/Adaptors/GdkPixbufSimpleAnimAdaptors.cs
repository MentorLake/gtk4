using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pixbuf;
public static class GdkPixbufSimpleAnimAdaptors
{
	public static GdkPixbufSimpleAnimHandle AddFrame(this GdkPixbufSimpleAnimHandle animation, GdkPixbufHandle pixbuf)
	{
		GdkPixbufSimpleAnimExterns.gdk_pixbuf_simple_anim_add_frame(animation, pixbuf);
		return animation;
	}

	public static GdkPixbufSimpleAnimHandle SetLoop(this GdkPixbufSimpleAnimHandle animation, int loop)
	{
		GdkPixbufSimpleAnimExterns.gdk_pixbuf_simple_anim_set_loop(animation, loop);
		return animation;
	}

	public static int GetLoop(this GdkPixbufSimpleAnimHandle animation)
	{
		return GdkPixbufSimpleAnimExterns.gdk_pixbuf_simple_anim_get_loop(animation);
	}
}
