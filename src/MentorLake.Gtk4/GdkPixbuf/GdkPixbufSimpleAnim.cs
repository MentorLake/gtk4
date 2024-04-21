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

public class GdkPixbufSimpleAnimHandle : GdkPixbufAnimationHandle
{
	public static GdkPixbufSimpleAnimHandle New(int width, int height, float rate)
	{
		return GdkPixbufSimpleAnimExterns.gdk_pixbuf_simple_anim_new(width, height, rate);
	}

}

public static class GdkPixbufSimpleAnimHandleExtensions
{
	public static GdkPixbufSimpleAnimHandle AddFrame(this GdkPixbufSimpleAnimHandle animation, GdkPixbufHandle pixbuf)
	{
		GdkPixbufSimpleAnimExterns.gdk_pixbuf_simple_anim_add_frame(animation, pixbuf);
		return animation;
	}

	public static bool GetLoop(this GdkPixbufSimpleAnimHandle animation)
	{
		return GdkPixbufSimpleAnimExterns.gdk_pixbuf_simple_anim_get_loop(animation);
	}

	public static GdkPixbufSimpleAnimHandle SetLoop(this GdkPixbufSimpleAnimHandle animation, bool loop)
	{
		GdkPixbufSimpleAnimExterns.gdk_pixbuf_simple_anim_set_loop(animation, loop);
		return animation;
	}

}

internal class GdkPixbufSimpleAnimExterns
{
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufSimpleAnimHandle gdk_pixbuf_simple_anim_new(int width, int height, float rate);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern void gdk_pixbuf_simple_anim_add_frame(GdkPixbufSimpleAnimHandle animation, GdkPixbufHandle pixbuf);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern bool gdk_pixbuf_simple_anim_get_loop(GdkPixbufSimpleAnimHandle animation);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern void gdk_pixbuf_simple_anim_set_loop(GdkPixbufSimpleAnimHandle animation, bool loop);

}
