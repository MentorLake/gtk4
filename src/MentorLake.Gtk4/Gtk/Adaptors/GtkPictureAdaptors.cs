using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.Pixbuf;

namespace MentorLake.Gtk4.Gtk;
public static class GtkPictureAdaptors
{
	public static GtkPictureHandle SetPaintable(this GtkPictureHandle self, GdkPaintableHandle paintable)
	{
		GtkPictureExterns.gtk_picture_set_paintable(self, paintable);
		return self;
	}

	public static GdkPaintableHandle GetPaintable(this GtkPictureHandle self)
	{
		return GtkPictureExterns.gtk_picture_get_paintable(self);
	}

	public static GtkPictureHandle SetFile(this GtkPictureHandle self, GFileHandle file)
	{
		GtkPictureExterns.gtk_picture_set_file(self, file);
		return self;
	}

	public static GFileHandle GetFile(this GtkPictureHandle self)
	{
		return GtkPictureExterns.gtk_picture_get_file(self);
	}

	public static GtkPictureHandle SetFilename(this GtkPictureHandle self, string filename)
	{
		GtkPictureExterns.gtk_picture_set_filename(self, filename);
		return self;
	}

	public static GtkPictureHandle SetResource(this GtkPictureHandle self, string resource_path)
	{
		GtkPictureExterns.gtk_picture_set_resource(self, resource_path);
		return self;
	}

	public static GtkPictureHandle SetPixbuf(this GtkPictureHandle self, GdkPixbufHandle pixbuf)
	{
		GtkPictureExterns.gtk_picture_set_pixbuf(self, pixbuf);
		return self;
	}

	public static GtkPictureHandle SetKeepAspectRatio(this GtkPictureHandle self, int keep_aspect_ratio)
	{
		GtkPictureExterns.gtk_picture_set_keep_aspect_ratio(self, keep_aspect_ratio);
		return self;
	}

	public static int GetKeepAspectRatio(this GtkPictureHandle self)
	{
		return GtkPictureExterns.gtk_picture_get_keep_aspect_ratio(self);
	}

	public static GtkPictureHandle SetCanShrink(this GtkPictureHandle self, int can_shrink)
	{
		GtkPictureExterns.gtk_picture_set_can_shrink(self, can_shrink);
		return self;
	}

	public static int GetCanShrink(this GtkPictureHandle self)
	{
		return GtkPictureExterns.gtk_picture_get_can_shrink(self);
	}

	public static GtkPictureHandle SetAlternativeText(this GtkPictureHandle self, string alternative_text)
	{
		GtkPictureExterns.gtk_picture_set_alternative_text(self, alternative_text);
		return self;
	}

	public static string GetAlternativeText(this GtkPictureHandle self)
	{
		return GtkPictureExterns.gtk_picture_get_alternative_text(self);
	}

	public static GtkPictureHandle NewForPaintable(GdkPaintableHandle paintable)
	{
		return GtkPictureExterns.gtk_picture_new_for_paintable(paintable);
	}

	public static GtkPictureHandle NewForPixbuf(GdkPixbufHandle pixbuf)
	{
		return GtkPictureExterns.gtk_picture_new_for_pixbuf(pixbuf);
	}

	public static GtkPictureHandle NewForFile(GFileHandle file)
	{
		return GtkPictureExterns.gtk_picture_new_for_file(file);
	}

	public static GtkPictureHandle NewForFilename(string filename)
	{
		return GtkPictureExterns.gtk_picture_new_for_filename(filename);
	}

	public static GtkPictureHandle NewForResource(string resource_path)
	{
		return GtkPictureExterns.gtk_picture_new_for_resource(resource_path);
	}
}
