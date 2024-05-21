namespace MentorLake.Gtk4.GdkPixbuf;

public class GdkPixbufFormatHandle : BaseSafeHandle
{
}


public static class GdkPixbufFormatHandleExtensions
{
	public static GdkPixbufFormatHandle Copy(this GdkPixbufFormatHandle format)
	{
		return GdkPixbufFormatExterns.gdk_pixbuf_format_copy(format);
	}

	public static GdkPixbufFormatHandle Free(this GdkPixbufFormatHandle format)
	{
		GdkPixbufFormatExterns.gdk_pixbuf_format_free(format);
		return format;
	}

	public static string GetDescription(this GdkPixbufFormatHandle format)
	{
		return GdkPixbufFormatExterns.gdk_pixbuf_format_get_description(format);
	}

	public static IntPtr GetExtensions(this GdkPixbufFormatHandle format)
	{
		return GdkPixbufFormatExterns.gdk_pixbuf_format_get_extensions(format);
	}

	public static string GetLicense(this GdkPixbufFormatHandle format)
	{
		return GdkPixbufFormatExterns.gdk_pixbuf_format_get_license(format);
	}

	public static IntPtr GetMimeTypes(this GdkPixbufFormatHandle format)
	{
		return GdkPixbufFormatExterns.gdk_pixbuf_format_get_mime_types(format);
	}

	public static string GetName(this GdkPixbufFormatHandle format)
	{
		return GdkPixbufFormatExterns.gdk_pixbuf_format_get_name(format);
	}

	public static bool IsDisabled(this GdkPixbufFormatHandle format)
	{
		return GdkPixbufFormatExterns.gdk_pixbuf_format_is_disabled(format);
	}

	public static bool IsSaveOptionSupported(this GdkPixbufFormatHandle format, string option_key)
	{
		return GdkPixbufFormatExterns.gdk_pixbuf_format_is_save_option_supported(format, option_key);
	}

	public static bool IsScalable(this GdkPixbufFormatHandle format)
	{
		return GdkPixbufFormatExterns.gdk_pixbuf_format_is_scalable(format);
	}

	public static bool IsWritable(this GdkPixbufFormatHandle format)
	{
		return GdkPixbufFormatExterns.gdk_pixbuf_format_is_writable(format);
	}

	public static GdkPixbufFormatHandle SetDisabled(this GdkPixbufFormatHandle format, bool disabled)
	{
		GdkPixbufFormatExterns.gdk_pixbuf_format_set_disabled(format, disabled);
		return format;
	}

}
internal class GdkPixbufFormatExterns
{
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufFormatHandle gdk_pixbuf_format_copy(GdkPixbufFormatHandle format);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern void gdk_pixbuf_format_free(GdkPixbufFormatHandle format);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern string gdk_pixbuf_format_get_description(GdkPixbufFormatHandle format);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern IntPtr gdk_pixbuf_format_get_extensions(GdkPixbufFormatHandle format);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern string gdk_pixbuf_format_get_license(GdkPixbufFormatHandle format);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern IntPtr gdk_pixbuf_format_get_mime_types(GdkPixbufFormatHandle format);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern string gdk_pixbuf_format_get_name(GdkPixbufFormatHandle format);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern bool gdk_pixbuf_format_is_disabled(GdkPixbufFormatHandle format);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern bool gdk_pixbuf_format_is_save_option_supported(GdkPixbufFormatHandle format, string option_key);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern bool gdk_pixbuf_format_is_scalable(GdkPixbufFormatHandle format);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern bool gdk_pixbuf_format_is_writable(GdkPixbufFormatHandle format);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern void gdk_pixbuf_format_set_disabled(GdkPixbufFormatHandle format, bool disabled);

}

public struct GdkPixbufFormat
{
	public string name;
	public GdkPixbufModulePatternHandle signature;
	public string domain;
	public string description;
	public string[] mime_types;
	public string[] extensions;
	public uint flags;
	public bool disabled;
	public string license;
}
