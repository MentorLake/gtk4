using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.Pixbuf;

namespace MentorLake.Gtk4.Gtk;
public static class GtkImageAdaptors
{
	public static GtkImageHandle Clear(this GtkImageHandle image)
	{
		GtkImageExterns.gtk_image_clear(image);
		return image;
	}

	public static GtkImageHandle SetFromFile(this GtkImageHandle image, string filename)
	{
		GtkImageExterns.gtk_image_set_from_file(image, filename);
		return image;
	}

	public static GtkImageHandle SetFromResource(this GtkImageHandle image, string resource_path)
	{
		GtkImageExterns.gtk_image_set_from_resource(image, resource_path);
		return image;
	}

	public static GtkImageHandle SetFromPixbuf(this GtkImageHandle image, GdkPixbufHandle pixbuf)
	{
		GtkImageExterns.gtk_image_set_from_pixbuf(image, pixbuf);
		return image;
	}

	public static GtkImageHandle SetFromPaintable(this GtkImageHandle image, GdkPaintableHandle paintable)
	{
		GtkImageExterns.gtk_image_set_from_paintable(image, paintable);
		return image;
	}

	public static GtkImageHandle SetFromIconName(this GtkImageHandle image, string icon_name)
	{
		GtkImageExterns.gtk_image_set_from_icon_name(image, icon_name);
		return image;
	}

	public static GtkImageHandle SetFromGicon(this GtkImageHandle image, GIconHandle icon)
	{
		GtkImageExterns.gtk_image_set_from_gicon(image, icon);
		return image;
	}

	public static GtkImageHandle SetPixelSize(this GtkImageHandle image, int pixel_size)
	{
		GtkImageExterns.gtk_image_set_pixel_size(image, pixel_size);
		return image;
	}

	public static GtkImageHandle SetIconSize(this GtkImageHandle image, GtkIconSize icon_size)
	{
		GtkImageExterns.gtk_image_set_icon_size(image, icon_size);
		return image;
	}

	public static GtkImageType GetStorageType(this GtkImageHandle image)
	{
		return GtkImageExterns.gtk_image_get_storage_type(image);
	}

	public static GdkPaintableHandle GetPaintable(this GtkImageHandle image)
	{
		return GtkImageExterns.gtk_image_get_paintable(image);
	}

	public static string GetIconName(this GtkImageHandle image)
	{
		return GtkImageExterns.gtk_image_get_icon_name(image);
	}

	public static GIconHandle GetGicon(this GtkImageHandle image)
	{
		return GtkImageExterns.gtk_image_get_gicon(image);
	}

	public static int GetPixelSize(this GtkImageHandle image)
	{
		return GtkImageExterns.gtk_image_get_pixel_size(image);
	}

	public static GtkIconSize GetIconSize(this GtkImageHandle image)
	{
		return GtkImageExterns.gtk_image_get_icon_size(image);
	}

	public static GtkImageHandle NewFromFile(string filename)
	{
		return GtkImageExterns.gtk_image_new_from_file(filename);
	}

	public static GtkImageHandle NewFromResource(string resource_path)
	{
		return GtkImageExterns.gtk_image_new_from_resource(resource_path);
	}

	public static GtkImageHandle NewFromPixbuf(GdkPixbufHandle pixbuf)
	{
		return GtkImageExterns.gtk_image_new_from_pixbuf(pixbuf);
	}

	public static GtkImageHandle NewFromPaintable(GdkPaintableHandle paintable)
	{
		return GtkImageExterns.gtk_image_new_from_paintable(paintable);
	}

	public static GtkImageHandle NewFromIconName(string icon_name)
	{
		return GtkImageExterns.gtk_image_new_from_icon_name(icon_name);
	}

	public static GtkImageHandle NewFromGicon(GIconHandle icon)
	{
		return GtkImageExterns.gtk_image_new_from_gicon(icon);
	}
}
