namespace MentorLake.Gtk4.Gio;

public class GBytesIconHandle : GObjectHandle, GIconHandle, GLoadableIconHandle
{
	public static GBytesIconHandle New(GBytesHandle bytes)
	{
		return GBytesIconExterns.g_bytes_icon_new(bytes);
	}

}

public static class GBytesIconHandleExtensions
{
	public static GBytesHandle GetBytes(this GBytesIconHandle icon)
	{
		return GBytesIconExterns.g_bytes_icon_get_bytes(icon);
	}

}

internal class GBytesIconExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GBytesIconHandle g_bytes_icon_new(GBytesHandle bytes);

	[DllImport(Libraries.Gio)]
	internal static extern GBytesHandle g_bytes_icon_get_bytes(GBytesIconHandle icon);

}
