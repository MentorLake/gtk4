using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.Pixbuf;

namespace MentorLake.Gtk4.Gdk;
public static class GdkTextureAdaptors
{
	public static int GetWidth(this GdkTextureHandle texture)
	{
		return GdkTextureExterns.gdk_texture_get_width(texture);
	}

	public static int GetHeight(this GdkTextureHandle texture)
	{
		return GdkTextureExterns.gdk_texture_get_height(texture);
	}

	public static GdkTextureHandle Download(this GdkTextureHandle texture, string data, nuint stride)
	{
		GdkTextureExterns.gdk_texture_download(texture, data, stride);
		return texture;
	}

	public static int SaveToPng(this GdkTextureHandle texture, string filename)
	{
		return GdkTextureExterns.gdk_texture_save_to_png(texture, filename);
	}

	public static GBytesHandle SaveToPngBytes(this GdkTextureHandle texture)
	{
		return GdkTextureExterns.gdk_texture_save_to_png_bytes(texture);
	}

	public static int SaveToTiff(this GdkTextureHandle texture, string filename)
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

	public static GdkCursorHandle GdkCursorNewFromTexture(this GdkTextureHandle texture, int hotspot_x, int hotspot_y, GdkCursorHandle fallback)
	{
		return GdkTextureExterns.gdk_cursor_new_from_texture(texture, hotspot_x, hotspot_y, fallback);
	}

	public static GdkTextureHandle NewFromResource(string resource_path)
	{
		return GdkTextureExterns.gdk_texture_new_from_resource(resource_path);
	}

	public static GdkTextureHandle NewFromFile(GFileHandle file, out GErrorHandle error)
	{
		return GdkTextureExterns.gdk_texture_new_from_file(file, out error);
	}

	public static GdkTextureHandle NewFromFilename(string path, out GErrorHandle error)
	{
		return GdkTextureExterns.gdk_texture_new_from_filename(path, out error);
	}

	public static GdkTextureHandle NewFromBytes(GBytesHandle bytes, out GErrorHandle error)
	{
		return GdkTextureExterns.gdk_texture_new_from_bytes(bytes, out error);
	}

	public static GdkTextureHandle GdkGlTextureNew(GdkGLContextHandle context, uint id, int width, int height, GDestroyNotify destroy, IntPtr data)
	{
		return GdkTextureExterns.gdk_gl_texture_new(context, id, width, height, destroy, data);
	}

	public static GdkTextureHandle GdkMemoryTextureNew(int width, int height, GdkMemoryFormat format, GBytesHandle bytes, nuint stride)
	{
		return GdkTextureExterns.gdk_memory_texture_new(width, height, format, bytes, stride);
	}
}
