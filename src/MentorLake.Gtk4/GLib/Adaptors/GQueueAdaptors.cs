using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GQueueAdaptors
{
	public static GQueueHandle Free(this GQueueHandle queue)
	{
		GQueueExterns.g_queue_free(queue);
		return queue;
	}

	public static GQueueHandle FreeFull(this GQueueHandle queue, GDestroyNotify free_func)
	{
		GQueueExterns.g_queue_free_full(queue, free_func);
		return queue;
	}

	public static GQueueHandle Init(this GQueueHandle queue)
	{
		GQueueExterns.g_queue_init(queue);
		return queue;
	}

	public static GQueueHandle Clear(this GQueueHandle queue)
	{
		GQueueExterns.g_queue_clear(queue);
		return queue;
	}

	public static int IsEmpty(this GQueueHandle queue)
	{
		return GQueueExterns.g_queue_is_empty(queue);
	}

	public static GQueueHandle ClearFull(this GQueueHandle queue, GDestroyNotify free_func)
	{
		GQueueExterns.g_queue_clear_full(queue, free_func);
		return queue;
	}

	public static uint GetLength(this GQueueHandle queue)
	{
		return GQueueExterns.g_queue_get_length(queue);
	}

	public static GQueueHandle Reverse(this GQueueHandle queue)
	{
		GQueueExterns.g_queue_reverse(queue);
		return queue;
	}

	public static GQueueHandle Copy(this GQueueHandle queue)
	{
		return GQueueExterns.g_queue_copy(queue);
	}

	public static GQueueHandle Foreach(this GQueueHandle queue, IntPtr func, IntPtr user_data)
	{
		GQueueExterns.g_queue_foreach(queue, func, user_data);
		return queue;
	}

	public static GListHandle Find(this GQueueHandle queue, IntPtr data)
	{
		return GQueueExterns.g_queue_find(queue, data);
	}

	public static GListHandle FindCustom(this GQueueHandle queue, IntPtr data, GCompareFunc func)
	{
		return GQueueExterns.g_queue_find_custom(queue, data, func);
	}

	public static GQueueHandle Sort(this GQueueHandle queue, GCompareDataFunc compare_func, IntPtr user_data)
	{
		GQueueExterns.g_queue_sort(queue, compare_func, user_data);
		return queue;
	}

	public static GQueueHandle PushHead(this GQueueHandle queue, IntPtr data)
	{
		GQueueExterns.g_queue_push_head(queue, data);
		return queue;
	}

	public static GQueueHandle PushTail(this GQueueHandle queue, IntPtr data)
	{
		GQueueExterns.g_queue_push_tail(queue, data);
		return queue;
	}

	public static GQueueHandle PushNth(this GQueueHandle queue, IntPtr data, int n)
	{
		GQueueExterns.g_queue_push_nth(queue, data, n);
		return queue;
	}

	public static IntPtr PopHead(this GQueueHandle queue)
	{
		return GQueueExterns.g_queue_pop_head(queue);
	}

	public static IntPtr PopTail(this GQueueHandle queue)
	{
		return GQueueExterns.g_queue_pop_tail(queue);
	}

	public static IntPtr PopNth(this GQueueHandle queue, uint n)
	{
		return GQueueExterns.g_queue_pop_nth(queue, n);
	}

	public static IntPtr PeekHead(this GQueueHandle queue)
	{
		return GQueueExterns.g_queue_peek_head(queue);
	}

	public static IntPtr PeekTail(this GQueueHandle queue)
	{
		return GQueueExterns.g_queue_peek_tail(queue);
	}

	public static IntPtr PeekNth(this GQueueHandle queue, uint n)
	{
		return GQueueExterns.g_queue_peek_nth(queue, n);
	}

	public static int Index(this GQueueHandle queue, IntPtr data)
	{
		return GQueueExterns.g_queue_index(queue, data);
	}

	public static int Remove(this GQueueHandle queue, IntPtr data)
	{
		return GQueueExterns.g_queue_remove(queue, data);
	}

	public static uint RemoveAll(this GQueueHandle queue, IntPtr data)
	{
		return GQueueExterns.g_queue_remove_all(queue, data);
	}

	public static GQueueHandle InsertBefore(this GQueueHandle queue, GListHandle sibling, IntPtr data)
	{
		GQueueExterns.g_queue_insert_before(queue, sibling, data);
		return queue;
	}

	public static GQueueHandle InsertBeforeLink(this GQueueHandle queue, GListHandle sibling, GListHandle link_)
	{
		GQueueExterns.g_queue_insert_before_link(queue, sibling, link_);
		return queue;
	}

	public static GQueueHandle InsertAfter(this GQueueHandle queue, GListHandle sibling, IntPtr data)
	{
		GQueueExterns.g_queue_insert_after(queue, sibling, data);
		return queue;
	}

	public static GQueueHandle InsertAfterLink(this GQueueHandle queue, GListHandle sibling, GListHandle link_)
	{
		GQueueExterns.g_queue_insert_after_link(queue, sibling, link_);
		return queue;
	}

	public static GQueueHandle InsertSorted(this GQueueHandle queue, IntPtr data, GCompareDataFunc func, IntPtr user_data)
	{
		GQueueExterns.g_queue_insert_sorted(queue, data, func, user_data);
		return queue;
	}

	public static GQueueHandle PushHeadLink(this GQueueHandle queue, GListHandle link_)
	{
		GQueueExterns.g_queue_push_head_link(queue, link_);
		return queue;
	}

	public static GQueueHandle PushTailLink(this GQueueHandle queue, GListHandle link_)
	{
		GQueueExterns.g_queue_push_tail_link(queue, link_);
		return queue;
	}

	public static GQueueHandle PushNthLink(this GQueueHandle queue, int n, GListHandle link_)
	{
		GQueueExterns.g_queue_push_nth_link(queue, n, link_);
		return queue;
	}

	public static GListHandle PopHeadLink(this GQueueHandle queue)
	{
		return GQueueExterns.g_queue_pop_head_link(queue);
	}

	public static GListHandle PopTailLink(this GQueueHandle queue)
	{
		return GQueueExterns.g_queue_pop_tail_link(queue);
	}

	public static GListHandle PopNthLink(this GQueueHandle queue, uint n)
	{
		return GQueueExterns.g_queue_pop_nth_link(queue, n);
	}

	public static GListHandle PeekHeadLink(this GQueueHandle queue)
	{
		return GQueueExterns.g_queue_peek_head_link(queue);
	}

	public static GListHandle PeekTailLink(this GQueueHandle queue)
	{
		return GQueueExterns.g_queue_peek_tail_link(queue);
	}

	public static GListHandle PeekNthLink(this GQueueHandle queue, uint n)
	{
		return GQueueExterns.g_queue_peek_nth_link(queue, n);
	}

	public static int LinkIndex(this GQueueHandle queue, GListHandle link_)
	{
		return GQueueExterns.g_queue_link_index(queue, link_);
	}

	public static GQueueHandle Unlink(this GQueueHandle queue, GListHandle link_)
	{
		GQueueExterns.g_queue_unlink(queue, link_);
		return queue;
	}

	public static GQueueHandle DeleteLink(this GQueueHandle queue, GListHandle link_)
	{
		GQueueExterns.g_queue_delete_link(queue, link_);
		return queue;
	}
}
