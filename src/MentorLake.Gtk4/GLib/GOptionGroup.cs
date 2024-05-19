namespace MentorLake.Gtk4.GLib;

public class GOptionGroupHandle : BaseSafeHandle
{
	public static GOptionGroupHandle New(string name, string description, string help_description, IntPtr user_data, GDestroyNotify destroy)
	{
		return GOptionGroupExterns.g_option_group_new(name, description, help_description, user_data, destroy);
	}

}

internal class GOptionGroupExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GOptionGroupHandle g_option_group_new(string name, string description, string help_description, IntPtr user_data, GDestroyNotify destroy);

}

public struct GOptionGroup
{
}
