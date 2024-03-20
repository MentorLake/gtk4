using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GThreadPoolAdaptors
{
	public static GThreadPoolHandle Free(this GThreadPoolHandle pool, int immediate, int wait_)
	{
		GThreadPoolExterns.g_thread_pool_free(pool, immediate, wait_);
		return pool;
	}

	public static int Push(this GThreadPoolHandle pool, IntPtr data, out GErrorHandle error)
	{
		return GThreadPoolExterns.g_thread_pool_push(pool, data, out error);
	}

	public static uint Unprocessed(this GThreadPoolHandle pool)
	{
		return GThreadPoolExterns.g_thread_pool_unprocessed(pool);
	}

	public static GThreadPoolHandle SetSortFunction(this GThreadPoolHandle pool, GCompareDataFunc func, IntPtr user_data)
	{
		GThreadPoolExterns.g_thread_pool_set_sort_function(pool, func, user_data);
		return pool;
	}

	public static int MoveToFront(this GThreadPoolHandle pool, IntPtr data)
	{
		return GThreadPoolExterns.g_thread_pool_move_to_front(pool, data);
	}

	public static int SetMaxThreads(this GThreadPoolHandle pool, int max_threads, out GErrorHandle error)
	{
		return GThreadPoolExterns.g_thread_pool_set_max_threads(pool, max_threads, out error);
	}

	public static int GetMaxThreads(this GThreadPoolHandle pool)
	{
		return GThreadPoolExterns.g_thread_pool_get_max_threads(pool);
	}

	public static uint GetNumThreads(this GThreadPoolHandle pool)
	{
		return GThreadPoolExterns.g_thread_pool_get_num_threads(pool);
	}

	public static GThreadPoolHandle NewFull(IntPtr func, IntPtr user_data, GDestroyNotify item_free_func, int max_threads, int exclusive, out GErrorHandle error)
	{
		return GThreadPoolExterns.g_thread_pool_new_full(func, user_data, item_free_func, max_threads, exclusive, out error);
	}
}
