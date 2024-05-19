namespace MentorLake.Gtk4.GLib;

public class GKeyFileHandle : BaseSafeHandle
{
	public static GKeyFileHandle New()
	{
		return GKeyFileExterns.g_key_file_new();
	}

}

internal class GKeyFileExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GKeyFileHandle g_key_file_new();

}

public struct GKeyFile
{
}
