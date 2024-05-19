namespace MentorLake.Gtk4.GLib;

public class GPollFDHandle : BaseSafeHandle
{
}

internal class GPollFDExterns
{
}

public struct GPollFD
{
	public int fd;
	public ushort events;
	public ushort revents;
}
