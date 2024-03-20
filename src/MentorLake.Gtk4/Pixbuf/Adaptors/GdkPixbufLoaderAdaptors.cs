using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Pixbuf;
public static class GdkPixbufLoaderAdaptors
{
	public static GdkPixbufLoaderHandle SetSize(this GdkPixbufLoaderHandle loader, int width, int height)
	{
		GdkPixbufLoaderExterns.gdk_pixbuf_loader_set_size(loader, width, height);
		return loader;
	}

	public static int Write(this GdkPixbufLoaderHandle loader, string buf, nuint count, out GErrorHandle error)
	{
		return GdkPixbufLoaderExterns.gdk_pixbuf_loader_write(loader, buf, count, out error);
	}

	public static int WriteBytes(this GdkPixbufLoaderHandle loader, GBytesHandle buffer, out GErrorHandle error)
	{
		return GdkPixbufLoaderExterns.gdk_pixbuf_loader_write_bytes(loader, buffer, out error);
	}

	public static GdkPixbufHandle GetPixbuf(this GdkPixbufLoaderHandle loader)
	{
		return GdkPixbufLoaderExterns.gdk_pixbuf_loader_get_pixbuf(loader);
	}

	public static GdkPixbufAnimationHandle GetAnimation(this GdkPixbufLoaderHandle loader)
	{
		return GdkPixbufLoaderExterns.gdk_pixbuf_loader_get_animation(loader);
	}

	public static int Close(this GdkPixbufLoaderHandle loader, out GErrorHandle error)
	{
		return GdkPixbufLoaderExterns.gdk_pixbuf_loader_close(loader, out error);
	}

	public static GdkPixbufFormatHandle GetFormat(this GdkPixbufLoaderHandle loader)
	{
		return GdkPixbufLoaderExterns.gdk_pixbuf_loader_get_format(loader);
	}

	public static GdkPixbufLoaderHandle NewWithType(string image_type, out GErrorHandle error)
	{
		return GdkPixbufLoaderExterns.gdk_pixbuf_loader_new_with_type(image_type, out error);
	}

	public static GdkPixbufLoaderHandle NewWithMimeType(string mime_type, out GErrorHandle error)
	{
		return GdkPixbufLoaderExterns.gdk_pixbuf_loader_new_with_mime_type(mime_type, out error);
	}
}
