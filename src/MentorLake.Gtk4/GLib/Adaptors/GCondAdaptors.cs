using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GCondAdaptors
{
	public static GCondHandle Init(this GCondHandle cond)
	{
		GCondExterns.g_cond_init(cond);
		return cond;
	}

	public static GCondHandle Clear(this GCondHandle cond)
	{
		GCondExterns.g_cond_clear(cond);
		return cond;
	}

	public static GCondHandle Wait(this GCondHandle cond, GMutexHandle mutex)
	{
		GCondExterns.g_cond_wait(cond, mutex);
		return cond;
	}

	public static GCondHandle Signal(this GCondHandle cond)
	{
		GCondExterns.g_cond_signal(cond);
		return cond;
	}

	public static GCondHandle Broadcast(this GCondHandle cond)
	{
		GCondExterns.g_cond_broadcast(cond);
		return cond;
	}

	public static int WaitUntil(this GCondHandle cond, GMutexHandle mutex, nint end_time)
	{
		return GCondExterns.g_cond_wait_until(cond, mutex, end_time);
	}

	public static GCondHandle Free(this GCondHandle cond)
	{
		GCondExterns.g_cond_free(cond);
		return cond;
	}

	public static int TimedWait(this GCondHandle cond, GMutexHandle mutex, GTimeValHandle timeval)
	{
		return GCondExterns.g_cond_timed_wait(cond, mutex, timeval);
	}
}
