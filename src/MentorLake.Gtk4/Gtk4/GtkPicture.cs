using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gtk4;

public class GtkPictureHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkPictureHandle New()
	{
		return GtkPictureExterns.gtk_picture_new();
	}

	public static GtkPictureHandle NewForFile(GFileHandle file)
	{
		return GtkPictureExterns.gtk_picture_new_for_file(file);
	}

	public static GtkPictureHandle NewForFilename(string filename)
	{
		return GtkPictureExterns.gtk_picture_new_for_filename(filename);
	}

	public static GtkPictureHandle NewForPaintable(GdkPaintableHandle paintable)
	{
		return GtkPictureExterns.gtk_picture_new_for_paintable(paintable);
	}

	public static GtkPictureHandle NewForPixbuf(GdkPixbufHandle pixbuf)
	{
		return GtkPictureExterns.gtk_picture_new_for_pixbuf(pixbuf);
	}

	public static GtkPictureHandle NewForResource(string resource_path)
	{
		return GtkPictureExterns.gtk_picture_new_for_resource(resource_path);
	}

}

public static class GtkPictureHandleExtensions
{
	public static string GetAlternativeText(this GtkPictureHandle self)
	{
		return GtkPictureExterns.gtk_picture_get_alternative_text(self);
	}

	public static bool GetCanShrink(this GtkPictureHandle self)
	{
		return GtkPictureExterns.gtk_picture_get_can_shrink(self);
	}

	public static GtkContentFit GetContentFit(this GtkPictureHandle self)
	{
		return GtkPictureExterns.gtk_picture_get_content_fit(self);
	}

	public static GFileHandle GetFile(this GtkPictureHandle self)
	{
		return GtkPictureExterns.gtk_picture_get_file(self);
	}

	public static bool GetKeepAspectRatio(this GtkPictureHandle self)
	{
		return GtkPictureExterns.gtk_picture_get_keep_aspect_ratio(self);
	}

	public static GdkPaintableHandle GetPaintable(this GtkPictureHandle self)
	{
		return GtkPictureExterns.gtk_picture_get_paintable(self);
	}

	public static GtkPictureHandle SetAlternativeText(this GtkPictureHandle self, string alternative_text)
	{
		GtkPictureExterns.gtk_picture_set_alternative_text(self, alternative_text);
		return self;
	}

	public static GtkPictureHandle SetCanShrink(this GtkPictureHandle self, bool can_shrink)
	{
		GtkPictureExterns.gtk_picture_set_can_shrink(self, can_shrink);
		return self;
	}

	public static GtkPictureHandle SetContentFit(this GtkPictureHandle self, GtkContentFit content_fit)
	{
		GtkPictureExterns.gtk_picture_set_content_fit(self, content_fit);
		return self;
	}

	public static GtkPictureHandle SetFile(this GtkPictureHandle self, GFileHandle file)
	{
		GtkPictureExterns.gtk_picture_set_file(self, file);
		return self;
	}

	public static GtkPictureHandle SetFilename(this GtkPictureHandle self, string filename)
	{
		GtkPictureExterns.gtk_picture_set_filename(self, filename);
		return self;
	}

	public static GtkPictureHandle SetKeepAspectRatio(this GtkPictureHandle self, bool keep_aspect_ratio)
	{
		GtkPictureExterns.gtk_picture_set_keep_aspect_ratio(self, keep_aspect_ratio);
		return self;
	}

	public static GtkPictureHandle SetPaintable(this GtkPictureHandle self, GdkPaintableHandle paintable)
	{
		GtkPictureExterns.gtk_picture_set_paintable(self, paintable);
		return self;
	}

	public static GtkPictureHandle SetPixbuf(this GtkPictureHandle self, GdkPixbufHandle pixbuf)
	{
		GtkPictureExterns.gtk_picture_set_pixbuf(self, pixbuf);
		return self;
	}

	public static GtkPictureHandle SetResource(this GtkPictureHandle self, string resource_path)
	{
		GtkPictureExterns.gtk_picture_set_resource(self, resource_path);
		return self;
	}

}

internal class GtkPictureExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPictureHandle gtk_picture_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPictureHandle gtk_picture_new_for_file(GFileHandle file);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPictureHandle gtk_picture_new_for_filename(string filename);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPictureHandle gtk_picture_new_for_paintable(GdkPaintableHandle paintable);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPictureHandle gtk_picture_new_for_pixbuf(GdkPixbufHandle pixbuf);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPictureHandle gtk_picture_new_for_resource(string resource_path);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_picture_get_alternative_text(GtkPictureHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_picture_get_can_shrink(GtkPictureHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkContentFit gtk_picture_get_content_fit(GtkPictureHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GFileHandle gtk_picture_get_file(GtkPictureHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_picture_get_keep_aspect_ratio(GtkPictureHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GdkPaintableHandle gtk_picture_get_paintable(GtkPictureHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_picture_set_alternative_text(GtkPictureHandle self, string alternative_text);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_picture_set_can_shrink(GtkPictureHandle self, bool can_shrink);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_picture_set_content_fit(GtkPictureHandle self, GtkContentFit content_fit);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_picture_set_file(GtkPictureHandle self, GFileHandle file);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_picture_set_filename(GtkPictureHandle self, string filename);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_picture_set_keep_aspect_ratio(GtkPictureHandle self, bool keep_aspect_ratio);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_picture_set_paintable(GtkPictureHandle self, GdkPaintableHandle paintable);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_picture_set_pixbuf(GtkPictureHandle self, GdkPixbufHandle pixbuf);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_picture_set_resource(GtkPictureHandle self, string resource_path);

}
