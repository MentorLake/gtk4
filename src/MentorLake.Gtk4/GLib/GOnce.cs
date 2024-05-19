namespace MentorLake.Gtk4.GLib;

public class GOnceHandle : BaseSafeHandle
{
}

internal class GOnceExterns
{
}

public struct GOnce
{
	public GOnceStatus status;
	public IntPtr retval;
}
