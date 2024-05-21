namespace MentorLake.Gtk4.GLib;

public class GStaticMutexHandle : BaseSafeHandle
{
}


public static class GStaticMutexHandleExtensions
{
	public static GStaticMutexHandle Free(this GStaticMutexHandle mutex)
	{
		GStaticMutexExterns.g_static_mutex_free(mutex);
		return mutex;
	}

	public static GMutexHandle GetMutexImpl(this GStaticMutexHandle mutex)
	{
		return GStaticMutexExterns.g_static_mutex_get_mutex_impl(mutex);
	}

	public static GStaticMutexHandle Init(this GStaticMutexHandle mutex)
	{
		GStaticMutexExterns.g_static_mutex_init(mutex);
		return mutex;
	}

}
internal class GStaticMutexExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_static_mutex_free(GStaticMutexHandle mutex);

	[DllImport(Libraries.GLib)]
	internal static extern GMutexHandle g_static_mutex_get_mutex_impl(GStaticMutexHandle mutex);

	[DllImport(Libraries.GLib)]
	internal static extern void g_static_mutex_init(GStaticMutexHandle mutex);

}

public struct GStaticMutex
{
	public GMutexHandle mutex;
}
