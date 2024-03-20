using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Pixbuf;

public static class Methods
{
	[DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark gdk_pixbuf_error_quark();

	[DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_pixbuf_get_type();

	[DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int gdk_pixbuf_calculate_rowstride(GdkColorspace colorspace, int has_alpha, int bits_per_sample, int width, int height);

	[DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void gdk_pixbuf_new_from_stream_async(GInputStreamHandle stream, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void gdk_pixbuf_new_from_stream_at_scale_async(GInputStreamHandle stream, int width, int height, int preserve_aspect_ratio, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_pixbuf_animation_get_type();

	[DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void gdk_pixbuf_animation_new_from_stream_async(GInputStreamHandle stream, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_pixbuf_animation_iter_get_type();

	[DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_pixbuf_simple_anim_get_type();

	[DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_pixbuf_simple_anim_iter_get_type();

	[DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int gdk_pixbuf_init_modules(string path, out GErrorHandle error);

	[DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_pixbuf_format_get_type();

	[DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GSListHandle gdk_pixbuf_get_formats();

	[DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GdkPixbufFormatHandle gdk_pixbuf_get_file_info(string filename, out int width, out int height);

	[DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void gdk_pixbuf_get_file_info_async(string filename, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_pixbuf_loader_get_type();

	[DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_pixbuf_alpha_mode_get_type();

	[DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_colorspace_get_type();

	[DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_pixbuf_error_get_type();

	[DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_interp_type_get_type();

	[DllImport(Libraries.Pixbuf, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_pixbuf_rotation_get_type();
}
