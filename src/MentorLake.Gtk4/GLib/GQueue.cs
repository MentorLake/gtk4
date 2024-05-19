namespace MentorLake.Gtk4.GLib;

public class GQueueHandle : BaseSafeHandle
{
}

internal class GQueueExterns
{
}

public struct GQueue
{
	public GListHandle head;
	public GListHandle tail;
	public uint length;
}
