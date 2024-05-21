namespace MentorLake.Gtk4.GLib;

public class GSourceFuncsHandle : BaseSafeHandle
{
}


public static class GSourceFuncsHandleExtensions
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
