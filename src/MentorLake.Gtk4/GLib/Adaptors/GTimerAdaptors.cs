using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GTimerAdaptors
{
	public static GTimerHandle Destroy(this GTimerHandle timer)
	{
		GTimerExterns.g_timer_destroy(timer);
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

	public static GTimerHandle Reset(this GTimerHandle timer)
	{
		GTimerExterns.g_timer_reset(timer);
		return timer;
	}

	public static GTimerHandle Continue(this GTimerHandle timer)
	{
		GTimerExterns.g_timer_continue(timer);
		return timer;
	}

	public static double Elapsed(this GTimerHandle timer, out nuint microseconds)
	{
		return GTimerExterns.g_timer_elapsed(timer, out microseconds);
	}

	public static int IsActive(this GTimerHandle timer)
	{
		return GTimerExterns.g_timer_is_active(timer);
	}
}
