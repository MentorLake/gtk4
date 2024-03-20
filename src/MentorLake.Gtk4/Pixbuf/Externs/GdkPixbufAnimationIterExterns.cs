using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Pixbuf;

public static class GdkPixbufAnimationIterExterns
{
	[DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_animation_iter_get_delay_time")]
	internal static extern int gdk_pixbuf_animation_iter_get_delay_time(this GdkPixbufAnimationIterHandle iter);

	[DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_animation_iter_get_pixbuf")]
	internal static extern GdkPixbufHandle gdk_pixbuf_animation_iter_get_pixbuf(this GdkPixbufAnimationIterHandle iter);

	[DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_animation_iter_on_currently_loading_frame")]
	internal static extern int gdk_pixbuf_animation_iter_on_currently_loading_frame(this GdkPixbufAnimationIterHandle iter);

	[DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_animation_iter_advance")]
	internal static extern int gdk_pixbuf_animation_iter_advance(this GdkPixbufAnimationIterHandle iter, GTimeValHandle current_time);
}
