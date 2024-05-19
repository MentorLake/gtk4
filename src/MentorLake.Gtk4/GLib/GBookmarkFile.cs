namespace MentorLake.Gtk4.GLib;

public class GBookmarkFileHandle : BaseSafeHandle
{
	public static GBookmarkFileHandle New()
	{
		return GBookmarkFileExterns.g_bookmark_file_new();
	}

}

internal class GBookmarkFileExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GBookmarkFileHandle g_bookmark_file_new();

}

public struct GBookmarkFile
{
}
