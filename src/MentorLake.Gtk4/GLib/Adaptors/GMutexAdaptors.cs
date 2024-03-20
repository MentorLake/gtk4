using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GMutexAdaptors
{
	public static GMutexHandle Init(this GMutexHandle mutex)
	{
		GMutexExterns.g_mutex_init(mutex);
		return mutex;
	}

	public static GMutexHandle Clear(this GMutexHandle mutex)
	{
		GMutexExterns.g_mutex_clear(mutex);
		return mutex;
	}

	public static GMutexHandle Lock(this GMutexHandle mutex)
	{
		GMutexExterns.g_mutex_lock(mutex);
		return mutex;
	}

	public static int Trylock(this GMutexHandle mutex)
	{
		return GMutexExterns.g_mutex_trylock(mutex);
	}

	public static GMutexHandle Unlock(this GMutexHandle mutex)
	{
		GMutexExterns.g_mutex_unlock(mutex);
		return mutex;
	}

	public static GMutexHandle Free(this GMutexHandle mutex)
	{
		GMutexExterns.g_mutex_free(mutex);
		return mutex;
	}
}
