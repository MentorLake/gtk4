namespace MentorLake.Gtk4.GObject;

public class GClosureNotifyDataHandle : BaseSafeHandle
{
}

internal class GClosureNotifyDataExterns
{
}

public struct GClosureNotifyData
{
	public IntPtr data;
	public GClosureNotify notify;
}
