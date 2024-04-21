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

namespace MentorLake.Gtk4.Gtk4;

public class GtkImageHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkImageHandle New()
	{
		return GtkImageExterns.gtk_image_new();
	}

	public static GtkImageHandle NewFromFile(string filename)
	{
		return GtkImageExterns.gtk_image_new_from_file(filename);
	}

	public static GtkImageHandle NewFromGicon(GIconHandle icon)
	{
		return GtkImageExterns.gtk_image_new_from_gicon(icon);
	}

	public static GtkImageHandle NewFromIconName(string icon_name)
	{
		return GtkImageExterns.gtk_image_new_from_icon_name(icon_name);
	}

	public static GtkImageHandle NewFromPaintable(GdkPaintableHandle paintable)
	{
		return GtkImageExterns.gtk_image_new_from_paintable(paintable);
	}

	public static GtkImageHandle NewFromPixbuf(GdkPixbufHandle pixbuf)
	{
		return GtkImageExterns.gtk_image_new_from_pixbuf(pixbuf);
	}

	public static GtkImageHandle NewFromResource(string resource_path)
	{
		return GtkImageExterns.gtk_image_new_from_resource(resource_path);
	}

}

public static class GtkImageHandleExtensions
{
	public static GtkImageHandle Clear(this GtkImageHandle image)
	{
		GtkImageExterns.gtk_image_clear(image);
		return image;
	}

	public static GIconHandle GetGicon(this GtkImageHandle image)
	{
		return GtkImageExterns.gtk_image_get_gicon(image);
	}

	public static string GetIconName(this GtkImageHandle image)
	{
		return GtkImageExterns.gtk_image_get_icon_name(image);
	}

	public static GtkIconSize GetIconSize(this GtkImageHandle image)
	{
		return GtkImageExterns.gtk_image_get_icon_size(image);
	}

	public static GdkPaintableHandle GetPaintable(this GtkImageHandle image)
	{
		return GtkImageExterns.gtk_image_get_paintable(image);
	}

	public static int GetPixelSize(this GtkImageHandle image)
	{
		return GtkImageExterns.gtk_image_get_pixel_size(image);
	}

	public static GtkImageType GetStorageType(this GtkImageHandle image)
	{
		return GtkImageExterns.gtk_image_get_storage_type(image);
	}

	public static GtkImageHandle SetFromFile(this GtkImageHandle image, string filename)
	{
		GtkImageExterns.gtk_image_set_from_file(image, filename);
		return image;
	}

	public static GtkImageHandle SetFromGicon(this GtkImageHandle image, GIconHandle icon)
	{
		GtkImageExterns.gtk_image_set_from_gicon(image, icon);
		return image;
	}

	public static GtkImageHandle SetFromIconName(this GtkImageHandle image, string icon_name)
	{
		GtkImageExterns.gtk_image_set_from_icon_name(image, icon_name);
		return image;
	}

	public static GtkImageHandle SetFromPaintable(this GtkImageHandle image, GdkPaintableHandle paintable)
	{
		GtkImageExterns.gtk_image_set_from_paintable(image, paintable);
		return image;
	}

	public static GtkImageHandle SetFromPixbuf(this GtkImageHandle image, GdkPixbufHandle pixbuf)
	{
		GtkImageExterns.gtk_image_set_from_pixbuf(image, pixbuf);
		return image;
	}

	public static GtkImageHandle SetFromResource(this GtkImageHandle image, string resource_path)
	{
		GtkImageExterns.gtk_image_set_from_resource(image, resource_path);
		return image;
	}

	public static GtkImageHandle SetIconSize(this GtkImageHandle image, GtkIconSize icon_size)
	{
		GtkImageExterns.gtk_image_set_icon_size(image, icon_size);
		return image;
	}

	public static GtkImageHandle SetPixelSize(this GtkImageHandle image, int pixel_size)
	{
		GtkImageExterns.gtk_image_set_pixel_size(image, pixel_size);
		return image;
	}

}

internal class GtkImageExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkImageHandle gtk_image_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkImageHandle gtk_image_new_from_file(string filename);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkImageHandle gtk_image_new_from_gicon(GIconHandle icon);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkImageHandle gtk_image_new_from_icon_name(string icon_name);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkImageHandle gtk_image_new_from_paintable(GdkPaintableHandle paintable);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkImageHandle gtk_image_new_from_pixbuf(GdkPixbufHandle pixbuf);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkImageHandle gtk_image_new_from_resource(string resource_path);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_image_clear(GtkImageHandle image);

	[DllImport(Libraries.Gtk4)]
	internal static extern GIconHandle gtk_image_get_gicon(GtkImageHandle image);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_image_get_icon_name(GtkImageHandle image);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkIconSize gtk_image_get_icon_size(GtkImageHandle image);

	[DllImport(Libraries.Gtk4)]
	internal static extern GdkPaintableHandle gtk_image_get_paintable(GtkImageHandle image);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_image_get_pixel_size(GtkImageHandle image);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkImageType gtk_image_get_storage_type(GtkImageHandle image);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_image_set_from_file(GtkImageHandle image, string filename);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_image_set_from_gicon(GtkImageHandle image, GIconHandle icon);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_image_set_from_icon_name(GtkImageHandle image, string icon_name);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_image_set_from_paintable(GtkImageHandle image, GdkPaintableHandle paintable);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_image_set_from_pixbuf(GtkImageHandle image, GdkPixbufHandle pixbuf);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_image_set_from_resource(GtkImageHandle image, string resource_path);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_image_set_icon_size(GtkImageHandle image, GtkIconSize icon_size);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_image_set_pixel_size(GtkImageHandle image, int pixel_size);

}
