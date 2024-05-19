namespace MentorLake.Gtk4.GLib;

public class GListHandle : BaseSafeHandle
{
}

internal class GListExterns
{
}

public struct GList
{
	public IntPtr data;
	public GListHandle next;
	public GListHandle prev;
}
