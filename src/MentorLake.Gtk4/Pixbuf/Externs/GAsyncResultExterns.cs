using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Pixbuf;

public static class GAsyncResultExterns
{
	[DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_save_to_stream_finish")]
	internal static extern int gdk_pixbuf_save_to_stream_finish(this GAsyncResultHandle async_result, out GErrorHandle error);

	[DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_animation_new_from_stream_finish")]
	internal static extern GdkPixbufAnimationHandle gdk_pixbuf_animation_new_from_stream_finish(this GAsyncResultHandle async_result, out GErrorHandle error);

	[DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_get_file_info_finish")]
	internal static extern GdkPixbufFormatHandle gdk_pixbuf_get_file_info_finish(this GAsyncResultHandle async_result, out int width, out int height, out GErrorHandle error);
}
