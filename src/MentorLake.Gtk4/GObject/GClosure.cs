namespace MentorLake.Gtk4.GObject;

public class GClosureHandle : BaseSafeHandle
{
	public static GClosureHandle NewObject(uint sizeof_closure, GObjectHandle @object)
	{
		return GClosureExterns.g_closure_new_object(sizeof_closure, @object);
	}

	public static GClosureHandle NewSimple(uint sizeof_closure, IntPtr data)
	{
		return GClosureExterns.g_closure_new_simple(sizeof_closure, data);
	}

}


public static class GClosureHandleExtensions
{
	public static GClosureHandle AddFinalizeNotifier(this GClosureHandle closure, IntPtr notify_data, GClosureNotify notify_func)
	{
		GClosureExterns.g_closure_add_finalize_notifier(closure, notify_data, notify_func);
		return closure;
	}

	public static GClosureHandle AddInvalidateNotifier(this GClosureHandle closure, IntPtr notify_data, GClosureNotify notify_func)
	{
		GClosureExterns.g_closure_add_invalidate_notifier(closure, notify_data, notify_func);
		return closure;
	}

	public static GClosureHandle AddMarshalGuards(this GClosureHandle closure, IntPtr pre_marshal_data, GClosureNotify pre_marshal_notify, IntPtr post_marshal_data, GClosureNotify post_marshal_notify)
	{
		GClosureExterns.g_closure_add_marshal_guards(closure, pre_marshal_data, pre_marshal_notify, post_marshal_data, post_marshal_notify);
		return closure;
	}

	public static GClosureHandle Invalidate(this GClosureHandle closure)
	{
		GClosureExterns.g_closure_invalidate(closure);
		return closure;
	}

	public static GClosureHandle Invoke(this GClosureHandle closure, out GValue return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint)
	{
		GClosureExterns.g_closure_invoke(closure, out return_value, n_param_values, param_values, invocation_hint);
		return closure;
	}

	public static GClosureHandle Ref(this GClosureHandle closure)
	{
		return GClosureExterns.g_closure_ref(closure);
	}

	public static GClosureHandle RemoveFinalizeNotifier(this GClosureHandle closure, IntPtr notify_data, GClosureNotify notify_func)
	{
		GClosureExterns.g_closure_remove_finalize_notifier(closure, notify_data, notify_func);
		return closure;
	}

	public static GClosureHandle RemoveInvalidateNotifier(this GClosureHandle closure, IntPtr notify_data, GClosureNotify notify_func)
	{
		GClosureExterns.g_closure_remove_invalidate_notifier(closure, notify_data, notify_func);
		return closure;
	}

	public static GClosureHandle SetMarshal(this GClosureHandle closure, GClosureMarshal marshal)
	{
		GClosureExterns.g_closure_set_marshal(closure, marshal);
		return closure;
	}

	public static GClosureHandle SetMetaMarshal(this GClosureHandle closure, IntPtr marshal_data, GClosureMarshal meta_marshal)
	{
		GClosureExterns.g_closure_set_meta_marshal(closure, marshal_data, meta_marshal);
		return closure;
	}

	public static GClosureHandle Sink(this GClosureHandle closure)
	{
		GClosureExterns.g_closure_sink(closure);
		return closure;
	}

	public static GClosureHandle Unref(this GClosureHandle closure)
	{
		GClosureExterns.g_closure_unref(closure);
		return closure;
	}

}
internal class GClosureExterns
{
	[DllImport(Libraries.GObject)]
	internal static extern GClosureHandle g_closure_new_object(uint sizeof_closure, GObjectHandle @object);

	[DllImport(Libraries.GObject)]
	internal static extern GClosureHandle g_closure_new_simple(uint sizeof_closure, IntPtr data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_closure_add_finalize_notifier(GClosureHandle closure, IntPtr notify_data, GClosureNotify notify_func);

	[DllImport(Libraries.GObject)]
	internal static extern void g_closure_add_invalidate_notifier(GClosureHandle closure, IntPtr notify_data, GClosureNotify notify_func);

	[DllImport(Libraries.GObject)]
	internal static extern void g_closure_add_marshal_guards(GClosureHandle closure, IntPtr pre_marshal_data, GClosureNotify pre_marshal_notify, IntPtr post_marshal_data, GClosureNotify post_marshal_notify);

	[DllImport(Libraries.GObject)]
	internal static extern void g_closure_invalidate(GClosureHandle closure);

	[DllImport(Libraries.GObject)]
	internal static extern void g_closure_invoke(GClosureHandle closure, out GValue return_value, uint n_param_values, GValue[] param_values, IntPtr invocation_hint);

	[DllImport(Libraries.GObject)]
	internal static extern GClosureHandle g_closure_ref(GClosureHandle closure);

	[DllImport(Libraries.GObject)]
	internal static extern void g_closure_remove_finalize_notifier(GClosureHandle closure, IntPtr notify_data, GClosureNotify notify_func);

	[DllImport(Libraries.GObject)]
	internal static extern void g_closure_remove_invalidate_notifier(GClosureHandle closure, IntPtr notify_data, GClosureNotify notify_func);

	[DllImport(Libraries.GObject)]
	internal static extern void g_closure_set_marshal(GClosureHandle closure, GClosureMarshal marshal);

	[DllImport(Libraries.GObject)]
	internal static extern void g_closure_set_meta_marshal(GClosureHandle closure, IntPtr marshal_data, GClosureMarshal meta_marshal);

	[DllImport(Libraries.GObject)]
	internal static extern void g_closure_sink(GClosureHandle closure);

	[DllImport(Libraries.GObject)]
	internal static extern void g_closure_unref(GClosureHandle closure);

}

public struct GClosure
{
	public uint in_marshal;
	public uint is_invalid;
	public IntPtr marshal;
}
