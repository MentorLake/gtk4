namespace MentorLake.Gtk4.GLib;

public class GPollFDHandle : BaseSafeHandle
{
}


public static class GPollFDHandleExtensions
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
