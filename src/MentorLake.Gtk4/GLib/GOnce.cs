namespace MentorLake.Gtk4.GLib;

public class GOnceHandle : BaseSafeHandle
{
}


public static class GOnceHandleExtensions
{
	public static IntPtr Impl(this GOnceHandle once, GThreadFunc func, IntPtr arg)
	{
		return GOnceExterns.g_once_impl(once, func, arg);
	}

}
internal class GOnceExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_once_impl(GOnceHandle once, GThreadFunc func, IntPtr arg);

}

public struct GOnce
{
	public GOnceStatus status;
	public IntPtr retval;
}
