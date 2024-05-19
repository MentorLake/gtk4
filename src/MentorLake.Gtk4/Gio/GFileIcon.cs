namespace MentorLake.Gtk4.Gio;

public class GFileIconHandle : GObjectHandle, GIconHandle, GLoadableIconHandle
{
	public static GFileIconHandle New(GFileHandle file)
	{
		return GFileIconExterns.g_file_icon_new(file);
	}

}

public static class GFileIconHandleExtensions
{
	public static GFileHandle GetFile(this GFileIconHandle icon)
	{
		return GFileIconExterns.g_file_icon_get_file(icon);
	}

}

internal class GFileIconExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GFileIconHandle g_file_icon_new(GFileHandle file);

	[DllImport(Libraries.Gio)]
	internal static extern GFileHandle g_file_icon_get_file(GFileIconHandle icon);

}
