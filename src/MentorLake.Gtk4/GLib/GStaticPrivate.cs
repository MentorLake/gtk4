namespace MentorLake.Gtk4.GLib;

public class GStaticPrivateHandle : BaseSafeHandle
{
}


public static class GStaticPrivateHandleExtensions
{
	public static GStaticPrivateHandle Free(this GStaticPrivateHandle private_key)
	{
		GStaticPrivateExterns.g_static_private_free(private_key);
		return private_key;
	}

	public static IntPtr Get(this GStaticPrivateHandle private_key)
	{
		return GStaticPrivateExterns.g_static_private_get(private_key);
	}

	public static GStaticPrivateHandle Init(this GStaticPrivateHandle private_key)
	{
		GStaticPrivateExterns.g_static_private_init(private_key);
		return private_key;
	}

	public static GStaticPrivateHandle Set(this GStaticPrivateHandle private_key, IntPtr data, GDestroyNotify notify)
	{
		GStaticPrivateExterns.g_static_private_set(private_key, data, notify);
		return private_key;
	}

}
internal class GStaticPrivateExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_static_private_free(GStaticPrivateHandle private_key);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_static_private_get(GStaticPrivateHandle private_key);

	[DllImport(Libraries.GLib)]
	internal static extern void g_static_private_init(GStaticPrivateHandle private_key);

	[DllImport(Libraries.GLib)]
	internal static extern void g_static_private_set(GStaticPrivateHandle private_key, IntPtr data, GDestroyNotify notify);

}

public struct GStaticPrivate
{
}
