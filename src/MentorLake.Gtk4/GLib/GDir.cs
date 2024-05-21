namespace MentorLake.Gtk4.GLib;

public class GDirHandle : BaseSafeHandle
{
	public static GDirHandle Open(string path, uint flags, out GErrorHandle error)
	{
		return GDirExterns.g_dir_open(path, flags, out error);
	}

}


public static class GDirHandleExtensions
{
	public static GDirHandle Close(this GDirHandle dir)
	{
		GDirExterns.g_dir_close(dir);
		return dir;
	}

	public static string ReadName(this GDirHandle dir)
	{
		return GDirExterns.g_dir_read_name(dir);
	}

	public static GDirHandle Ref(this GDirHandle dir)
	{
		return GDirExterns.g_dir_ref(dir);
	}

	public static GDirHandle Rewind(this GDirHandle dir)
	{
		GDirExterns.g_dir_rewind(dir);
		return dir;
	}

	public static GDirHandle Unref(this GDirHandle dir)
	{
		GDirExterns.g_dir_unref(dir);
		return dir;
	}

}
internal class GDirExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GDirHandle g_dir_open(string path, uint flags, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern void g_dir_close(GDirHandle dir);

	[DllImport(Libraries.GLib)]
	internal static extern string g_dir_read_name(GDirHandle dir);

	[DllImport(Libraries.GLib)]
	internal static extern GDirHandle g_dir_ref(GDirHandle dir);

	[DllImport(Libraries.GLib)]
	internal static extern void g_dir_rewind(GDirHandle dir);

	[DllImport(Libraries.GLib)]
	internal static extern void g_dir_unref(GDirHandle dir);

}

public struct GDir
{
}
