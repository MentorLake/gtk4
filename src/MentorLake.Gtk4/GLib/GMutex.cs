namespace MentorLake.Gtk4.GLib;

public class GMutexHandle : BaseSafeHandle
{
}


public static class GMutexHandleExtensions
{
	public static GMutexHandle Clear(this GMutexHandle mutex)
	{
		GMutexExterns.g_mutex_clear(mutex);
		return mutex;
	}

	public static GMutexHandle Free(this GMutexHandle mutex)
	{
		GMutexExterns.g_mutex_free(mutex);
		return mutex;
	}

	public static GMutexHandle Init(this GMutexHandle mutex)
	{
		GMutexExterns.g_mutex_init(mutex);
		return mutex;
	}

	public static GMutexHandle Lock(this GMutexHandle mutex)
	{
		GMutexExterns.g_mutex_lock(mutex);
		return mutex;
	}

	public static bool Trylock(this GMutexHandle mutex)
	{
		return GMutexExterns.g_mutex_trylock(mutex);
	}

	public static GMutexHandle Unlock(this GMutexHandle mutex)
	{
		GMutexExterns.g_mutex_unlock(mutex);
		return mutex;
	}

}
internal class GMutexExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_mutex_clear(GMutexHandle mutex);

	[DllImport(Libraries.GLib)]
	internal static extern void g_mutex_free(GMutexHandle mutex);

	[DllImport(Libraries.GLib)]
	internal static extern void g_mutex_init(GMutexHandle mutex);

	[DllImport(Libraries.GLib)]
	internal static extern void g_mutex_lock(GMutexHandle mutex);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_mutex_trylock(GMutexHandle mutex);

	[DllImport(Libraries.GLib)]
	internal static extern void g_mutex_unlock(GMutexHandle mutex);

}

public struct GMutex
{
}
