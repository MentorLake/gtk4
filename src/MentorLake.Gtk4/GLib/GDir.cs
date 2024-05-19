namespace MentorLake.Gtk4.GLib;

public class GDirHandle : BaseSafeHandle
{
	public static GDirHandle Open(string path, uint flags, out GErrorHandle error)
	{
		return GDirExterns.g_dir_open(path, flags, out error);
	}

}

internal class GDirExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GDirHandle g_dir_open(string path, uint flags, out GErrorHandle error);

}

public struct GDir
{
}
