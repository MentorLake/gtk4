namespace MentorLake.Gtk4.GLib;

public class GSListHandle : BaseSafeHandle
{
}

internal class GSListExterns
{
}

public struct GSList
{
	public IntPtr data;
	public GSListHandle next;
}
