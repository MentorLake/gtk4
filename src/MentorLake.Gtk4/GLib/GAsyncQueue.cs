namespace MentorLake.Gtk4.GLib;

public class GAsyncQueueHandle : BaseSafeHandle
{
}


public static class GAsyncQueueHandleExtensions
{
	public static int Length(this GAsyncQueueHandle queue)
	{
		return GAsyncQueueExterns.g_async_queue_length(queue);
	}

	public static int LengthUnlocked(this GAsyncQueueHandle queue)
	{
		return GAsyncQueueExterns.g_async_queue_length_unlocked(queue);
	}

	public static GAsyncQueueHandle Lock(this GAsyncQueueHandle queue)
	{
		GAsyncQueueExterns.g_async_queue_lock(queue);
		return queue;
	}

	public static IntPtr Pop(this GAsyncQueueHandle queue)
	{
		return GAsyncQueueExterns.g_async_queue_pop(queue);
	}

	public static IntPtr PopUnlocked(this GAsyncQueueHandle queue)
	{
		return GAsyncQueueExterns.g_async_queue_pop_unlocked(queue);
	}

	public static GAsyncQueueHandle Push(this GAsyncQueueHandle queue, IntPtr data)
	{
		GAsyncQueueExterns.g_async_queue_push(queue, data);
		return queue;
	}

	public static GAsyncQueueHandle PushFront(this GAsyncQueueHandle queue, IntPtr item)
	{
		GAsyncQueueExterns.g_async_queue_push_front(queue, item);
		return queue;
	}

	public static GAsyncQueueHandle PushFrontUnlocked(this GAsyncQueueHandle queue, IntPtr item)
	{
		GAsyncQueueExterns.g_async_queue_push_front_unlocked(queue, item);
		return queue;
	}

	public static GAsyncQueueHandle PushSorted(this GAsyncQueueHandle queue, IntPtr data, GCompareDataFunc func, IntPtr user_data)
	{
		GAsyncQueueExterns.g_async_queue_push_sorted(queue, data, func, user_data);
		return queue;
	}

	public static GAsyncQueueHandle PushSortedUnlocked(this GAsyncQueueHandle queue, IntPtr data, GCompareDataFunc func, IntPtr user_data)
	{
		GAsyncQueueExterns.g_async_queue_push_sorted_unlocked(queue, data, func, user_data);
		return queue;
	}

	public static GAsyncQueueHandle PushUnlocked(this GAsyncQueueHandle queue, IntPtr data)
	{
		GAsyncQueueExterns.g_async_queue_push_unlocked(queue, data);
		return queue;
	}

	public static GAsyncQueueHandle Ref(this GAsyncQueueHandle queue)
	{
		return GAsyncQueueExterns.g_async_queue_ref(queue);
	}

	public static GAsyncQueueHandle RefUnlocked(this GAsyncQueueHandle queue)
	{
		GAsyncQueueExterns.g_async_queue_ref_unlocked(queue);
		return queue;
	}

	public static bool Remove(this GAsyncQueueHandle queue, IntPtr item)
	{
		return GAsyncQueueExterns.g_async_queue_remove(queue, item);
	}

	public static bool RemoveUnlocked(this GAsyncQueueHandle queue, IntPtr item)
	{
		return GAsyncQueueExterns.g_async_queue_remove_unlocked(queue, item);
	}

	public static GAsyncQueueHandle Sort(this GAsyncQueueHandle queue, GCompareDataFunc func, IntPtr user_data)
	{
		GAsyncQueueExterns.g_async_queue_sort(queue, func, user_data);
		return queue;
	}

	public static GAsyncQueueHandle SortUnlocked(this GAsyncQueueHandle queue, GCompareDataFunc func, IntPtr user_data)
	{
		GAsyncQueueExterns.g_async_queue_sort_unlocked(queue, func, user_data);
		return queue;
	}

	public static IntPtr TimedPop(this GAsyncQueueHandle queue, GTimeValHandle end_time)
	{
		return GAsyncQueueExterns.g_async_queue_timed_pop(queue, end_time);
	}

	public static IntPtr TimedPopUnlocked(this GAsyncQueueHandle queue, GTimeValHandle end_time)
	{
		return GAsyncQueueExterns.g_async_queue_timed_pop_unlocked(queue, end_time);
	}

	public static IntPtr TimeoutPop(this GAsyncQueueHandle queue, ulong timeout)
	{
		return GAsyncQueueExterns.g_async_queue_timeout_pop(queue, timeout);
	}

	public static IntPtr TimeoutPopUnlocked(this GAsyncQueueHandle queue, ulong timeout)
	{
		return GAsyncQueueExterns.g_async_queue_timeout_pop_unlocked(queue, timeout);
	}

	public static IntPtr TryPop(this GAsyncQueueHandle queue)
	{
		return GAsyncQueueExterns.g_async_queue_try_pop(queue);
	}

	public static IntPtr TryPopUnlocked(this GAsyncQueueHandle queue)
	{
		return GAsyncQueueExterns.g_async_queue_try_pop_unlocked(queue);
	}

	public static GAsyncQueueHandle Unlock(this GAsyncQueueHandle queue)
	{
		GAsyncQueueExterns.g_async_queue_unlock(queue);
		return queue;
	}

	public static GAsyncQueueHandle Unref(this GAsyncQueueHandle queue)
	{
		GAsyncQueueExterns.g_async_queue_unref(queue);
		return queue;
	}

	public static GAsyncQueueHandle UnrefAndUnlock(this GAsyncQueueHandle queue)
	{
		GAsyncQueueExterns.g_async_queue_unref_and_unlock(queue);
		return queue;
	}

}
internal class GAsyncQueueExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern int g_async_queue_length(GAsyncQueueHandle queue);

	[DllImport(Libraries.GLib)]
	internal static extern int g_async_queue_length_unlocked(GAsyncQueueHandle queue);

	[DllImport(Libraries.GLib)]
	internal static extern void g_async_queue_lock(GAsyncQueueHandle queue);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_async_queue_pop(GAsyncQueueHandle queue);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_async_queue_pop_unlocked(GAsyncQueueHandle queue);

	[DllImport(Libraries.GLib)]
	internal static extern void g_async_queue_push(GAsyncQueueHandle queue, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_async_queue_push_front(GAsyncQueueHandle queue, IntPtr item);

	[DllImport(Libraries.GLib)]
	internal static extern void g_async_queue_push_front_unlocked(GAsyncQueueHandle queue, IntPtr item);

	[DllImport(Libraries.GLib)]
	internal static extern void g_async_queue_push_sorted(GAsyncQueueHandle queue, IntPtr data, GCompareDataFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_async_queue_push_sorted_unlocked(GAsyncQueueHandle queue, IntPtr data, GCompareDataFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_async_queue_push_unlocked(GAsyncQueueHandle queue, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern GAsyncQueueHandle g_async_queue_ref(GAsyncQueueHandle queue);

	[DllImport(Libraries.GLib)]
	internal static extern void g_async_queue_ref_unlocked(GAsyncQueueHandle queue);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_async_queue_remove(GAsyncQueueHandle queue, IntPtr item);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_async_queue_remove_unlocked(GAsyncQueueHandle queue, IntPtr item);

	[DllImport(Libraries.GLib)]
	internal static extern void g_async_queue_sort(GAsyncQueueHandle queue, GCompareDataFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_async_queue_sort_unlocked(GAsyncQueueHandle queue, GCompareDataFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_async_queue_timed_pop(GAsyncQueueHandle queue, GTimeValHandle end_time);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_async_queue_timed_pop_unlocked(GAsyncQueueHandle queue, GTimeValHandle end_time);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_async_queue_timeout_pop(GAsyncQueueHandle queue, ulong timeout);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_async_queue_timeout_pop_unlocked(GAsyncQueueHandle queue, ulong timeout);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_async_queue_try_pop(GAsyncQueueHandle queue);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_async_queue_try_pop_unlocked(GAsyncQueueHandle queue);

	[DllImport(Libraries.GLib)]
	internal static extern void g_async_queue_unlock(GAsyncQueueHandle queue);

	[DllImport(Libraries.GLib)]
	internal static extern void g_async_queue_unref(GAsyncQueueHandle queue);

	[DllImport(Libraries.GLib)]
	internal static extern void g_async_queue_unref_and_unlock(GAsyncQueueHandle queue);

}

public struct GAsyncQueue
{
}
