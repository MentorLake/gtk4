namespace MentorLake.Gtk4.GLib;

public class GPrivateHandle : BaseSafeHandle
{
}


public static class GPrivateHandleExtensions
{
	public static IntPtr Get(this GPrivateHandle key)
	{
		return GPrivateExterns.g_private_get(key);
	}

	public static GPrivateHandle Replace(this GPrivateHandle key, IntPtr value)
	{
		GPrivateExterns.g_private_replace(key, value);
		return key;
	}

	public static GPrivateHandle Set(this GPrivateHandle key, IntPtr value)
	{
		GPrivateExterns.g_private_set(key, value);
		return key;
	}

}
internal class GPrivateExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_private_get(GPrivateHandle key);

	[DllImport(Libraries.GLib)]
	internal static extern void g_private_replace(GPrivateHandle key, IntPtr value);

	[DllImport(Libraries.GLib)]
	internal static extern void g_private_set(GPrivateHandle key, IntPtr value);

}

public struct GPrivate
{
}
