using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pixbuf;
public static class GdkPixbufFormatAdaptors
{
    public static string GetName(this GdkPixbufFormatHandle format)
    {
        return GdkPixbufFormatExterns.gdk_pixbuf_format_get_name(format);
    }

    public static string GetDescription(this GdkPixbufFormatHandle format)
    {
        return GdkPixbufFormatExterns.gdk_pixbuf_format_get_description(format);
    }

    public static string[] GetMimeTypes(this GdkPixbufFormatHandle format)
    {
        return GdkPixbufFormatExterns.gdk_pixbuf_format_get_mime_types(format);
    }

    public static string[] GetExtensions(this GdkPixbufFormatHandle format)
    {
        return GdkPixbufFormatExterns.gdk_pixbuf_format_get_extensions(format);
    }

    public static int IsSaveOptionSupported(this GdkPixbufFormatHandle format, string option_key)
    {
        return GdkPixbufFormatExterns.gdk_pixbuf_format_is_save_option_supported(format, option_key);
    }

    public static int IsWritable(this GdkPixbufFormatHandle format)
    {
        return GdkPixbufFormatExterns.gdk_pixbuf_format_is_writable(format);
    }

    public static int IsScalable(this GdkPixbufFormatHandle format)
    {
        return GdkPixbufFormatExterns.gdk_pixbuf_format_is_scalable(format);
    }

    public static int IsDisabled(this GdkPixbufFormatHandle format)
    {
        return GdkPixbufFormatExterns.gdk_pixbuf_format_is_disabled(format);
    }

    public static GdkPixbufFormatHandle SetDisabled(this GdkPixbufFormatHandle format, int disabled)
    {
        GdkPixbufFormatExterns.gdk_pixbuf_format_set_disabled(format, disabled);
        return format;
    }

    public static string GetLicense(this GdkPixbufFormatHandle format)
    {
        return GdkPixbufFormatExterns.gdk_pixbuf_format_get_license(format);
    }

    public static GdkPixbufFormatHandle Copy(this GdkPixbufFormatHandle format)
    {
        return GdkPixbufFormatExterns.gdk_pixbuf_format_copy(format);
    }

    public static GdkPixbufFormatHandle Free(this GdkPixbufFormatHandle format)
    {
        GdkPixbufFormatExterns.gdk_pixbuf_format_free(format);
        return format;
    }
}
