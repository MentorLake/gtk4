using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GThreadAdaptors
{
	public static GThreadHandle Ref(this GThreadHandle thread)
	{
		return GThreadExterns.g_thread_ref(thread);
	}

	public static GThreadHandle Unref(this GThreadHandle thread)
	{
		GThreadExterns.g_thread_unref(thread);
		return thread;
	}

	public static IntPtr Join(this GThreadHandle thread)
	{
		return GThreadExterns.g_thread_join(thread);
	}

	public static GThreadHandle SetPriority(this GThreadHandle thread, GThreadPriority priority)
	{
		GThreadExterns.g_thread_set_priority(thread, priority);
		return thread;
	}

	public static GThreadHandle TryNew(string name, GThreadFunc func, IntPtr data, out GErrorHandle error)
	{
		return GThreadExterns.g_thread_try_new(name, func, data, out error);
	}
}
