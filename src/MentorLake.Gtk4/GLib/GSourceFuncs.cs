namespace MentorLake.Gtk4.GLib;

public class GSourceFuncsHandle : BaseSafeHandle
{
}

internal class GSourceFuncsExterns
{
}

public struct GSourceFuncs
{
	public IntPtr prepare;
	public IntPtr check;
	public IntPtr dispatch;
	public IntPtr finalize;
}
