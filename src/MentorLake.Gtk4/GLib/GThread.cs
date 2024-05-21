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


public static class GThreadHandleExtensions
{
	public static IntPtr Join(this GThreadHandle thread)
	{
		return GThreadExterns.g_thread_join(thread);
	}

	public static GThreadHandle Ref(this GThreadHandle thread)
	{
		return GThreadExterns.g_thread_ref(thread);
	}

	public static GThreadHandle SetPriority(this GThreadHandle thread, GThreadPriority priority)
	{
		GThreadExterns.g_thread_set_priority(thread, priority);
		return thread;
	}

	public static GThreadHandle Unref(this GThreadHandle thread)
	{
		GThreadExterns.g_thread_unref(thread);
		return thread;
	}

}
internal class GThreadExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GThreadHandle g_thread_new(string name, GThreadFunc func, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern GThreadHandle g_thread_try_new(string name, GThreadFunc func, IntPtr data, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_thread_join(GThreadHandle thread);

	[DllImport(Libraries.GLib)]
	internal static extern GThreadHandle g_thread_ref(GThreadHandle thread);

	[DllImport(Libraries.GLib)]
	internal static extern void g_thread_set_priority(GThreadHandle thread, GThreadPriority priority);

	[DllImport(Libraries.GLib)]
	internal static extern void g_thread_unref(GThreadHandle thread);

}

public struct GThread
{
}
