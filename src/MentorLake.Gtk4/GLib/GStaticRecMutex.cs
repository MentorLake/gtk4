namespace MentorLake.Gtk4.GLib;

public class GStaticRecMutexHandle : BaseSafeHandle
{
}


public static class GStaticRecMutexHandleExtensions
{
	public static GStaticRecMutexHandle Free(this GStaticRecMutexHandle mutex)
	{
		GStaticRecMutexExterns.g_static_rec_mutex_free(mutex);
		return mutex;
	}

	public static GStaticRecMutexHandle Init(this GStaticRecMutexHandle mutex)
	{
		GStaticRecMutexExterns.g_static_rec_mutex_init(mutex);
		return mutex;
	}

	public static GStaticRecMutexHandle Lock(this GStaticRecMutexHandle mutex)
	{
		GStaticRecMutexExterns.g_static_rec_mutex_lock(mutex);
		return mutex;
	}

	public static GStaticRecMutexHandle LockFull(this GStaticRecMutexHandle mutex, uint depth)
	{
		GStaticRecMutexExterns.g_static_rec_mutex_lock_full(mutex, depth);
		return mutex;
	}

	public static bool Trylock(this GStaticRecMutexHandle mutex)
	{
		return GStaticRecMutexExterns.g_static_rec_mutex_trylock(mutex);
	}

	public static GStaticRecMutexHandle Unlock(this GStaticRecMutexHandle mutex)
	{
		GStaticRecMutexExterns.g_static_rec_mutex_unlock(mutex);
		return mutex;
	}

	public static uint UnlockFull(this GStaticRecMutexHandle mutex)
	{
		return GStaticRecMutexExterns.g_static_rec_mutex_unlock_full(mutex);
	}

}
internal class GStaticRecMutexExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_static_rec_mutex_free(GStaticRecMutexHandle mutex);

	[DllImport(Libraries.GLib)]
	internal static extern void g_static_rec_mutex_init(GStaticRecMutexHandle mutex);

	[DllImport(Libraries.GLib)]
	internal static extern void g_static_rec_mutex_lock(GStaticRecMutexHandle mutex);

	[DllImport(Libraries.GLib)]
	internal static extern void g_static_rec_mutex_lock_full(GStaticRecMutexHandle mutex, uint depth);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_static_rec_mutex_trylock(GStaticRecMutexHandle mutex);

	[DllImport(Libraries.GLib)]
	internal static extern void g_static_rec_mutex_unlock(GStaticRecMutexHandle mutex);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_static_rec_mutex_unlock_full(GStaticRecMutexHandle mutex);

}

public struct GStaticRecMutex
{
}
