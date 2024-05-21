namespace MentorLake.Gtk4.GLib;

public class GTimerHandle : BaseSafeHandle
{
}


public static class GTimerHandleExtensions
{
	public static GTimerHandle Continue(this GTimerHandle timer)
	{
		GTimerExterns.g_timer_continue(timer);
		return timer;
	}

	public static GTimerHandle Destroy(this GTimerHandle timer)
	{
		GTimerExterns.g_timer_destroy(timer);
		return timer;
	}

	public static double Elapsed(this GTimerHandle timer, out ulong microseconds)
	{
		return GTimerExterns.g_timer_elapsed(timer, out microseconds);
	}

	public static bool IsActive(this GTimerHandle timer)
	{
		return GTimerExterns.g_timer_is_active(timer);
	}

	public static GTimerHandle Reset(this GTimerHandle timer)
	{
		GTimerExterns.g_timer_reset(timer);
		return timer;
	}

	public static GTimerHandle Start(this GTimerHandle timer)
	{
		GTimerExterns.g_timer_start(timer);
		return timer;
	}

	public static GTimerHandle Stop(this GTimerHandle timer)
	{
		GTimerExterns.g_timer_stop(timer);
		return timer;
	}

}
internal class GTimerExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_timer_continue(GTimerHandle timer);

	[DllImport(Libraries.GLib)]
	internal static extern void g_timer_destroy(GTimerHandle timer);

	[DllImport(Libraries.GLib)]
	internal static extern double g_timer_elapsed(GTimerHandle timer, out ulong microseconds);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_timer_is_active(GTimerHandle timer);

	[DllImport(Libraries.GLib)]
	internal static extern void g_timer_reset(GTimerHandle timer);

	[DllImport(Libraries.GLib)]
	internal static extern void g_timer_start(GTimerHandle timer);

	[DllImport(Libraries.GLib)]
	internal static extern void g_timer_stop(GTimerHandle timer);

}

public struct GTimer
{
}
