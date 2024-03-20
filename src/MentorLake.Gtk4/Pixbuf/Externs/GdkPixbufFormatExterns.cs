using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pixbuf;

public static class GdkPixbufFormatExterns
{
	[DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_format_get_name")]
	internal static extern string gdk_pixbuf_format_get_name(this GdkPixbufFormatHandle format);

	[DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_format_get_description")]
	internal static extern string gdk_pixbuf_format_get_description(this GdkPixbufFormatHandle format);

	[DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_format_get_mime_types")]
	internal static extern string[] gdk_pixbuf_format_get_mime_types(this GdkPixbufFormatHandle format);

	[DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_format_get_extensions")]
	internal static extern string[] gdk_pixbuf_format_get_extensions(this GdkPixbufFormatHandle format);

	[DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_format_is_save_option_supported")]
	internal static extern int gdk_pixbuf_format_is_save_option_supported(this GdkPixbufFormatHandle format, string option_key);

	[DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_format_is_writable")]
	internal static extern int gdk_pixbuf_format_is_writable(this GdkPixbufFormatHandle format);

	[DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_format_is_scalable")]
	internal static extern int gdk_pixbuf_format_is_scalable(this GdkPixbufFormatHandle format);

	[DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_format_is_disabled")]
	internal static extern int gdk_pixbuf_format_is_disabled(this GdkPixbufFormatHandle format);

	[DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_format_set_disabled")]
	internal static extern void gdk_pixbuf_format_set_disabled(this GdkPixbufFormatHandle format, int disabled);

	[DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_format_get_license")]
	internal static extern string gdk_pixbuf_format_get_license(this GdkPixbufFormatHandle format);

	[DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_format_copy")]
	internal static extern GdkPixbufFormatHandle gdk_pixbuf_format_copy(this GdkPixbufFormatHandle format);

	[DllImport(Libraries.Pixbuf, EntryPoint = "gdk_pixbuf_format_free")]
	internal static extern void gdk_pixbuf_format_free(this GdkPixbufFormatHandle format);
}
