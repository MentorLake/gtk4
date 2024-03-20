using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GMainContextAdaptors
{
	public static GMainContextHandle Ref(this GMainContextHandle context)
	{
		return GMainContextExterns.g_main_context_ref(context);
	}

	public static GMainContextHandle Unref(this GMainContextHandle context)
	{
		GMainContextExterns.g_main_context_unref(context);
		return context;
	}

	public static int Iteration(this GMainContextHandle context, int may_block)
	{
		return GMainContextExterns.g_main_context_iteration(context, may_block);
	}

	public static int Pending(this GMainContextHandle context)
	{
		return GMainContextExterns.g_main_context_pending(context);
	}

	public static GSourceHandle FindSourceById(this GMainContextHandle context, uint source_id)
	{
		return GMainContextExterns.g_main_context_find_source_by_id(context, source_id);
	}

	public static GSourceHandle FindSourceByUserData(this GMainContextHandle context, IntPtr user_data)
	{
		return GMainContextExterns.g_main_context_find_source_by_user_data(context, user_data);
	}

	public static GSourceHandle FindSourceByFuncsUserData(this GMainContextHandle context, GSourceFuncsHandle funcs, IntPtr user_data)
	{
		return GMainContextExterns.g_main_context_find_source_by_funcs_user_data(context, funcs, user_data);
	}

	public static GMainContextHandle Wakeup(this GMainContextHandle context)
	{
		GMainContextExterns.g_main_context_wakeup(context);
		return context;
	}

	public static int Acquire(this GMainContextHandle context)
	{
		return GMainContextExterns.g_main_context_acquire(context);
	}

	public static GMainContextHandle Release(this GMainContextHandle context)
	{
		GMainContextExterns.g_main_context_release(context);
		return context;
	}

	public static int IsOwner(this GMainContextHandle context)
	{
		return GMainContextExterns.g_main_context_is_owner(context);
	}

	public static int Wait(this GMainContextHandle context, GCondHandle cond, GMutexHandle mutex)
	{
		return GMainContextExterns.g_main_context_wait(context, cond, mutex);
	}

	public static int Prepare(this GMainContextHandle context, out int priority)
	{
		return GMainContextExterns.g_main_context_prepare(context, out priority);
	}

	public static int Query(this GMainContextHandle context, int max_priority, out int timeout_, GPollFD[] fds, int n_fds)
	{
		return GMainContextExterns.g_main_context_query(context, max_priority, out timeout_, fds, n_fds);
	}

	public static int Check(this GMainContextHandle context, int max_priority, GPollFDHandle fds, int n_fds)
	{
		return GMainContextExterns.g_main_context_check(context, max_priority, fds, n_fds);
	}

	public static GMainContextHandle Dispatch(this GMainContextHandle context)
	{
		GMainContextExterns.g_main_context_dispatch(context);
		return context;
	}

	public static GMainContextHandle SetPollFunc(this GMainContextHandle context, GPollFunc func)
	{
		GMainContextExterns.g_main_context_set_poll_func(context, func);
		return context;
	}

	public static GPollFunc GetPollFunc(this GMainContextHandle context)
	{
		return GMainContextExterns.g_main_context_get_poll_func(context);
	}

	public static GMainContextHandle AddPoll(this GMainContextHandle context, GPollFDHandle fd, int priority)
	{
		GMainContextExterns.g_main_context_add_poll(context, fd, priority);
		return context;
	}

	public static GMainContextHandle RemovePoll(this GMainContextHandle context, GPollFDHandle fd)
	{
		GMainContextExterns.g_main_context_remove_poll(context, fd);
		return context;
	}

	public static GMainContextHandle PushThreadDefault(this GMainContextHandle context)
	{
		GMainContextExterns.g_main_context_push_thread_default(context);
		return context;
	}

	public static GMainContextHandle PopThreadDefault(this GMainContextHandle context)
	{
		GMainContextExterns.g_main_context_pop_thread_default(context);
		return context;
	}

	public static GMainLoopHandle GMainLoopNew(this GMainContextHandle context, int is_running)
	{
		return GMainContextExterns.g_main_loop_new(context, is_running);
	}

	public static GMainContextHandle InvokeFull(this GMainContextHandle context, int priority, GSourceFunc function, IntPtr data, GDestroyNotify notify)
	{
		GMainContextExterns.g_main_context_invoke_full(context, priority, function, data, notify);
		return context;
	}

	public static GMainContextHandle Invoke(this GMainContextHandle context, GSourceFunc function, IntPtr data)
	{
		GMainContextExterns.g_main_context_invoke(context, function, data);
		return context;
	}

	public static GMainContextHandle NewWithFlags(GMainContextFlags flags)
	{
		return GMainContextExterns.g_main_context_new_with_flags(flags);
	}
}
