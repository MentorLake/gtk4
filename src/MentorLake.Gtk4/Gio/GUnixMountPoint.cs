namespace MentorLake.Gtk4.Gio;

public class GUnixMountPointHandle : BaseSafeHandle
{
}


public static class GUnixMountPointHandleExtensions
{
	public static int Compare(this GUnixMountPointHandle mount1, GUnixMountPointHandle mount2)
	{
		return GUnixMountPointExterns.g_unix_mount_point_compare(mount1, mount2);
	}

	public static GUnixMountPointHandle Copy(this GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_copy(mount_point);
	}

	public static GUnixMountPointHandle Free(this GUnixMountPointHandle mount_point)
	{
		GUnixMountPointExterns.g_unix_mount_point_free(mount_point);
		return mount_point;
	}

	public static string GetDevicePath(this GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_get_device_path(mount_point);
	}

	public static string GetFsType(this GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_get_fs_type(mount_point);
	}

	public static string GetMountPath(this GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_get_mount_path(mount_point);
	}

	public static string GetOptions(this GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_get_options(mount_point);
	}

	public static bool GuessCanEject(this GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_guess_can_eject(mount_point);
	}

	public static GIconHandle GuessIcon(this GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_guess_icon(mount_point);
	}

	public static string GuessName(this GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_guess_name(mount_point);
	}

	public static GIconHandle GuessSymbolicIcon(this GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_guess_symbolic_icon(mount_point);
	}

	public static bool IsLoopback(this GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_is_loopback(mount_point);
	}

	public static bool IsReadonly(this GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_is_readonly(mount_point);
	}

	public static bool IsUserMountable(this GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_is_user_mountable(mount_point);
	}

}
internal class GUnixMountPointExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern int g_unix_mount_point_compare(GUnixMountPointHandle mount1, GUnixMountPointHandle mount2);

	[DllImport(Libraries.Gio)]
	internal static extern GUnixMountPointHandle g_unix_mount_point_copy(GUnixMountPointHandle mount_point);

	[DllImport(Libraries.Gio)]
	internal static extern void g_unix_mount_point_free(GUnixMountPointHandle mount_point);

	[DllImport(Libraries.Gio)]
	internal static extern string g_unix_mount_point_get_device_path(GUnixMountPointHandle mount_point);

	[DllImport(Libraries.Gio)]
	internal static extern string g_unix_mount_point_get_fs_type(GUnixMountPointHandle mount_point);

	[DllImport(Libraries.Gio)]
	internal static extern string g_unix_mount_point_get_mount_path(GUnixMountPointHandle mount_point);

	[DllImport(Libraries.Gio)]
	internal static extern string g_unix_mount_point_get_options(GUnixMountPointHandle mount_point);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_unix_mount_point_guess_can_eject(GUnixMountPointHandle mount_point);

	[DllImport(Libraries.Gio)]
	internal static extern GIconHandle g_unix_mount_point_guess_icon(GUnixMountPointHandle mount_point);

	[DllImport(Libraries.Gio)]
	internal static extern string g_unix_mount_point_guess_name(GUnixMountPointHandle mount_point);

	[DllImport(Libraries.Gio)]
	internal static extern GIconHandle g_unix_mount_point_guess_symbolic_icon(GUnixMountPointHandle mount_point);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_unix_mount_point_is_loopback(GUnixMountPointHandle mount_point);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_unix_mount_point_is_readonly(GUnixMountPointHandle mount_point);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_unix_mount_point_is_user_mountable(GUnixMountPointHandle mount_point);

}

public struct GUnixMountPoint
{
}
