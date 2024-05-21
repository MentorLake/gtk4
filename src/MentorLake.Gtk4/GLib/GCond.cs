namespace MentorLake.Gtk4.GLib;

public class GCondHandle : BaseSafeHandle
{
}


public static class GCondHandleExtensions
{
	public static GCondHandle Broadcast(this GCondHandle cond)
	{
		GCondExterns.g_cond_broadcast(cond);
		return cond;
	}

	public static GCondHandle Clear(this GCondHandle cond)
	{
		GCondExterns.g_cond_clear(cond);
		return cond;
	}

	public static GCondHandle Free(this GCondHandle cond)
	{
		GCondExterns.g_cond_free(cond);
		return cond;
	}

	public static GCondHandle Init(this GCondHandle cond)
	{
		GCondExterns.g_cond_init(cond);
		return cond;
	}

	public static GCondHandle Signal(this GCondHandle cond)
	{
		GCondExterns.g_cond_signal(cond);
		return cond;
	}

	public static bool TimedWait(this GCondHandle cond, GMutexHandle mutex, GTimeValHandle abs_time)
	{
		return GCondExterns.g_cond_timed_wait(cond, mutex, abs_time);
	}

	public static GCondHandle Wait(this GCondHandle cond, GMutexHandle mutex)
	{
		GCondExterns.g_cond_wait(cond, mutex);
		return cond;
	}

	public static bool WaitUntil(this GCondHandle cond, GMutexHandle mutex, long end_time)
	{
		return GCondExterns.g_cond_wait_until(cond, mutex, end_time);
	}

}
internal class GCondExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_cond_broadcast(GCondHandle cond);

	[DllImport(Libraries.GLib)]
	internal static extern void g_cond_clear(GCondHandle cond);

	[DllImport(Libraries.GLib)]
	internal static extern void g_cond_free(GCondHandle cond);

	[DllImport(Libraries.GLib)]
	internal static extern void g_cond_init(GCondHandle cond);

	[DllImport(Libraries.GLib)]
	internal static extern void g_cond_signal(GCondHandle cond);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_cond_timed_wait(GCondHandle cond, GMutexHandle mutex, GTimeValHandle abs_time);

	[DllImport(Libraries.GLib)]
	internal static extern void g_cond_wait(GCondHandle cond, GMutexHandle mutex);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_cond_wait_until(GCondHandle cond, GMutexHandle mutex, long end_time);

}

public struct GCond
{
}
