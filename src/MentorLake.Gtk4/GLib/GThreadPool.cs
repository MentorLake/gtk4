namespace MentorLake.Gtk4.GLib;

public class GThreadPoolHandle : BaseSafeHandle
{
}

internal class GThreadPoolExterns
{
}

public struct GThreadPool
{
	public GFunc func;
	public IntPtr user_data;
	public bool exclusive;
}
