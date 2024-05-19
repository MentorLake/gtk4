namespace MentorLake.Gtk4.Gdk4;

public class GdkCursorHandle : GObjectHandle
{
	public static GdkCursorHandle NewFromName(string name, GdkCursorHandle fallback)
	{
		return GdkCursorExterns.gdk_cursor_new_from_name(name, fallback);
	}

	public static GdkCursorHandle NewFromTexture(GdkTextureHandle texture, int hotspot_x, int hotspot_y, GdkCursorHandle fallback)
	{
		return GdkCursorExterns.gdk_cursor_new_from_texture(texture, hotspot_x, hotspot_y, fallback);
	}

}

public static class GdkCursorHandleExtensions
{
	public static GdkCursorHandle GetFallback(this GdkCursorHandle cursor)
	{
		return GdkCursorExterns.gdk_cursor_get_fallback(cursor);
	}

	public static int GetHotspotX(this GdkCursorHandle cursor)
	{
		return GdkCursorExterns.gdk_cursor_get_hotspot_x(cursor);
	}

	public static int GetHotspotY(this GdkCursorHandle cursor)
	{
		return GdkCursorExterns.gdk_cursor_get_hotspot_y(cursor);
	}

	public static string GetName(this GdkCursorHandle cursor)
	{
		return GdkCursorExterns.gdk_cursor_get_name(cursor);
	}

	public static GdkTextureHandle GetTexture(this GdkCursorHandle cursor)
	{
		return GdkCursorExterns.gdk_cursor_get_texture(cursor);
	}

}

internal class GdkCursorExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkCursorHandle gdk_cursor_new_from_name(string name, GdkCursorHandle fallback);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkCursorHandle gdk_cursor_new_from_texture(GdkTextureHandle texture, int hotspot_x, int hotspot_y, GdkCursorHandle fallback);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkCursorHandle gdk_cursor_get_fallback(GdkCursorHandle cursor);

	[DllImport(Libraries.Gdk4)]
	internal static extern int gdk_cursor_get_hotspot_x(GdkCursorHandle cursor);

	[DllImport(Libraries.Gdk4)]
	internal static extern int gdk_cursor_get_hotspot_y(GdkCursorHandle cursor);

	[DllImport(Libraries.Gdk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_cursor_get_name(GdkCursorHandle cursor);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkTextureHandle gdk_cursor_get_texture(GdkCursorHandle cursor);

}
