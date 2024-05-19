namespace MentorLake.Gtk4.GLib;

public class GNodeHandle : BaseSafeHandle
{
}

internal class GNodeExterns
{
}

public struct GNode
{
	public IntPtr data;
	public GNodeHandle next;
	public GNodeHandle prev;
	public GNodeHandle parent;
	public GNodeHandle children;
}
