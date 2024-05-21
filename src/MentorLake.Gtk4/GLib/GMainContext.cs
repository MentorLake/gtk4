namespace MentorLake.Gtk4.GLib;

public class GMainContextHandle : BaseSafeHandle
{
	public static GMainContextHandle New()
	{
		return GMainContextExterns.g_main_context_new();
	}

	public static GMainContextHandle NewWithFlags(GMainContextFlags flags)
	{
		return GMainContextExterns.g_main_context_new_with_flags(flags);
	}

}


public static class GMainContextHandleExtensions
{
	public static bool Acquire(this GMainContextHandle context)
	{
		return GMainContextExterns.g_main_context_acquire(context);
	}

	public static GMainContextHandle AddPoll(this GMainContextHandle context, GPollFDHandle fd, int priority)
	{
		GMainContextExterns.g_main_context_add_poll(context, fd, priority);
		return context;
	}

	public static bool Check(this GMainContextHandle context, int max_priority, GPollFD[] fds, int n_fds)
	{
		return GMainContextExterns.g_main_context_check(context, max_priority, fds, n_fds);
	}

	public static GMainContextHandle Dispatch(this GMainContextHandle context)
	{
		GMainContextExterns.g_main_context_dispatch(context);
		return context;
	}

	public static GSourceHandle FindSourceByFuncsUserData(this GMainContextHandle context, GSourceFuncsHandle funcs, IntPtr user_data)
	{
		return GMainContextExterns.g_main_context_find_source_by_funcs_user_data(context, funcs, user_data);
	}

	public static GSourceHandle FindSourceById(this GMainContextHandle context, uint source_id)
	{
		return GMainContextExterns.g_main_context_find_source_by_id(context, source_id);
	}

	public static GSourceHandle FindSourceByUserData(this GMainContextHandle context, IntPtr user_data)
	{
		return GMainContextExterns.g_main_context_find_source_by_user_data(context, user_data);
	}

	public static GPollFunc GetPollFunc(this GMainContextHandle context)
	{
		return GMainContextExterns.g_main_context_get_poll_func(context);
	}

	public static GMainContextHandle Invoke(this GMainContextHandle context, GSourceFunc function, IntPtr data)
	{
		GMainContextExterns.g_main_context_invoke(context, function, data);
		return context;
	}

	public static GMainContextHandle InvokeFull(this GMainContextHandle context, int priority, GSourceFunc function, IntPtr data, GDestroyNotify notify)
	{
		GMainContextExterns.g_main_context_invoke_full(context, priority, function, data, notify);
		return context;
	}

	public static bool IsOwner(this GMainContextHandle context)
	{
		return GMainContextExterns.g_main_context_is_owner(context);
	}

	public static bool Iteration(this GMainContextHandle context, bool may_block)
	{
		return GMainContextExterns.g_main_context_iteration(context, may_block);
	}

	public static bool Pending(this GMainContextHandle context)
	{
		return GMainContextExterns.g_main_context_pending(context);
	}

	public static GMainContextHandle PopThreadDefault(this GMainContextHandle context)
	{
		GMainContextExterns.g_main_context_pop_thread_default(context);
		return context;
	}

	public static bool Prepare(this GMainContextHandle context, out int priority)
	{
		return GMainContextExterns.g_main_context_prepare(context, out priority);
	}

	public static GMainContextHandle PushThreadDefault(this GMainContextHandle context)
	{
		GMainContextExterns.g_main_context_push_thread_default(context);
		return context;
	}

	public static int Query(this GMainContextHandle context, int max_priority, out int timeout_, out GPollFD fds, int n_fds)
	{
		return GMainContextExterns.g_main_context_query(context, max_priority, out timeout_, out fds, n_fds);
	}

	public static GMainContextHandle Ref(this GMainContextHandle context)
	{
		return GMainContextExterns.g_main_context_ref(context);
	}

	public static GMainContextHandle Release(this GMainContextHandle context)
	{
		GMainContextExterns.g_main_context_release(context);
		return context;
	}

	public static GMainContextHandle RemovePoll(this GMainContextHandle context, GPollFDHandle fd)
	{
		GMainContextExterns.g_main_context_remove_poll(context, fd);
		return context;
	}

	public static GMainContextHandle SetPollFunc(this GMainContextHandle context, GPollFunc func)
	{
		GMainContextExterns.g_main_context_set_poll_func(context, func);
		return context;
	}

	public static GMainContextHandle Unref(this GMainContextHandle context)
	{
		GMainContextExterns.g_main_context_unref(context);
		return context;
	}

	public static bool Wait(this GMainContextHandle context, GCondHandle cond, GMutexHandle mutex)
	{
		return GMainContextExterns.g_main_context_wait(context, cond, mutex);
	}

	public static GMainContextHandle Wakeup(this GMainContextHandle context)
	{
		GMainContextExterns.g_main_context_wakeup(context);
		return context;
	}

}
internal class GMainContextExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GMainContextHandle g_main_context_new();

	[DllImport(Libraries.GLib)]
	internal static extern GMainContextHandle g_main_context_new_with_flags(GMainContextFlags flags);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_main_context_acquire(GMainContextHandle context);

	[DllImport(Libraries.GLib)]
	internal static extern void g_main_context_add_poll(GMainContextHandle context, GPollFDHandle fd, int priority);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_main_context_check(GMainContextHandle context, int max_priority, GPollFD[] fds, int n_fds);

	[DllImport(Libraries.GLib)]
	internal static extern void g_main_context_dispatch(GMainContextHandle context);

	[DllImport(Libraries.GLib)]
	internal static extern GSourceHandle g_main_context_find_source_by_funcs_user_data(GMainContextHandle context, GSourceFuncsHandle funcs, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern GSourceHandle g_main_context_find_source_by_id(GMainContextHandle context, uint source_id);

	[DllImport(Libraries.GLib)]
	internal static extern GSourceHandle g_main_context_find_source_by_user_data(GMainContextHandle context, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern GPollFunc g_main_context_get_poll_func(GMainContextHandle context);

	[DllImport(Libraries.GLib)]
	internal static extern void g_main_context_invoke(GMainContextHandle context, GSourceFunc function, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_main_context_invoke_full(GMainContextHandle context, int priority, GSourceFunc function, IntPtr data, GDestroyNotify notify);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_main_context_is_owner(GMainContextHandle context);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_main_context_iteration(GMainContextHandle context, bool may_block);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_main_context_pending(GMainContextHandle context);

	[DllImport(Libraries.GLib)]
	internal static extern void g_main_context_pop_thread_default(GMainContextHandle context);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_main_context_prepare(GMainContextHandle context, out int priority);

	[DllImport(Libraries.GLib)]
	internal static extern void g_main_context_push_thread_default(GMainContextHandle context);

	[DllImport(Libraries.GLib)]
	internal static extern int g_main_context_query(GMainContextHandle context, int max_priority, out int timeout_, out GPollFD fds, int n_fds);

	[DllImport(Libraries.GLib)]
	internal static extern GMainContextHandle g_main_context_ref(GMainContextHandle context);

	[DllImport(Libraries.GLib)]
	internal static extern void g_main_context_release(GMainContextHandle context);

	[DllImport(Libraries.GLib)]
	internal static extern void g_main_context_remove_poll(GMainContextHandle context, GPollFDHandle fd);

	[DllImport(Libraries.GLib)]
	internal static extern void g_main_context_set_poll_func(GMainContextHandle context, GPollFunc func);

	[DllImport(Libraries.GLib)]
	internal static extern void g_main_context_unref(GMainContextHandle context);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_main_context_wait(GMainContextHandle context, GCondHandle cond, GMutexHandle mutex);

	[DllImport(Libraries.GLib)]
	internal static extern void g_main_context_wakeup(GMainContextHandle context);

}

public struct GMainContext
{
}
