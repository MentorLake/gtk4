using static MentorLake.Gtk4.GLib.Methods;

namespace MentorLake.Gtk4;

public class GLibSynchronizationContext : SynchronizationContext
{
	public override void Post(SendOrPostCallback d, object state) =>
		g_idle_add_full(0, _ =>
		{
			d(state);
			return 0;
		}, IntPtr.Zero, null);
}
