namespace MentorLake.Gtk4.Gio;

public class GSimpleAsyncResultHandle : GObjectHandle, GAsyncResultHandle
{
	public static GSimpleAsyncResultHandle New(GObjectHandle source_object, GAsyncReadyCallback callback, IntPtr user_data, IntPtr source_tag)
	{
		return GSimpleAsyncResultExterns.g_simple_async_result_new(source_object, callback, user_data, source_tag);
	}

	public static GSimpleAsyncResultHandle NewError(GObjectHandle source_object, GAsyncReadyCallback callback, IntPtr user_data, GQuark domain, int code, string format, IntPtr @__arglist)
	{
		return GSimpleAsyncResultExterns.g_simple_async_result_new_error(source_object, callback, user_data, domain, code, format, @__arglist);
	}

	public static GSimpleAsyncResultHandle NewFromError(GObjectHandle source_object, GAsyncReadyCallback callback, IntPtr user_data, GErrorHandle error)
	{
		return GSimpleAsyncResultExterns.g_simple_async_result_new_from_error(source_object, callback, user_data, error);
	}

	public static GSimpleAsyncResultHandle NewTakeError(GObjectHandle source_object, GAsyncReadyCallback callback, IntPtr user_data, GErrorHandle error)
	{
		return GSimpleAsyncResultExterns.g_simple_async_result_new_take_error(source_object, callback, user_data, error);
	}

	public static bool IsValid(GAsyncResultHandle result, GObjectHandle source, IntPtr source_tag)
	{
		return GSimpleAsyncResultExterns.g_simple_async_result_is_valid(result, source, source_tag);
	}

}

public static class GSimpleAsyncResultHandleExtensions
{
	public static GSimpleAsyncResultHandle Complete(this GSimpleAsyncResultHandle simple)
	{
		GSimpleAsyncResultExterns.g_simple_async_result_complete(simple);
		return simple;
	}

	public static GSimpleAsyncResultHandle CompleteInIdle(this GSimpleAsyncResultHandle simple)
	{
		GSimpleAsyncResultExterns.g_simple_async_result_complete_in_idle(simple);
		return simple;
	}

	public static bool GetOpResGboolean(this GSimpleAsyncResultHandle simple)
	{
		return GSimpleAsyncResultExterns.g_simple_async_result_get_op_res_gboolean(simple);
	}

	public static IntPtr GetOpResGpointer(this GSimpleAsyncResultHandle simple)
	{
		return GSimpleAsyncResultExterns.g_simple_async_result_get_op_res_gpointer(simple);
	}

	public static UIntPtr GetOpResGssize(this GSimpleAsyncResultHandle simple)
	{
		return GSimpleAsyncResultExterns.g_simple_async_result_get_op_res_gssize(simple);
	}

	public static IntPtr GetSourceTag(this GSimpleAsyncResultHandle simple)
	{
		return GSimpleAsyncResultExterns.g_simple_async_result_get_source_tag(simple);
	}

	public static bool PropagateError(this GSimpleAsyncResultHandle simple, out GErrorHandle error)
	{
		return GSimpleAsyncResultExterns.g_simple_async_result_propagate_error(simple, out error);
	}

	public static GSimpleAsyncResultHandle RunInThread(this GSimpleAsyncResultHandle simple, GSimpleAsyncThreadFunc func, int io_priority, GCancellableHandle cancellable)
	{
		GSimpleAsyncResultExterns.g_simple_async_result_run_in_thread(simple, func, io_priority, cancellable);
		return simple;
	}

	public static GSimpleAsyncResultHandle SetCheckCancellable(this GSimpleAsyncResultHandle simple, GCancellableHandle check_cancellable)
	{
		GSimpleAsyncResultExterns.g_simple_async_result_set_check_cancellable(simple, check_cancellable);
		return simple;
	}

	public static GSimpleAsyncResultHandle SetError(this GSimpleAsyncResultHandle simple, GQuark domain, int code, string format, IntPtr @__arglist)
	{
		GSimpleAsyncResultExterns.g_simple_async_result_set_error(simple, domain, code, format, @__arglist);
		return simple;
	}

	public static GSimpleAsyncResultHandle SetErrorVa(this GSimpleAsyncResultHandle simple, GQuark domain, int code, string format, IntPtr args)
	{
		GSimpleAsyncResultExterns.g_simple_async_result_set_error_va(simple, domain, code, format, args);
		return simple;
	}

	public static GSimpleAsyncResultHandle SetFromError(this GSimpleAsyncResultHandle simple, GErrorHandle error)
	{
		GSimpleAsyncResultExterns.g_simple_async_result_set_from_error(simple, error);
		return simple;
	}

	public static GSimpleAsyncResultHandle SetHandleCancellation(this GSimpleAsyncResultHandle simple, bool handle_cancellation)
	{
		GSimpleAsyncResultExterns.g_simple_async_result_set_handle_cancellation(simple, handle_cancellation);
		return simple;
	}

	public static GSimpleAsyncResultHandle SetOpResGboolean(this GSimpleAsyncResultHandle simple, bool op_res)
	{
		GSimpleAsyncResultExterns.g_simple_async_result_set_op_res_gboolean(simple, op_res);
		return simple;
	}

	public static GSimpleAsyncResultHandle SetOpResGpointer(this GSimpleAsyncResultHandle simple, IntPtr op_res, GDestroyNotify destroy_op_res)
	{
		GSimpleAsyncResultExterns.g_simple_async_result_set_op_res_gpointer(simple, op_res, destroy_op_res);
		return simple;
	}

	public static GSimpleAsyncResultHandle SetOpResGssize(this GSimpleAsyncResultHandle simple, UIntPtr op_res)
	{
		GSimpleAsyncResultExterns.g_simple_async_result_set_op_res_gssize(simple, op_res);
		return simple;
	}

	public static GSimpleAsyncResultHandle TakeError(this GSimpleAsyncResultHandle simple, GErrorHandle error)
	{
		GSimpleAsyncResultExterns.g_simple_async_result_take_error(simple, error);
		return simple;
	}

}

internal class GSimpleAsyncResultExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GSimpleAsyncResultHandle g_simple_async_result_new(GObjectHandle source_object, GAsyncReadyCallback callback, IntPtr user_data, IntPtr source_tag);

	[DllImport(Libraries.Gio)]
	internal static extern GSimpleAsyncResultHandle g_simple_async_result_new_error(GObjectHandle source_object, GAsyncReadyCallback callback, IntPtr user_data, GQuark domain, int code, string format, IntPtr @__arglist);

	[DllImport(Libraries.Gio)]
	internal static extern GSimpleAsyncResultHandle g_simple_async_result_new_from_error(GObjectHandle source_object, GAsyncReadyCallback callback, IntPtr user_data, GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GSimpleAsyncResultHandle g_simple_async_result_new_take_error(GObjectHandle source_object, GAsyncReadyCallback callback, IntPtr user_data, GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_simple_async_result_complete(GSimpleAsyncResultHandle simple);

	[DllImport(Libraries.Gio)]
	internal static extern void g_simple_async_result_complete_in_idle(GSimpleAsyncResultHandle simple);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_simple_async_result_get_op_res_gboolean(GSimpleAsyncResultHandle simple);

	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_simple_async_result_get_op_res_gpointer(GSimpleAsyncResultHandle simple);

	[DllImport(Libraries.Gio)]
	internal static extern UIntPtr g_simple_async_result_get_op_res_gssize(GSimpleAsyncResultHandle simple);

	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_simple_async_result_get_source_tag(GSimpleAsyncResultHandle simple);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_simple_async_result_propagate_error(GSimpleAsyncResultHandle simple, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_simple_async_result_run_in_thread(GSimpleAsyncResultHandle simple, GSimpleAsyncThreadFunc func, int io_priority, GCancellableHandle cancellable);

	[DllImport(Libraries.Gio)]
	internal static extern void g_simple_async_result_set_check_cancellable(GSimpleAsyncResultHandle simple, GCancellableHandle check_cancellable);

	[DllImport(Libraries.Gio)]
	internal static extern void g_simple_async_result_set_error(GSimpleAsyncResultHandle simple, GQuark domain, int code, string format, IntPtr @__arglist);

	[DllImport(Libraries.Gio)]
	internal static extern void g_simple_async_result_set_error_va(GSimpleAsyncResultHandle simple, GQuark domain, int code, string format, IntPtr args);

	[DllImport(Libraries.Gio)]
	internal static extern void g_simple_async_result_set_from_error(GSimpleAsyncResultHandle simple, GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_simple_async_result_set_handle_cancellation(GSimpleAsyncResultHandle simple, bool handle_cancellation);

	[DllImport(Libraries.Gio)]
	internal static extern void g_simple_async_result_set_op_res_gboolean(GSimpleAsyncResultHandle simple, bool op_res);

	[DllImport(Libraries.Gio)]
	internal static extern void g_simple_async_result_set_op_res_gpointer(GSimpleAsyncResultHandle simple, IntPtr op_res, GDestroyNotify destroy_op_res);

	[DllImport(Libraries.Gio)]
	internal static extern void g_simple_async_result_set_op_res_gssize(GSimpleAsyncResultHandle simple, UIntPtr op_res);

	[DllImport(Libraries.Gio)]
	internal static extern void g_simple_async_result_take_error(GSimpleAsyncResultHandle simple, GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_simple_async_result_is_valid(GAsyncResultHandle result, GObjectHandle source, IntPtr source_tag);

}
