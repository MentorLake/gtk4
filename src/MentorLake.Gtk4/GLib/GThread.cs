namespace MentorLake.Gtk4.GLib;

public class GThreadHandle : BaseSafeHandle
{
	public static GThreadHandle New(string name, GThreadFunc func, IntPtr data)
	{
		return GThreadExterns.g_thread_new(name, func, data);
	}

	public static GThreadHandle TryNew(string name, GThreadFunc func, IntPtr data, out GErrorHandle error)
	{
		return GThreadExterns.g_thread_try_new(name, func, data, out error);
	}

}

internal class GThreadExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GThreadHandle g_thread_new(string name, GThreadFunc func, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern GThreadHandle g_thread_try_new(string name, GThreadFunc func, IntPtr data, out GErrorHandle error);

}

public struct GThread
{
}
