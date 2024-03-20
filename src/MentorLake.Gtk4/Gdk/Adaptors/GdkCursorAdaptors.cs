using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gdk;
public static class GdkCursorAdaptors
{
	public static GdkCursorHandle GetFallback(this GdkCursorHandle cursor)
	{
		return GdkCursorExterns.gdk_cursor_get_fallback(cursor);
	}

	public static string GetName(this GdkCursorHandle cursor)
	{
		return GdkCursorExterns.gdk_cursor_get_name(cursor);
	}

	public static GdkTextureHandle GetTexture(this GdkCursorHandle cursor)
	{
		return GdkCursorExterns.gdk_cursor_get_texture(cursor);
	}

	public static int GetHotspotX(this GdkCursorHandle cursor)
	{
		return GdkCursorExterns.gdk_cursor_get_hotspot_x(cursor);
	}

	public static int GetHotspotY(this GdkCursorHandle cursor)
	{
		return GdkCursorExterns.gdk_cursor_get_hotspot_y(cursor);
	}
}
