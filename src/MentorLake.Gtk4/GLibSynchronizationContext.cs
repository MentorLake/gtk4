using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4;

public class GLibSynchronizationContext : SynchronizationContext
{
	public override void Post(SendOrPostCallback d, object state)
	{
		GLibGlobalFunctionExterns.g_idle_add_full(0, _ =>
		{
			d(state);
			return false;
		}, IntPtr.Zero, null);
	}
}
