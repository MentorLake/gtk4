namespace MentorLake.Gtk4.Gio;

public class GSimplePermissionHandle : GPermissionHandle
{
	public static GSimplePermissionHandle New(bool allowed)
	{
		return GSimplePermissionExterns.g_simple_permission_new(allowed);
	}

}

public static class GSimplePermissionHandleExtensions
{
}

internal class GSimplePermissionExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GSimplePermissionHandle g_simple_permission_new(bool allowed);

}
