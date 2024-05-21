namespace MentorLake.Gtk4.GLib;

public class GIOFuncsHandle : BaseSafeHandle
{
}


public static class GIOFuncsHandleExtensions
{
}
internal class GIOFuncsExterns
{
}

public struct GIOFuncs
{
	public IntPtr io_read;
	public IntPtr io_write;
	public IntPtr io_seek;
	public IntPtr io_close;
	public IntPtr io_create_watch;
	public IntPtr io_free;
	public IntPtr io_set_flags;
	public IntPtr io_get_flags;
}
