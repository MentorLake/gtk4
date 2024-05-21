namespace MentorLake.Gtk4.GLib;

public class GMemVTableHandle : BaseSafeHandle
{
}


public static class GMemVTableHandleExtensions
{
}
internal class GMemVTableExterns
{
}

public struct GMemVTable
{
	public IntPtr malloc;
	public IntPtr realloc;
	public IntPtr free;
	public IntPtr calloc;
	public IntPtr try_malloc;
	public IntPtr try_realloc;
}
