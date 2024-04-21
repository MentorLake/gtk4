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

namespace MentorLake.Gtk4.Gdk4;

public class GdkTextureHandle : GObjectHandle, GdkPaintableHandle, GIconHandle, GLoadableIconHandle
{
	public static GdkTextureHandle NewForPixbuf(GdkPixbufHandle pixbuf)
	{
		return GdkTextureExterns.gdk_texture_new_for_pixbuf(pixbuf);
	}

	public static GdkTextureHandle NewFromBytes(GBytesHandle bytes, out GErrorHandle error)
	{
		return GdkTextureExterns.gdk_texture_new_from_bytes(bytes, out error);
	}

	public static GdkTextureHandle NewFromFile(GFileHandle file, out GErrorHandle error)
	{
		return GdkTextureExterns.gdk_texture_new_from_file(file, out error);
	}

	public static GdkTextureHandle NewFromFilename(string path, out GErrorHandle error)
	{
		return GdkTextureExterns.gdk_texture_new_from_filename(path, out error);
	}

	public static GdkTextureHandle NewFromResource(string resource_path)
	{
		return GdkTextureExterns.gdk_texture_new_from_resource(resource_path);
	}

}

public static class GdkTextureHandleExtensions
{
	public static GdkTextureHandle Download(this GdkTextureHandle texture, string data, int stride)
	{
		GdkTextureExterns.gdk_texture_download(texture, data, stride);
		return texture;
	}

	public static GdkMemoryFormat GetFormat(this GdkTextureHandle self)
	{
		return GdkTextureExterns.gdk_texture_get_format(self);
	}

	public static int GetHeight(this GdkTextureHandle texture)
	{
		return GdkTextureExterns.gdk_texture_get_height(texture);
	}

	public static int GetWidth(this GdkTextureHandle texture)
	{
		return GdkTextureExterns.gdk_texture_get_width(texture);
	}

	public static bool SaveToPng(this GdkTextureHandle texture, string filename)
	{
		return GdkTextureExterns.gdk_texture_save_to_png(texture, filename);
	}

	public static GBytesHandle SaveToPngBytes(this GdkTextureHandle texture)
	{
		return GdkTextureExterns.gdk_texture_save_to_png_bytes(texture);
	}

	public static bool SaveToTiff(this GdkTextureHandle texture, string filename)
	{
		return GdkTextureExterns.gdk_texture_save_to_tiff(texture, filename);
	}

	public static GBytesHandle SaveToTiffBytes(this GdkTextureHandle texture)
	{
		return GdkTextureExterns.gdk_texture_save_to_tiff_bytes(texture);
	}

	public static GdkPixbufHandle GdkPixbufGetFromTexture(this GdkTextureHandle texture)
	{
		return GdkTextureExterns.gdk_pixbuf_get_from_texture(texture);
	}

}

internal class GdkTextureExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkTextureHandle gdk_texture_new_for_pixbuf(GdkPixbufHandle pixbuf);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkTextureHandle gdk_texture_new_from_bytes(GBytesHandle bytes, out GErrorHandle error);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkTextureHandle gdk_texture_new_from_file(GFileHandle file, out GErrorHandle error);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkTextureHandle gdk_texture_new_from_filename(string path, out GErrorHandle error);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkTextureHandle gdk_texture_new_from_resource(string resource_path);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_texture_download(GdkTextureHandle texture, string data, int stride);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkMemoryFormat gdk_texture_get_format(GdkTextureHandle self);

	[DllImport(Libraries.Gdk4)]
	internal static extern int gdk_texture_get_height(GdkTextureHandle texture);

	[DllImport(Libraries.Gdk4)]
	internal static extern int gdk_texture_get_width(GdkTextureHandle texture);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_texture_save_to_png(GdkTextureHandle texture, string filename);

	[DllImport(Libraries.Gdk4)]
	internal static extern GBytesHandle gdk_texture_save_to_png_bytes(GdkTextureHandle texture);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_texture_save_to_tiff(GdkTextureHandle texture, string filename);

	[DllImport(Libraries.Gdk4)]
	internal static extern GBytesHandle gdk_texture_save_to_tiff_bytes(GdkTextureHandle texture);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkPixbufHandle gdk_pixbuf_get_from_texture(GdkTextureHandle texture);

}
