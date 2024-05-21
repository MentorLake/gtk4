namespace MentorLake.Gtk4.GLib;

public class GThreadPoolHandle : BaseSafeHandle
{
}


public static class GThreadPoolHandleExtensions
{
	public static GThreadPoolHandle Free(this GThreadPoolHandle pool, bool immediate, bool wait_)
	{
		GThreadPoolExterns.g_thread_pool_free(pool, immediate, wait_);
		return pool;
	}

	public static int GetMaxThreads(this GThreadPoolHandle pool)
	{
		return GThreadPoolExterns.g_thread_pool_get_max_threads(pool);
	}

	public static uint GetNumThreads(this GThreadPoolHandle pool)
	{
		return GThreadPoolExterns.g_thread_pool_get_num_threads(pool);
	}

	public static bool MoveToFront(this GThreadPoolHandle pool, IntPtr data)
	{
		return GThreadPoolExterns.g_thread_pool_move_to_front(pool, data);
	}

	public static bool Push(this GThreadPoolHandle pool, IntPtr data, out GErrorHandle error)
	{
		return GThreadPoolExterns.g_thread_pool_push(pool, data, out error);
	}

	public static bool SetMaxThreads(this GThreadPoolHandle pool, int max_threads, out GErrorHandle error)
	{
		return GThreadPoolExterns.g_thread_pool_set_max_threads(pool, max_threads, out error);
	}

	public static GThreadPoolHandle SetSortFunction(this GThreadPoolHandle pool, GCompareDataFunc func, IntPtr user_data)
	{
		GThreadPoolExterns.g_thread_pool_set_sort_function(pool, func, user_data);
		return pool;
	}

	public static uint Unprocessed(this GThreadPoolHandle pool)
	{
		return GThreadPoolExterns.g_thread_pool_unprocessed(pool);
	}

}
internal class GThreadPoolExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_thread_pool_free(GThreadPoolHandle pool, bool immediate, bool wait_);

	[DllImport(Libraries.GLib)]
	internal static extern int g_thread_pool_get_max_threads(GThreadPoolHandle pool);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_thread_pool_get_num_threads(GThreadPoolHandle pool);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_thread_pool_move_to_front(GThreadPoolHandle pool, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_thread_pool_push(GThreadPoolHandle pool, IntPtr data, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_thread_pool_set_max_threads(GThreadPoolHandle pool, int max_threads, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern void g_thread_pool_set_sort_function(GThreadPoolHandle pool, GCompareDataFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_thread_pool_unprocessed(GThreadPoolHandle pool);

}

public struct GThreadPool
{
	public GFunc func;
	public IntPtr user_data;
	public bool exclusive;
}
